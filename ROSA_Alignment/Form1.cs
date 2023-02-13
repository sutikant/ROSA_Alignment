using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using IoTronix.InstrumentControl;
using IoTronix.BackgroundTask;
using IoTronix.TestUtilities;

namespace ROSA_Alignment
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private ML9001A ml9001a;
        private TexioPSU pw8_5aps;
        private DAQ34970A daq34970a;
        private Serial arduino_serial;
        private AbortBW bw;
        private CSVFileSaver csvFileSaver;
        private EmptyControlChecker emptyControlChecker;
        private PassFailChecker passfailChecker;
        private ChartHelper chartHelper;

        private string station_name;
        private string model_name;
        private string daq34970a_port;
        private string ml9001a_port;
        private string arduino_port;
        private string pw8_5adps_port;
        private double pd_current;
        private double min_supply_current;
        private double max_supply_current;
        private double min_supply_voltage;
        private double max_supply_voltage;

        private bool stopBW = false;

        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;

            bw = new AbortBW();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.WorkerSupportsCancellation = true;
        }

        private void PortsOpen()
        {
            try
            {
                ml9001a = ML9001A.GetInstance(ml9001a_port);
                ml9001a.Initialize();
                pw8_5aps = TexioPSU.GetInstance(pw8_5adps_port);
                pw8_5aps.Initialize();
                daq34970a = DAQ34970A.GetInstance(daq34970a_port);
                daq34970a.Initialize();
                arduino_serial = Serial.GetInstance(arduino_port, 9600);
            }
            catch(Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Failed to Open Ports",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            station_name = AppConfig.LoadValue("Station_Name");
            model_name = AppConfig.LoadValue("Model_Name");
            pw8_5adps_port = AppConfig.LoadValue("PSU_Port");
            daq34970a_port = AppConfig.LoadValue("DMM_Port");
            ml9001a_port = AppConfig.LoadValue("PM_Port");
            arduino_port = AppConfig.LoadValue("Arduino_Port");
            min_supply_current = double.Parse(AppConfig.LoadValue("Min_Supply_Current"));
            max_supply_current = double.Parse(AppConfig.LoadValue("Max_Supply_Current"));
            min_supply_voltage = double.Parse(AppConfig.LoadValue("Min_Supply_Voltage"));
            max_supply_voltage = double.Parse(AppConfig.LoadValue("Max_Supply_Voltage"));

            csvFileSaver = new CSVFileSaver("ROSA_Alignment_Result.csv", station_name, model_name);
            emptyControlChecker = new EmptyControlChecker();
            passfailChecker = new PassFailChecker();

            PortsOpen();

            tbar_Laser_Drive.Minimum = 0;
            tbar_Laser_Drive.Maximum = 100;
            tbar_Laser_Drive.Value = 0;
            tbar_Laser_Drive.Orientation = Orientation.Vertical;

            chartHelper = new ChartHelper();
            chartHelper.ConfigureChart(chart1, "", "PD Current (uA)");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (arduino_serial.IsOpen)
            {
                arduino_serial.SendData("period:20");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bw.IsBusy)
            {
                bw.Abort();
                bw.Dispose();
            }

            try
            {
                pw8_5aps.SetVoltage("A", 0.0);
                pw8_5aps.DisableOutput();
                pw8_5aps.Close();

                if (arduino_serial.IsOpen)
                {
                    arduino_serial.SendData("start:0");
                    Thread.Sleep(200);
                    arduino_serial.SendData("stop");
                    Thread.Sleep(200);
                    arduino_serial.Close();
                }

                daq34970a.Close();
                ml9001a.Close();

                MessageBox.Show("Ports Closed", "Ports Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ports Closing Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbar_Laser_Drive_MouseUp(object sender, MouseEventArgs e)
        {
            arduino_serial.SendData($"start:{tbar_Laser_Drive.Value.ToString()}");
        }

        private void btn_Save_DutyCycle_Click(object sender, EventArgs e)
        {
            AppConfig.SaveValue("Duty_Cycle", tbar_Laser_Drive.Value.ToString());
        }

        private void btn_Load_DutyCycle_Click(object sender, EventArgs e)
        {
            tbar_Laser_Drive.Value = int.Parse(AppConfig.LoadValue("Duty_Cycle"));
            Thread.Sleep(20);
            arduino_serial.SendData($"start:{tbar_Laser_Drive.Value.ToString()}");
        }

        private void btn_Get_Power_Click(object sender, EventArgs e)
        {
            (double readPower, string PowerUnit, double multiplier) = ml9001a.ReadPower();
            txb_Read_Power.Text = Math.Round((readPower * multiplier * 1000), 5).ToString();
        }

        private void btn_PSU_ON_OFF_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (btn.Text == "ON")
                {
                    btn.Text = "OFF";
                    btn.BackColor = Color.FromArgb(224, 224, 224);

                    pw8_5aps.SetVoltage("A", 0.0);
                    pw8_5aps.DisableOutput();
                }
                else if (btn.Text == "OFF")
                {
                    btn.Text = "ON";
                    btn.BackColor = Color.FromArgb(255, 178, 102);
                    
                    pw8_5aps.SetVoltage("A", 3.0);
                    pw8_5aps.SetCurrent("A", 0.2);
                    pw8_5aps.SetVoltage("B", 0.0);
                    pw8_5aps.SetCurrent("B", 0.2);
                    pw8_5aps.SetChannelState("A", true);
                    pw8_5aps.EnableOutput();
                }
            }
        }

        private void btn_Get_Supply_Voltage_Click(object sender, EventArgs e)
        {
            txb_Supply_Voltage.Clear();
            txb_PassFail_Supply_Voltage.Clear();

            string supply_voltage_V = daq34970a.GetVoltage("112", true);
            txb_Supply_Voltage.Text = supply_voltage_V;

            bool result = passfailChecker.CheckStep("Supply Voltage (V)", double.Parse(supply_voltage_V), min_supply_voltage, max_supply_voltage);
            txb_PassFail_Supply_Voltage.Text = result ? "PASS" : "FAIL";
            txb_PassFail_Supply_Voltage.ForeColor = result ? Color.Green : Color.Red;
        }

        private void btn_Get_SupplyCurrent_Click(object sender, EventArgs e)
        {
            txb_Supply_Current.Clear();
            txb_PassFail_Supply_Current.Clear();

            string supply_current_mA = daq34970a.GetMilliAmpCurrent("122", true);
            txb_Supply_Current.Text = supply_current_mA;

            bool result = passfailChecker.CheckStep("Supply Current (mA)", double.Parse(supply_current_mA), min_supply_current, max_supply_current);
            txb_PassFail_Supply_Current.Text = result ? "PASS" : "FAIL";
            txb_PassFail_Supply_Current.ForeColor = result ? Color.Green : Color.Red;
        }

        private void btn_StartRead_PD_Current_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                daq34970a.GetMilliAmpCurrent("121", true);
                stopBW = false;
                bw.RunWorkerAsync();
            }
        }

        private void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!stopBW)
            {
                pd_current = (Convert.ToDouble(daq34970a.GetMilliAmpCurrent("121", false)) * 1000);
                chartHelper.UpdateChart(chart1, "PD_Current", pd_current);

                Thread.Sleep(100);
            }
        }

        private void bw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            stopBW = false;
            chartHelper.ClearChart(chart1);
        }

        private void btn_Stop_Read_PDCurrent_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                stopBW = true;
            }
        }

        private void btn_Result_Submit_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                stopBW = true;
            }

            List<string> emptyControls = emptyControlChecker.CheckIfEmpty(this.Controls);

            if (emptyControls.Count == 0)
            {
                csvFileSaver.AddTestResult("Laser Power(mW)", double.Parse(txb_Read_Power.Text), true, txb_ROSA_Number.Text);
                csvFileSaver.AddTestResult("Supply Voltage(V)", double.Parse(txb_Supply_Voltage.Text), 
                    csvFileSaver.ConvertToBoolean(txb_PassFail_Supply_Voltage.Text), txb_ROSA_Number.Text);
                csvFileSaver.AddTestResult("Supply Current(mA)", double.Parse(txb_Supply_Current.Text),
                    csvFileSaver.ConvertToBoolean(txb_PassFail_Supply_Current.Text), txb_ROSA_Number.Text);
                csvFileSaver.AddTestResult("PD Current(uA)", pd_current, true, txb_ROSA_Number.Text);
                csvFileSaver.SaveResults();

                txb_Read_Power.Clear();
                txb_Supply_Current.Clear();
                txb_ROSA_Number.Clear();
                txb_PassFail_Supply_Current.Clear();
                txb_PassFail_Supply_Voltage.Clear();
                txb_Supply_Voltage.Clear();
            }
            else
            {
                string message = "The following controls are empty: ";

                foreach (string controlName in emptyControls)
                {
                    message += "\n" + controlName;
                }

                MessageBox.Show($"{message}", "Blank field found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btn_PSU_ON_OFF.PerformClick();
        }

        private void btn_Result_File_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(csvFileSaver.GetCSVFilePath());
        }
    }  
}
