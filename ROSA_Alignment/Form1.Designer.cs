namespace ROSA_Alignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbar_Laser_Drive = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Load_DutyCycle = new System.Windows.Forms.Button();
            this.btn_Save_DutyCycle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Read_Power = new System.Windows.Forms.TextBox();
            this.btn_Get_Power = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb_PassFail_Supply_Current = new System.Windows.Forms.TextBox();
            this.txb_Supply_Current = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Get_SupplyCurrent = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Stop_Read_PDCurrent = new System.Windows.Forms.Button();
            this.btn_StartRead_PD_Current = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btn_Result_Submit = new System.Windows.Forms.Button();
            this.txb_ROSA_Number = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Result_File = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_PSU_ON_OFF = new System.Windows.Forms.Button();
            this.txb_PassFail_Supply_Voltage = new System.Windows.Forms.TextBox();
            this.txb_Supply_Voltage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Get_Supply_Voltage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Laser_Drive)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbar_Laser_Drive
            // 
            this.tbar_Laser_Drive.Location = new System.Drawing.Point(16, 34);
            this.tbar_Laser_Drive.Name = "tbar_Laser_Drive";
            this.tbar_Laser_Drive.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbar_Laser_Drive.Size = new System.Drawing.Size(45, 220);
            this.tbar_Laser_Drive.TabIndex = 0;
            this.tbar_Laser_Drive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbar_Laser_Drive_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Load_DutyCycle);
            this.groupBox1.Controls.Add(this.btn_Save_DutyCycle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbar_Laser_Drive);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 348);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Laser Drive Control";
            // 
            // btn_Load_DutyCycle
            // 
            this.btn_Load_DutyCycle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Load_DutyCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load_DutyCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Load_DutyCycle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Load_DutyCycle.Location = new System.Drawing.Point(16, 274);
            this.btn_Load_DutyCycle.Name = "btn_Load_DutyCycle";
            this.btn_Load_DutyCycle.Size = new System.Drawing.Size(75, 23);
            this.btn_Load_DutyCycle.TabIndex = 4;
            this.btn_Load_DutyCycle.Text = "LOAD";
            this.btn_Load_DutyCycle.UseVisualStyleBackColor = false;
            this.btn_Load_DutyCycle.Click += new System.EventHandler(this.btn_Load_DutyCycle_Click);
            // 
            // btn_Save_DutyCycle
            // 
            this.btn_Save_DutyCycle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Save_DutyCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_DutyCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Save_DutyCycle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save_DutyCycle.Location = new System.Drawing.Point(16, 308);
            this.btn_Save_DutyCycle.Name = "btn_Save_DutyCycle";
            this.btn_Save_DutyCycle.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_DutyCycle.TabIndex = 3;
            this.btn_Save_DutyCycle.Text = "SAVE";
            this.btn_Save_DutyCycle.UseVisualStyleBackColor = false;
            this.btn_Save_DutyCycle.Click += new System.EventHandler(this.btn_Save_DutyCycle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_Read_Power);
            this.groupBox2.Controls.Add(this.btn_Get_Power);
            this.groupBox2.Location = new System.Drawing.Point(123, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Laser Power";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Laser Power (mW):";
            // 
            // txb_Read_Power
            // 
            this.txb_Read_Power.Location = new System.Drawing.Point(109, 30);
            this.txb_Read_Power.Name = "txb_Read_Power";
            this.txb_Read_Power.Size = new System.Drawing.Size(111, 20);
            this.txb_Read_Power.TabIndex = 6;
            // 
            // btn_Get_Power
            // 
            this.btn_Get_Power.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Get_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Get_Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Get_Power.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Get_Power.Location = new System.Drawing.Point(238, 28);
            this.btn_Get_Power.Name = "btn_Get_Power";
            this.btn_Get_Power.Size = new System.Drawing.Size(111, 23);
            this.btn_Get_Power.TabIndex = 5;
            this.btn_Get_Power.Text = "GET POWER";
            this.btn_Get_Power.UseVisualStyleBackColor = false;
            this.btn_Get_Power.Click += new System.EventHandler(this.btn_Get_Power_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txb_PassFail_Supply_Current);
            this.groupBox3.Controls.Add(this.txb_Supply_Current);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btn_Get_SupplyCurrent);
            this.groupBox3.Location = new System.Drawing.Point(123, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 79);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4. Supply Current";
            // 
            // txb_PassFail_Supply_Current
            // 
            this.txb_PassFail_Supply_Current.Location = new System.Drawing.Point(379, 35);
            this.txb_PassFail_Supply_Current.Name = "txb_PassFail_Supply_Current";
            this.txb_PassFail_Supply_Current.Size = new System.Drawing.Size(75, 20);
            this.txb_PassFail_Supply_Current.TabIndex = 15;
            this.txb_PassFail_Supply_Current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_Supply_Current
            // 
            this.txb_Supply_Current.Location = new System.Drawing.Point(109, 35);
            this.txb_Supply_Current.Name = "txb_Supply_Current";
            this.txb_Supply_Current.Size = new System.Drawing.Size(111, 20);
            this.txb_Supply_Current.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Supply Current (mA):";
            // 
            // btn_Get_SupplyCurrent
            // 
            this.btn_Get_SupplyCurrent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Get_SupplyCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Get_SupplyCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Get_SupplyCurrent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Get_SupplyCurrent.Location = new System.Drawing.Point(238, 33);
            this.btn_Get_SupplyCurrent.Name = "btn_Get_SupplyCurrent";
            this.btn_Get_SupplyCurrent.Size = new System.Drawing.Size(111, 23);
            this.btn_Get_SupplyCurrent.TabIndex = 6;
            this.btn_Get_SupplyCurrent.Text = "GET CURRENT";
            this.btn_Get_SupplyCurrent.UseVisualStyleBackColor = false;
            this.btn_Get_SupplyCurrent.Click += new System.EventHandler(this.btn_Get_SupplyCurrent_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Stop_Read_PDCurrent);
            this.groupBox4.Controls.Add(this.btn_StartRead_PD_Current);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Location = new System.Drawing.Point(123, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 315);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "5. PD Bias Current";
            // 
            // btn_Stop_Read_PDCurrent
            // 
            this.btn_Stop_Read_PDCurrent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Stop_Read_PDCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop_Read_PDCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Stop_Read_PDCurrent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Stop_Read_PDCurrent.Location = new System.Drawing.Point(355, 16);
            this.btn_Stop_Read_PDCurrent.Name = "btn_Stop_Read_PDCurrent";
            this.btn_Stop_Read_PDCurrent.Size = new System.Drawing.Size(111, 23);
            this.btn_Stop_Read_PDCurrent.TabIndex = 9;
            this.btn_Stop_Read_PDCurrent.Text = "STOP";
            this.btn_Stop_Read_PDCurrent.UseVisualStyleBackColor = false;
            this.btn_Stop_Read_PDCurrent.Click += new System.EventHandler(this.btn_Stop_Read_PDCurrent_Click);
            // 
            // btn_StartRead_PD_Current
            // 
            this.btn_StartRead_PD_Current.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_StartRead_PD_Current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartRead_PD_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_StartRead_PD_Current.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_StartRead_PD_Current.Location = new System.Drawing.Point(238, 16);
            this.btn_StartRead_PD_Current.Name = "btn_StartRead_PD_Current";
            this.btn_StartRead_PD_Current.Size = new System.Drawing.Size(111, 23);
            this.btn_StartRead_PD_Current.TabIndex = 8;
            this.btn_StartRead_PD_Current.Text = "START READ";
            this.btn_StartRead_PD_Current.UseVisualStyleBackColor = false;
            this.btn_StartRead_PD_Current.Click += new System.EventHandler(this.btn_StartRead_PD_Current_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 45);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "PD_Current";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(475, 261);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // btn_Result_Submit
            // 
            this.btn_Result_Submit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Result_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Result_Submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Result_Submit.Location = new System.Drawing.Point(291, 38);
            this.btn_Result_Submit.Name = "btn_Result_Submit";
            this.btn_Result_Submit.Size = new System.Drawing.Size(72, 22);
            this.btn_Result_Submit.TabIndex = 10;
            this.btn_Result_Submit.Text = "SUBMIT";
            this.btn_Result_Submit.UseVisualStyleBackColor = false;
            this.btn_Result_Submit.Click += new System.EventHandler(this.btn_Result_Submit_Click);
            // 
            // txb_ROSA_Number
            // 
            this.txb_ROSA_Number.Location = new System.Drawing.Point(92, 40);
            this.txb_ROSA_Number.Name = "txb_ROSA_Number";
            this.txb_ROSA_Number.Size = new System.Drawing.Size(193, 20);
            this.txb_ROSA_Number.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "ROSA Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(98, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Please fill out this field manually...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txb_ROSA_Number);
            this.groupBox5.Controls.Add(this.btn_Result_Submit);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(123, 642);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(397, 92);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "6. Result Submission";
            // 
            // btn_Result_File
            // 
            this.btn_Result_File.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Result_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Result_File.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Result_File.Location = new System.Drawing.Point(526, 669);
            this.btn_Result_File.Name = "btn_Result_File";
            this.btn_Result_File.Size = new System.Drawing.Size(72, 44);
            this.btn_Result_File.TabIndex = 14;
            this.btn_Result_File.Text = "RESULT FILE";
            this.btn_Result_File.UseVisualStyleBackColor = false;
            this.btn_Result_File.Click += new System.EventHandler(this.btn_Result_File_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.btn_PSU_ON_OFF);
            this.groupBox6.Controls.Add(this.txb_PassFail_Supply_Voltage);
            this.groupBox6.Controls.Add(this.txb_Supply_Voltage);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.btn_Get_Supply_Voltage);
            this.groupBox6.Location = new System.Drawing.Point(123, 90);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(487, 129);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3. Supply Voltage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "PSU ON/OFF:";
            // 
            // btn_PSU_ON_OFF
            // 
            this.btn_PSU_ON_OFF.BackColor = System.Drawing.Color.Silver;
            this.btn_PSU_ON_OFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PSU_ON_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_PSU_ON_OFF.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_PSU_ON_OFF.Location = new System.Drawing.Point(109, 37);
            this.btn_PSU_ON_OFF.Name = "btn_PSU_ON_OFF";
            this.btn_PSU_ON_OFF.Size = new System.Drawing.Size(111, 23);
            this.btn_PSU_ON_OFF.TabIndex = 16;
            this.btn_PSU_ON_OFF.Text = "OFF";
            this.btn_PSU_ON_OFF.UseVisualStyleBackColor = false;
            this.btn_PSU_ON_OFF.Click += new System.EventHandler(this.btn_PSU_ON_OFF_Click);
            // 
            // txb_PassFail_Supply_Voltage
            // 
            this.txb_PassFail_Supply_Voltage.Location = new System.Drawing.Point(379, 83);
            this.txb_PassFail_Supply_Voltage.Name = "txb_PassFail_Supply_Voltage";
            this.txb_PassFail_Supply_Voltage.Size = new System.Drawing.Size(75, 20);
            this.txb_PassFail_Supply_Voltage.TabIndex = 15;
            this.txb_PassFail_Supply_Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_Supply_Voltage
            // 
            this.txb_Supply_Voltage.Location = new System.Drawing.Point(109, 83);
            this.txb_Supply_Voltage.Name = "txb_Supply_Voltage";
            this.txb_Supply_Voltage.Size = new System.Drawing.Size(111, 20);
            this.txb_Supply_Voltage.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supply Voltage (V):";
            // 
            // btn_Get_Supply_Voltage
            // 
            this.btn_Get_Supply_Voltage.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Get_Supply_Voltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Get_Supply_Voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Get_Supply_Voltage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Get_Supply_Voltage.Location = new System.Drawing.Point(238, 81);
            this.btn_Get_Supply_Voltage.Name = "btn_Get_Supply_Voltage";
            this.btn_Get_Supply_Voltage.Size = new System.Drawing.Size(111, 23);
            this.btn_Get_Supply_Voltage.TabIndex = 6;
            this.btn_Get_Supply_Voltage.Text = "GET VOLTAGE";
            this.btn_Get_Supply_Voltage.UseVisualStyleBackColor = false;
            this.btn_Get_Supply_Voltage.Click += new System.EventHandler(this.btn_Get_Supply_Voltage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 750);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_Result_File);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Laser_Drive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar tbar_Laser_Drive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save_DutyCycle;
        private System.Windows.Forms.Button btn_Load_DutyCycle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Read_Power;
        private System.Windows.Forms.Button btn_Get_Power;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txb_Supply_Current;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Get_SupplyCurrent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_StartRead_PD_Current;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_Stop_Read_PDCurrent;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Button btn_Result_Submit;
        private System.Windows.Forms.TextBox txb_ROSA_Number;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Result_File;
        private System.Windows.Forms.TextBox txb_PassFail_Supply_Current;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txb_PassFail_Supply_Voltage;
        private System.Windows.Forms.TextBox txb_Supply_Voltage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Get_Supply_Voltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PSU_ON_OFF;
    }
}

