namespace _0617_PLC_Guide_Img
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
            this.btn_cylB_mvF = new System.Windows.Forms.Button();
            this.btn_cylB_mvB = new System.Windows.Forms.Button();
            this.btn_cylC_mvB = new System.Windows.Forms.Button();
            this.btn_cylC_mvF = new System.Windows.Forms.Button();
            this.btn_liftA_down = new System.Windows.Forms.Button();
            this.btn_liftA_up = new System.Windows.Forms.Button();
            this.btn_liftB_up = new System.Windows.Forms.Button();
            this.btn_liftB_down = new System.Windows.Forms.Button();
            this.gb_cylB = new System.Windows.Forms.GroupBox();
            this.gb_cylC = new System.Windows.Forms.GroupBox();
            this.gb_liftA = new System.Windows.Forms.GroupBox();
            this.gb_liftB = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_connect = new System.Windows.Forms.PictureBox();
            this.pic_auto = new System.Windows.Forms.PictureBox();
            this.lbl_connect = new System.Windows.Forms.Label();
            this.lbl_auto = new System.Windows.Forms.Label();
            this.pic_stat_back = new System.Windows.Forms.PictureBox();
            this.pic_cylB = new System.Windows.Forms.PictureBox();
            this.pic_cylC = new System.Windows.Forms.PictureBox();
            this.pic_liftA = new System.Windows.Forms.PictureBox();
            this.pic_box1 = new System.Windows.Forms.PictureBox();
            this.pic_liftB = new System.Windows.Forms.PictureBox();
            this.pic_box2 = new System.Windows.Forms.PictureBox();
            this.gb_cylB.SuspendLayout();
            this.gb_cylC.SuspendLayout();
            this.gb_liftA.SuspendLayout();
            this.gb_liftB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_auto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stat_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cylB_mvF
            // 
            this.btn_cylB_mvF.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylB_mvF.Location = new System.Drawing.Point(54, 133);
            this.btn_cylB_mvF.Name = "btn_cylB_mvF";
            this.btn_cylB_mvF.Size = new System.Drawing.Size(79, 38);
            this.btn_cylB_mvF.TabIndex = 1;
            this.btn_cylB_mvF.Text = "전진";
            this.btn_cylB_mvF.UseVisualStyleBackColor = true;
            this.btn_cylB_mvF.Click += new System.EventHandler(this.btn_cylB_mvF_Click);
            // 
            // btn_cylB_mvB
            // 
            this.btn_cylB_mvB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylB_mvB.Location = new System.Drawing.Point(113, 31);
            this.btn_cylB_mvB.Name = "btn_cylB_mvB";
            this.btn_cylB_mvB.Size = new System.Drawing.Size(79, 38);
            this.btn_cylB_mvB.TabIndex = 2;
            this.btn_cylB_mvB.Text = "후진";
            this.btn_cylB_mvB.UseVisualStyleBackColor = true;
            this.btn_cylB_mvB.Click += new System.EventHandler(this.btn_cylB_mvB_Click);
            // 
            // btn_cylC_mvB
            // 
            this.btn_cylC_mvB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylC_mvB.Location = new System.Drawing.Point(113, 38);
            this.btn_cylC_mvB.Name = "btn_cylC_mvB";
            this.btn_cylC_mvB.Size = new System.Drawing.Size(79, 38);
            this.btn_cylC_mvB.TabIndex = 4;
            this.btn_cylC_mvB.Text = "후진";
            this.btn_cylC_mvB.UseVisualStyleBackColor = true;
            this.btn_cylC_mvB.Click += new System.EventHandler(this.btn_cylC_mvB_Click);
            // 
            // btn_cylC_mvF
            // 
            this.btn_cylC_mvF.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylC_mvF.Location = new System.Drawing.Point(11, 38);
            this.btn_cylC_mvF.Name = "btn_cylC_mvF";
            this.btn_cylC_mvF.Size = new System.Drawing.Size(79, 38);
            this.btn_cylC_mvF.TabIndex = 3;
            this.btn_cylC_mvF.Text = "전진";
            this.btn_cylC_mvF.UseVisualStyleBackColor = true;
            this.btn_cylC_mvF.Click += new System.EventHandler(this.btn_cylC_mvF_Click);
            // 
            // btn_liftA_down
            // 
            this.btn_liftA_down.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftA_down.Location = new System.Drawing.Point(122, 31);
            this.btn_liftA_down.Name = "btn_liftA_down";
            this.btn_liftA_down.Size = new System.Drawing.Size(79, 38);
            this.btn_liftA_down.TabIndex = 5;
            this.btn_liftA_down.Text = "하강";
            this.btn_liftA_down.UseVisualStyleBackColor = true;
            this.btn_liftA_down.Click += new System.EventHandler(this.btn_liftA_down_Click);
            // 
            // btn_liftA_up
            // 
            this.btn_liftA_up.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftA_up.Location = new System.Drawing.Point(336, 133);
            this.btn_liftA_up.Name = "btn_liftA_up";
            this.btn_liftA_up.Size = new System.Drawing.Size(79, 38);
            this.btn_liftA_up.TabIndex = 6;
            this.btn_liftA_up.Text = "상승";
            this.btn_liftA_up.UseVisualStyleBackColor = true;
            this.btn_liftA_up.Click += new System.EventHandler(this.btn_liftA_up_Click);
            // 
            // btn_liftB_up
            // 
            this.btn_liftB_up.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftB_up.Location = new System.Drawing.Point(18, 38);
            this.btn_liftB_up.Name = "btn_liftB_up";
            this.btn_liftB_up.Size = new System.Drawing.Size(79, 38);
            this.btn_liftB_up.TabIndex = 8;
            this.btn_liftB_up.Text = "상승";
            this.btn_liftB_up.UseVisualStyleBackColor = true;
            this.btn_liftB_up.Click += new System.EventHandler(this.btn_liftB_up_Click);
            // 
            // btn_liftB_down
            // 
            this.btn_liftB_down.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftB_down.Location = new System.Drawing.Point(122, 38);
            this.btn_liftB_down.Name = "btn_liftB_down";
            this.btn_liftB_down.Size = new System.Drawing.Size(79, 38);
            this.btn_liftB_down.TabIndex = 7;
            this.btn_liftB_down.Text = "하강";
            this.btn_liftB_down.UseVisualStyleBackColor = true;
            this.btn_liftB_down.Click += new System.EventHandler(this.btn_liftB_down_Click);
            // 
            // gb_cylB
            // 
            this.gb_cylB.Controls.Add(this.btn_cylB_mvB);
            this.gb_cylB.Location = new System.Drawing.Point(43, 102);
            this.gb_cylB.Name = "gb_cylB";
            this.gb_cylB.Size = new System.Drawing.Size(210, 100);
            this.gb_cylB.TabIndex = 9;
            this.gb_cylB.TabStop = false;
            this.gb_cylB.Text = "Cylinder B";
            // 
            // gb_cylC
            // 
            this.gb_cylC.Controls.Add(this.btn_cylC_mvF);
            this.gb_cylC.Controls.Add(this.btn_cylC_mvB);
            this.gb_cylC.Location = new System.Drawing.Point(43, 220);
            this.gb_cylC.Name = "gb_cylC";
            this.gb_cylC.Size = new System.Drawing.Size(210, 100);
            this.gb_cylC.TabIndex = 10;
            this.gb_cylC.TabStop = false;
            this.gb_cylC.Text = "Cylinder C";
            // 
            // gb_liftA
            // 
            this.gb_liftA.Controls.Add(this.btn_liftA_down);
            this.gb_liftA.Location = new System.Drawing.Point(318, 102);
            this.gb_liftA.Name = "gb_liftA";
            this.gb_liftA.Size = new System.Drawing.Size(217, 100);
            this.gb_liftA.TabIndex = 10;
            this.gb_liftA.TabStop = false;
            this.gb_liftA.Text = "Lift A";
            // 
            // gb_liftB
            // 
            this.gb_liftB.Controls.Add(this.btn_liftB_down);
            this.gb_liftB.Controls.Add(this.btn_liftB_up);
            this.gb_liftB.Location = new System.Drawing.Point(318, 220);
            this.gb_liftB.Name = "gb_liftB";
            this.gb_liftB.Size = new System.Drawing.Size(217, 100);
            this.gb_liftB.TabIndex = 10;
            this.gb_liftB.TabStop = false;
            this.gb_liftB.Text = "Lift B";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic_connect
            // 
            this.pic_connect.ImageLocation = "images/btn_off.png";
            this.pic_connect.Location = new System.Drawing.Point(153, 29);
            this.pic_connect.Name = "pic_connect";
            this.pic_connect.Size = new System.Drawing.Size(100, 50);
            this.pic_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_connect.TabIndex = 17;
            this.pic_connect.TabStop = false;
            this.pic_connect.Click += new System.EventHandler(this.pic_connect_Click);
            // 
            // pic_auto
            // 
            this.pic_auto.ImageLocation = "images/btn_off.png";
            this.pic_auto.Location = new System.Drawing.Point(435, 29);
            this.pic_auto.Name = "pic_auto";
            this.pic_auto.Size = new System.Drawing.Size(100, 50);
            this.pic_auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_auto.TabIndex = 18;
            this.pic_auto.TabStop = false;
            this.pic_auto.Click += new System.EventHandler(this.pic_auto_Click);
            // 
            // lbl_connect
            // 
            this.lbl_connect.AutoSize = true;
            this.lbl_connect.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_connect.Location = new System.Drawing.Point(106, 47);
            this.lbl_connect.Name = "lbl_connect";
            this.lbl_connect.Size = new System.Drawing.Size(41, 16);
            this.lbl_connect.TabIndex = 19;
            this.lbl_connect.Text = "연결";
            // 
            // lbl_auto
            // 
            this.lbl_auto.AutoSize = true;
            this.lbl_auto.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_auto.Location = new System.Drawing.Point(348, 47);
            this.lbl_auto.Name = "lbl_auto";
            this.lbl_auto.Size = new System.Drawing.Size(81, 16);
            this.lbl_auto.TabIndex = 20;
            this.lbl_auto.Text = "자동 제어";
            // 
            // pic_stat_back
            // 
            this.pic_stat_back.ImageLocation = "images/plc_back.png";
            this.pic_stat_back.Location = new System.Drawing.Point(109, 339);
            this.pic_stat_back.Name = "pic_stat_back";
            this.pic_stat_back.Size = new System.Drawing.Size(384, 214);
            this.pic_stat_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_stat_back.TabIndex = 21;
            this.pic_stat_back.TabStop = false;
            // 
            // pic_cylB
            // 
            this.pic_cylB.ImageLocation = "images/cyl_B.png";
            this.pic_cylB.Location = new System.Drawing.Point(81, 378);
            this.pic_cylB.Name = "pic_cylB";
            this.pic_cylB.Size = new System.Drawing.Size(35, 50);
            this.pic_cylB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cylB.TabIndex = 22;
            this.pic_cylB.TabStop = false;
            // 
            // pic_cylC
            // 
            this.pic_cylC.ImageLocation = "images/cyl_C.png";
            this.pic_cylC.Location = new System.Drawing.Point(487, 453);
            this.pic_cylC.Name = "pic_cylC";
            this.pic_cylC.Size = new System.Drawing.Size(35, 50);
            this.pic_cylC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cylC.TabIndex = 23;
            this.pic_cylC.TabStop = false;
            // 
            // pic_liftA
            // 
            this.pic_liftA.ImageLocation = "images/lift.png";
            this.pic_liftA.Location = new System.Drawing.Point(117, 422);
            this.pic_liftA.Name = "pic_liftA";
            this.pic_liftA.Size = new System.Drawing.Size(54, 22);
            this.pic_liftA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_liftA.TabIndex = 24;
            this.pic_liftA.TabStop = false;
            // 
            // pic_box1
            // 
            this.pic_box1.ImageLocation = "images/box.png";
            this.pic_box1.Location = new System.Drawing.Point(128, 395);
            this.pic_box1.Name = "pic_box1";
            this.pic_box1.Size = new System.Drawing.Size(35, 33);
            this.pic_box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box1.TabIndex = 26;
            this.pic_box1.TabStop = false;
            this.pic_box1.Visible = false;
            // 
            // pic_liftB
            // 
            this.pic_liftB.ImageLocation = "images/lift.png";
            this.pic_liftB.Location = new System.Drawing.Point(430, 422);
            this.pic_liftB.Name = "pic_liftB";
            this.pic_liftB.Size = new System.Drawing.Size(54, 22);
            this.pic_liftB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_liftB.TabIndex = 27;
            this.pic_liftB.TabStop = false;
            // 
            // pic_box2
            // 
            this.pic_box2.ImageLocation = "images/box.png";
            this.pic_box2.Location = new System.Drawing.Point(440, 395);
            this.pic_box2.Name = "pic_box2";
            this.pic_box2.Size = new System.Drawing.Size(35, 33);
            this.pic_box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box2.TabIndex = 28;
            this.pic_box2.TabStop = false;
            this.pic_box2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 577);
            this.Controls.Add(this.pic_cylC);
            this.Controls.Add(this.pic_box2);
            this.Controls.Add(this.pic_cylB);
            this.Controls.Add(this.pic_box1);
            this.Controls.Add(this.pic_liftB);
            this.Controls.Add(this.pic_liftA);
            this.Controls.Add(this.pic_stat_back);
            this.Controls.Add(this.lbl_auto);
            this.Controls.Add(this.lbl_connect);
            this.Controls.Add(this.pic_auto);
            this.Controls.Add(this.pic_connect);
            this.Controls.Add(this.btn_liftA_up);
            this.Controls.Add(this.btn_cylB_mvF);
            this.Controls.Add(this.gb_cylB);
            this.Controls.Add(this.gb_liftA);
            this.Controls.Add(this.gb_liftB);
            this.Controls.Add(this.gb_cylC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_cylB.ResumeLayout(false);
            this.gb_cylC.ResumeLayout(false);
            this.gb_liftA.ResumeLayout(false);
            this.gb_liftB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_auto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stat_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cylB_mvF;
        private System.Windows.Forms.Button btn_cylB_mvB;
        private System.Windows.Forms.Button btn_cylC_mvB;
        private System.Windows.Forms.Button btn_cylC_mvF;
        private System.Windows.Forms.Button btn_liftA_down;
        private System.Windows.Forms.Button btn_liftA_up;
        private System.Windows.Forms.Button btn_liftB_up;
        private System.Windows.Forms.Button btn_liftB_down;
        private System.Windows.Forms.GroupBox gb_cylB;
        private System.Windows.Forms.GroupBox gb_cylC;
        private System.Windows.Forms.GroupBox gb_liftA;
        private System.Windows.Forms.GroupBox gb_liftB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_connect;
        private System.Windows.Forms.PictureBox pic_auto;
        private System.Windows.Forms.Label lbl_connect;
        private System.Windows.Forms.Label lbl_auto;
        private System.Windows.Forms.PictureBox pic_stat_back;
        private System.Windows.Forms.PictureBox pic_cylB;
        private System.Windows.Forms.PictureBox pic_cylC;
        private System.Windows.Forms.PictureBox pic_liftA;
        private System.Windows.Forms.PictureBox pic_box1;
        private System.Windows.Forms.PictureBox pic_liftB;
        private System.Windows.Forms.PictureBox pic_box2;
    }
}

