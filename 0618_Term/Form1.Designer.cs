namespace _0618_Term
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_connect = new System.Windows.Forms.Button();
            this.chart_cylB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_cylC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_cylB_mvF = new System.Windows.Forms.Button();
            this.btn_cylB_mvB = new System.Windows.Forms.Button();
            this.gb_clyB = new System.Windows.Forms.GroupBox();
            this.gb_cylC = new System.Windows.Forms.GroupBox();
            this.btn_cylC_mvF = new System.Windows.Forms.Button();
            this.btn_cylC_mvB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_cylB = new System.Windows.Forms.PictureBox();
            this.pic_cylC = new System.Windows.Forms.PictureBox();
            this.lbl_myName = new System.Windows.Forms.Label();
            this.lbl_clyB = new System.Windows.Forms.Label();
            this.lbl_cylC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cylB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cylC)).BeginInit();
            this.gb_clyB.SuspendLayout();
            this.gb_cylC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylC)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(331, 93);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 33);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // chart_cylB
            // 
            chartArea15.Name = "ChartArea1";
            this.chart_cylB.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart_cylB.Legends.Add(legend15);
            this.chart_cylB.Location = new System.Drawing.Point(-2, 414);
            this.chart_cylB.Name = "chart_cylB";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "실린더 B";
            this.chart_cylB.Series.Add(series15);
            this.chart_cylB.Size = new System.Drawing.Size(360, 300);
            this.chart_cylB.TabIndex = 1;
            this.chart_cylB.Text = "chart1";
            // 
            // chart_cylC
            // 
            chartArea16.Name = "ChartArea1";
            this.chart_cylC.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart_cylC.Legends.Add(legend16);
            this.chart_cylC.Location = new System.Drawing.Point(364, 414);
            this.chart_cylC.Name = "chart_cylC";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "실린더 C";
            this.chart_cylC.Series.Add(series16);
            this.chart_cylC.Size = new System.Drawing.Size(372, 300);
            this.chart_cylC.TabIndex = 2;
            this.chart_cylC.Text = "chart2";
            // 
            // btn_cylB_mvF
            // 
            this.btn_cylB_mvF.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylB_mvF.Location = new System.Drawing.Point(17, 34);
            this.btn_cylB_mvF.Name = "btn_cylB_mvF";
            this.btn_cylB_mvF.Size = new System.Drawing.Size(75, 33);
            this.btn_cylB_mvF.TabIndex = 3;
            this.btn_cylB_mvF.Text = "전진";
            this.btn_cylB_mvF.UseVisualStyleBackColor = true;
            this.btn_cylB_mvF.Click += new System.EventHandler(this.btn_cylB_mvF_Click);
            // 
            // btn_cylB_mvB
            // 
            this.btn_cylB_mvB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylB_mvB.Location = new System.Drawing.Point(110, 34);
            this.btn_cylB_mvB.Name = "btn_cylB_mvB";
            this.btn_cylB_mvB.Size = new System.Drawing.Size(75, 33);
            this.btn_cylB_mvB.TabIndex = 4;
            this.btn_cylB_mvB.Text = "후진";
            this.btn_cylB_mvB.UseVisualStyleBackColor = true;
            this.btn_cylB_mvB.Click += new System.EventHandler(this.btn_cylB_mvB_Click);
            // 
            // gb_clyB
            // 
            this.gb_clyB.Controls.Add(this.btn_cylB_mvF);
            this.gb_clyB.Controls.Add(this.btn_cylB_mvB);
            this.gb_clyB.Location = new System.Drawing.Point(97, 161);
            this.gb_clyB.Name = "gb_clyB";
            this.gb_clyB.Size = new System.Drawing.Size(200, 100);
            this.gb_clyB.TabIndex = 5;
            this.gb_clyB.TabStop = false;
            this.gb_clyB.Text = "실린더 B";
            // 
            // gb_cylC
            // 
            this.gb_cylC.Controls.Add(this.btn_cylC_mvF);
            this.gb_cylC.Controls.Add(this.btn_cylC_mvB);
            this.gb_cylC.Location = new System.Drawing.Point(435, 161);
            this.gb_cylC.Name = "gb_cylC";
            this.gb_cylC.Size = new System.Drawing.Size(200, 100);
            this.gb_cylC.TabIndex = 6;
            this.gb_cylC.TabStop = false;
            this.gb_cylC.Text = "실린더 C";
            // 
            // btn_cylC_mvF
            // 
            this.btn_cylC_mvF.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylC_mvF.Location = new System.Drawing.Point(17, 34);
            this.btn_cylC_mvF.Name = "btn_cylC_mvF";
            this.btn_cylC_mvF.Size = new System.Drawing.Size(75, 33);
            this.btn_cylC_mvF.TabIndex = 3;
            this.btn_cylC_mvF.Text = "전진";
            this.btn_cylC_mvF.UseVisualStyleBackColor = true;
            this.btn_cylC_mvF.Click += new System.EventHandler(this.btn_cylC_mvF_Click);
            // 
            // btn_cylC_mvB
            // 
            this.btn_cylC_mvB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylC_mvB.Location = new System.Drawing.Point(110, 34);
            this.btn_cylC_mvB.Name = "btn_cylC_mvB";
            this.btn_cylC_mvB.Size = new System.Drawing.Size(75, 33);
            this.btn_cylC_mvB.TabIndex = 4;
            this.btn_cylC_mvB.Text = "후진";
            this.btn_cylC_mvB.UseVisualStyleBackColor = true;
            this.btn_cylC_mvB.Click += new System.EventHandler(this.btn_cylC_mvB_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_cylB
            // 
            this.pic_cylB.ImageLocation = "images/cylinder_off.png";
            this.pic_cylB.Location = new System.Drawing.Point(97, 319);
            this.pic_cylB.Name = "pic_cylB";
            this.pic_cylB.Size = new System.Drawing.Size(208, 50);
            this.pic_cylB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cylB.TabIndex = 5;
            this.pic_cylB.TabStop = false;
            // 
            // pic_cylC
            // 
            this.pic_cylC.ImageLocation = "images/cylinder_off.png";
            this.pic_cylC.Location = new System.Drawing.Point(436, 319);
            this.pic_cylC.Name = "pic_cylC";
            this.pic_cylC.Size = new System.Drawing.Size(207, 50);
            this.pic_cylC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cylC.TabIndex = 7;
            this.pic_cylC.TabStop = false;
            // 
            // lbl_myName
            // 
            this.lbl_myName.AutoSize = true;
            this.lbl_myName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_myName.Location = new System.Drawing.Point(252, 25);
            this.lbl_myName.Name = "lbl_myName";
            this.lbl_myName.Size = new System.Drawing.Size(234, 24);
            this.lbl_myName.TabIndex = 8;
            this.lbl_myName.Text = "2501110203 김호석";
            // 
            // lbl_clyB
            // 
            this.lbl_clyB.AutoSize = true;
            this.lbl_clyB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_clyB.Location = new System.Drawing.Point(142, 382);
            this.lbl_clyB.Name = "lbl_clyB";
            this.lbl_clyB.Size = new System.Drawing.Size(88, 19);
            this.lbl_clyB.TabIndex = 5;
            this.lbl_clyB.Text = "실린더 B";
            // 
            // lbl_cylC
            // 
            this.lbl_cylC.AutoSize = true;
            this.lbl_cylC.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_cylC.Location = new System.Drawing.Point(489, 382);
            this.lbl_cylC.Name = "lbl_cylC";
            this.lbl_cylC.Size = new System.Drawing.Size(89, 19);
            this.lbl_cylC.TabIndex = 9;
            this.lbl_cylC.Text = "실린더 C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 715);
            this.Controls.Add(this.lbl_cylC);
            this.Controls.Add(this.lbl_clyB);
            this.Controls.Add(this.lbl_myName);
            this.Controls.Add(this.pic_cylC);
            this.Controls.Add(this.pic_cylB);
            this.Controls.Add(this.gb_cylC);
            this.Controls.Add(this.gb_clyB);
            this.Controls.Add(this.chart_cylC);
            this.Controls.Add(this.chart_cylB);
            this.Controls.Add(this.btn_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PLC_Controler";
            ((System.ComponentModel.ISupportInitialize)(this.chart_cylB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cylC)).EndInit();
            this.gb_clyB.ResumeLayout(false);
            this.gb_cylC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cylB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cylC;
        private System.Windows.Forms.Button btn_cylB_mvF;
        private System.Windows.Forms.Button btn_cylB_mvB;
        private System.Windows.Forms.GroupBox gb_clyB;
        private System.Windows.Forms.GroupBox gb_cylC;
        private System.Windows.Forms.Button btn_cylC_mvF;
        private System.Windows.Forms.Button btn_cylC_mvB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_cylB;
        private System.Windows.Forms.PictureBox pic_cylC;
        private System.Windows.Forms.Label lbl_myName;
        private System.Windows.Forms.Label lbl_clyB;
        private System.Windows.Forms.Label lbl_cylC;
    }
}

