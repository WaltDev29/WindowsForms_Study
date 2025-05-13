namespace _0512_TrafficLight
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
            this.picBox_light = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSec = new System.Windows.Forms.Label();
            this.picBox_player = new System.Windows.Forms.PictureBox();
            this.picBox_car = new System.Windows.Forms.PictureBox();
            this.picBox_title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_title)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_light
            // 
            this.picBox_light.Image = ((System.Drawing.Image)(resources.GetObject("picBox_light.Image")));
            this.picBox_light.Location = new System.Drawing.Point(111, 28);
            this.picBox_light.Name = "picBox_light";
            this.picBox_light.Size = new System.Drawing.Size(37, 84);
            this.picBox_light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_light.TabIndex = 0;
            this.picBox_light.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSec.Location = new System.Drawing.Point(121, 121);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(21, 20);
            this.lblSec.TabIndex = 2;
            this.lblSec.Text = "0";
            // 
            // picBox_player
            // 
            this.picBox_player.Image = ((System.Drawing.Image)(resources.GetObject("picBox_player.Image")));
            this.picBox_player.Location = new System.Drawing.Point(0, 198);
            this.picBox_player.Name = "picBox_player";
            this.picBox_player.Size = new System.Drawing.Size(77, 72);
            this.picBox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_player.TabIndex = 3;
            this.picBox_player.TabStop = false;
            // 
            // picBox_car
            // 
            this.picBox_car.Image = ((System.Drawing.Image)(resources.GetObject("picBox_car.Image")));
            this.picBox_car.Location = new System.Drawing.Point(192, 187);
            this.picBox_car.Name = "picBox_car";
            this.picBox_car.Size = new System.Drawing.Size(195, 72);
            this.picBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_car.TabIndex = 4;
            this.picBox_car.TabStop = false;
            this.picBox_car.Visible = false;
            // 
            // picBox_title
            // 
            this.picBox_title.Image = ((System.Drawing.Image)(resources.GetObject("picBox_title.Image")));
            this.picBox_title.Location = new System.Drawing.Point(148, 2);
            this.picBox_title.Name = "picBox_title";
            this.picBox_title.Size = new System.Drawing.Size(277, 129);
            this.picBox_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_title.TabIndex = 5;
            this.picBox_title.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_0512_TrafficLight.Properties.Resources.cross;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 317);
            this.Controls.Add(this.picBox_title);
            this.Controls.Add(this.picBox_car);
            this.Controls.Add(this.picBox_player);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.picBox_light);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_light;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.PictureBox picBox_player;
        private System.Windows.Forms.PictureBox picBox_car;
        private System.Windows.Forms.PictureBox picBox_title;
    }
}

