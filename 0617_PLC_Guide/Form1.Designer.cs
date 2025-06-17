namespace _0617_PLC_Guide
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
            this.btn_connect = new System.Windows.Forms.Button();
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
            this.lbl_cylB_stat = new System.Windows.Forms.Label();
            this.lbl_cylC_stat = new System.Windows.Forms.Label();
            this.lbl_liftA_stat = new System.Windows.Forms.Label();
            this.lbl_liftB_stat = new System.Windows.Forms.Label();
            this.lbl_liftA_sens = new System.Windows.Forms.Label();
            this.lbl_liftB_sens = new System.Windows.Forms.Label();
            this.btn_auto = new System.Windows.Forms.Button();
            this.gb_cylB.SuspendLayout();
            this.gb_cylC.SuspendLayout();
            this.gb_liftA.SuspendLayout();
            this.gb_liftB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(156, 25);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(79, 38);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
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
            // lbl_cylB_stat
            // 
            this.lbl_cylB_stat.AutoSize = true;
            this.lbl_cylB_stat.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_cylB_stat.Location = new System.Drawing.Point(57, 422);
            this.lbl_cylB_stat.Name = "lbl_cylB_stat";
            this.lbl_cylB_stat.Size = new System.Drawing.Size(56, 19);
            this.lbl_cylB_stat.TabIndex = 11;
            this.lbl_cylB_stat.Text = "Cyl B";
            // 
            // lbl_cylC_stat
            // 
            this.lbl_cylC_stat.AutoSize = true;
            this.lbl_cylC_stat.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_cylC_stat.Location = new System.Drawing.Point(56, 512);
            this.lbl_cylC_stat.Name = "lbl_cylC_stat";
            this.lbl_cylC_stat.Size = new System.Drawing.Size(57, 19);
            this.lbl_cylC_stat.TabIndex = 12;
            this.lbl_cylC_stat.Text = "Cyl C";
            // 
            // lbl_liftA_stat
            // 
            this.lbl_liftA_stat.AutoSize = true;
            this.lbl_liftA_stat.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_liftA_stat.Location = new System.Drawing.Point(198, 422);
            this.lbl_liftA_stat.Name = "lbl_liftA_stat";
            this.lbl_liftA_stat.Size = new System.Drawing.Size(55, 19);
            this.lbl_liftA_stat.TabIndex = 13;
            this.lbl_liftA_stat.Text = "Lift A";
            // 
            // lbl_liftB_stat
            // 
            this.lbl_liftB_stat.AutoSize = true;
            this.lbl_liftB_stat.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_liftB_stat.Location = new System.Drawing.Point(199, 512);
            this.lbl_liftB_stat.Name = "lbl_liftB_stat";
            this.lbl_liftB_stat.Size = new System.Drawing.Size(54, 19);
            this.lbl_liftB_stat.TabIndex = 14;
            this.lbl_liftB_stat.Text = "Lift B";
            // 
            // lbl_liftA_sens
            // 
            this.lbl_liftA_sens.AutoSize = true;
            this.lbl_liftA_sens.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_liftA_sens.Location = new System.Drawing.Point(356, 422);
            this.lbl_liftA_sens.Name = "lbl_liftA_sens";
            this.lbl_liftA_sens.Size = new System.Drawing.Size(107, 19);
            this.lbl_liftA_sens.TabIndex = 15;
            this.lbl_liftA_sens.Text = "Lift A Sens";
            // 
            // lbl_liftB_sens
            // 
            this.lbl_liftB_sens.AutoSize = true;
            this.lbl_liftB_sens.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_liftB_sens.Location = new System.Drawing.Point(356, 512);
            this.lbl_liftB_sens.Name = "lbl_liftB_sens";
            this.lbl_liftB_sens.Size = new System.Drawing.Size(106, 19);
            this.lbl_liftB_sens.TabIndex = 16;
            this.lbl_liftB_sens.Text = "Lift B Sens";
            // 
            // btn_auto
            // 
            this.btn_auto.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_auto.Location = new System.Drawing.Point(336, 25);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(79, 38);
            this.btn_auto.TabIndex = 17;
            this.btn_auto.Text = "자동";
            this.btn_auto.UseVisualStyleBackColor = true;
            this.btn_auto.Click += new System.EventHandler(this.btn_auto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 577);
            this.Controls.Add(this.btn_auto);
            this.Controls.Add(this.lbl_liftB_sens);
            this.Controls.Add(this.lbl_liftA_sens);
            this.Controls.Add(this.lbl_liftB_stat);
            this.Controls.Add(this.lbl_liftA_stat);
            this.Controls.Add(this.lbl_cylC_stat);
            this.Controls.Add(this.lbl_cylB_stat);
            this.Controls.Add(this.btn_liftA_up);
            this.Controls.Add(this.btn_cylB_mvF);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.gb_cylB);
            this.Controls.Add(this.gb_liftA);
            this.Controls.Add(this.gb_liftB);
            this.Controls.Add(this.gb_cylC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_cylB.ResumeLayout(false);
            this.gb_cylC.ResumeLayout(false);
            this.gb_liftA.ResumeLayout(false);
            this.gb_liftB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
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
        private System.Windows.Forms.Label lbl_cylB_stat;
        private System.Windows.Forms.Label lbl_cylC_stat;
        private System.Windows.Forms.Label lbl_liftA_stat;
        private System.Windows.Forms.Label lbl_liftB_stat;
        private System.Windows.Forms.Label lbl_liftA_sens;
        private System.Windows.Forms.Label lbl_liftB_sens;
        private System.Windows.Forms.Button btn_auto;
    }
}

