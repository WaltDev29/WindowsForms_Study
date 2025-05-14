namespace _0514_PLC_Control
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btn_mvForward = new System.Windows.Forms.Button();
            this.btn_mvBackward = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBox_cylinder = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox_mode = new System.Windows.Forms.PictureBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.picBox_OnOff = new System.Windows.Forms.PictureBox();
            this.lblSens = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_power = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_cylinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_OnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mvForward
            // 
            this.btn_mvForward.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.btn_mvForward.Location = new System.Drawing.Point(182, 76);
            this.btn_mvForward.Name = "btn_mvForward";
            this.btn_mvForward.Size = new System.Drawing.Size(77, 34);
            this.btn_mvForward.TabIndex = 0;
            this.btn_mvForward.Text = "전진";
            this.btn_mvForward.UseVisualStyleBackColor = true;
            this.btn_mvForward.Click += new System.EventHandler(this.btn_MvForward_Click);
            // 
            // btn_mvBackward
            // 
            this.btn_mvBackward.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.btn_mvBackward.Location = new System.Drawing.Point(265, 76);
            this.btn_mvBackward.Name = "btn_mvBackward";
            this.btn_mvBackward.Size = new System.Drawing.Size(77, 34);
            this.btn_mvBackward.TabIndex = 1;
            this.btn_mvBackward.Text = "후진";
            this.btn_mvBackward.UseVisualStyleBackColor = true;
            this.btn_mvBackward.Click += new System.EventHandler(this.btn_MvBackward_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBox_cylinder
            // 
            this.picBox_cylinder.BackColor = System.Drawing.Color.Transparent;
            this.picBox_cylinder.Image = ((System.Drawing.Image)(resources.GetObject("picBox_cylinder.Image")));
            this.picBox_cylinder.Location = new System.Drawing.Point(379, 12);
            this.picBox_cylinder.Name = "picBox_cylinder";
            this.picBox_cylinder.Size = new System.Drawing.Size(341, 90);
            this.picBox_cylinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_cylinder.TabIndex = 4;
            this.picBox_cylinder.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX2.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisY.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea9.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY2.LineColor = System.Drawing.Color.Gainsboro;
            chartArea9.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea9.BackColor = System.Drawing.Color.Black;
            chartArea9.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea9.BackSecondaryColor = System.Drawing.Color.White;
            chartArea9.BorderColor = System.Drawing.Color.White;
            chartArea9.Name = "ChartArea1";
            chartArea9.ShadowColor = System.Drawing.Color.White;
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend9.BackColor = System.Drawing.Color.DimGray;
            legend9.ForeColor = System.Drawing.Color.White;
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(0, 150);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Green;
            series9.Legend = "Legend1";
            series9.Name = "Status";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(734, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title9.BackColor = System.Drawing.Color.Transparent;
            title9.BorderWidth = 2;
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.ForeColor = System.Drawing.Color.WhiteSmoke;
            title9.Name = "title";
            title9.Text = "Status";
            this.chart1.Titles.Add(title9);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lbl_power);
            this.panel1.Controls.Add(this.picBox_mode);
            this.panel1.Controls.Add(this.lblMode);
            this.panel1.Controls.Add(this.lblSens);
            this.panel1.Controls.Add(this.picBox_OnOff);
            this.panel1.Controls.Add(this.picBox_cylinder);
            this.panel1.Controls.Add(this.btn_mvBackward);
            this.panel1.Controls.Add(this.btn_mvForward);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 144);
            this.panel1.TabIndex = 6;
            // 
            // picBox_mode
            // 
            this.picBox_mode.ImageLocation = "Images/btn_off.png";
            this.picBox_mode.Location = new System.Drawing.Point(262, 26);
            this.picBox_mode.Name = "picBox_mode";
            this.picBox_mode.Size = new System.Drawing.Size(71, 37);
            this.picBox_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_mode.TabIndex = 9;
            this.picBox_mode.TabStop = false;
            this.picBox_mode.Click += new System.EventHandler(this.picBox_mode_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblMode.Location = new System.Drawing.Point(186, 37);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(75, 16);
            this.lblMode.TabIndex = 6;
            this.lblMode.Text = "자동제어";
            // 
            // picBox_OnOff
            // 
            this.picBox_OnOff.ImageLocation = "Images/btn_off.png";
            this.picBox_OnOff.Location = new System.Drawing.Point(48, 43);
            this.picBox_OnOff.Name = "picBox_OnOff";
            this.picBox_OnOff.Size = new System.Drawing.Size(105, 52);
            this.picBox_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_OnOff.TabIndex = 5;
            this.picBox_OnOff.TabStop = false;
            this.picBox_OnOff.Click += new System.EventHandler(this.picBox_OnOff_Click);
            // 
            // lblSens
            // 
            this.lblSens.AutoSize = true;
            this.lblSens.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblSens.Location = new System.Drawing.Point(655, 115);
            this.lblSens.Name = "lblSens";
            this.lblSens.Size = new System.Drawing.Size(0, 16);
            this.lblSens.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Interval = 900;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_power
            // 
            this.lbl_power.AutoSize = true;
            this.lbl_power.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_power.Location = new System.Drawing.Point(7, 60);
            this.lbl_power.Name = "lbl_power";
            this.lbl_power.Size = new System.Drawing.Size(51, 20);
            this.lbl_power.TabIndex = 10;
            this.lbl_power.Text = "전원";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_cylinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_OnOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mvForward;
        private System.Windows.Forms.Button btn_mvBackward;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBox_cylinder;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBox_OnOff;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox picBox_mode;
        private System.Windows.Forms.Label lblSens;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_power;
    }
}

