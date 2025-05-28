namespace _0525_DrinkMachine
{
    partial class Form2
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
            this.btn_sel01 = new System.Windows.Forms.Button();
            this.pic_dp01 = new System.Windows.Forms.PictureBox();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.btn_moneyInput = new System.Windows.Forms.Button();
            this.tb_moneyInput = new System.Windows.Forms.TextBox();
            this.btn_moneyBack = new System.Windows.Forms.Button();
            this.pic_moneyBack = new System.Windows.Forms.PictureBox();
            this.lbl_dp01 = new System.Windows.Forms.Label();
            this.lbl_moneyLeft = new System.Windows.Forms.Label();
            this.lbl_machineMoney = new System.Windows.Forms.Label();
            this.lbl_dp02 = new System.Windows.Forms.Label();
            this.pic_dp02 = new System.Windows.Forms.PictureBox();
            this.btn_sel02 = new System.Windows.Forms.Button();
            this.lbl_dp03 = new System.Windows.Forms.Label();
            this.pic_dp03 = new System.Windows.Forms.PictureBox();
            this.btn_sel03 = new System.Windows.Forms.Button();
            this.lbl_dp04 = new System.Windows.Forms.Label();
            this.pic_dp04 = new System.Windows.Forms.PictureBox();
            this.btn_sel04 = new System.Windows.Forms.Button();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_moneyBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sel01
            // 
            this.btn_sel01.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sel01.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sel01.Location = new System.Drawing.Point(64, 316);
            this.btn_sel01.Name = "btn_sel01";
            this.btn_sel01.Size = new System.Drawing.Size(80, 46);
            this.btn_sel01.TabIndex = 0;
            this.btn_sel01.UseVisualStyleBackColor = false;
            this.btn_sel01.Click += new System.EventHandler(this.btn_sel01_Click);
            // 
            // pic_dp01
            // 
            this.pic_dp01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_dp01.ImageLocation = "images/drink_pepsi.png";
            this.pic_dp01.Location = new System.Drawing.Point(44, 109);
            this.pic_dp01.Name = "pic_dp01";
            this.pic_dp01.Size = new System.Drawing.Size(115, 131);
            this.pic_dp01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dp01.TabIndex = 1;
            this.pic_dp01.TabStop = false;
            // 
            // pic_box
            // 
            this.pic_box.BackColor = System.Drawing.Color.Silver;
            this.pic_box.Location = new System.Drawing.Point(252, 501);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(116, 144);
            this.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box.TabIndex = 2;
            this.pic_box.TabStop = false;
            this.pic_box.Click += new System.EventHandler(this.pic_box_Click);
            // 
            // btn_moneyInput
            // 
            this.btn_moneyInput.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_moneyInput.Location = new System.Drawing.Point(586, 421);
            this.btn_moneyInput.Name = "btn_moneyInput";
            this.btn_moneyInput.Size = new System.Drawing.Size(60, 31);
            this.btn_moneyInput.TabIndex = 3;
            this.btn_moneyInput.Text = "투입";
            this.btn_moneyInput.UseVisualStyleBackColor = true;
            this.btn_moneyInput.Click += new System.EventHandler(this.btn_moneyInput_Click);
            // 
            // tb_moneyInput
            // 
            this.tb_moneyInput.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_moneyInput.Location = new System.Drawing.Point(433, 422);
            this.tb_moneyInput.Name = "tb_moneyInput";
            this.tb_moneyInput.Size = new System.Drawing.Size(127, 30);
            this.tb_moneyInput.TabIndex = 4;
            this.tb_moneyInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_moneyInput_KeyDown);
            // 
            // btn_moneyBack
            // 
            this.btn_moneyBack.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_moneyBack.Location = new System.Drawing.Point(531, 483);
            this.btn_moneyBack.Name = "btn_moneyBack";
            this.btn_moneyBack.Size = new System.Drawing.Size(115, 38);
            this.btn_moneyBack.TabIndex = 5;
            this.btn_moneyBack.Text = "잔돈반환";
            this.btn_moneyBack.UseVisualStyleBackColor = true;
            this.btn_moneyBack.Click += new System.EventHandler(this.btn_moneyBack_Click);
            // 
            // pic_moneyBack
            // 
            this.pic_moneyBack.Location = new System.Drawing.Point(493, 540);
            this.pic_moneyBack.Name = "pic_moneyBack";
            this.pic_moneyBack.Size = new System.Drawing.Size(153, 47);
            this.pic_moneyBack.TabIndex = 6;
            this.pic_moneyBack.TabStop = false;
            // 
            // lbl_dp01
            // 
            this.lbl_dp01.AutoSize = true;
            this.lbl_dp01.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_dp01.Location = new System.Drawing.Point(72, 258);
            this.lbl_dp01.Name = "lbl_dp01";
            this.lbl_dp01.Size = new System.Drawing.Size(53, 20);
            this.lbl_dp01.TabIndex = 7;
            this.lbl_dp01.Text = "Text";
            this.lbl_dp01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_moneyLeft
            // 
            this.lbl_moneyLeft.AutoSize = true;
            this.lbl_moneyLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_moneyLeft.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_moneyLeft.Location = new System.Drawing.Point(454, 29);
            this.lbl_moneyLeft.Name = "lbl_moneyLeft";
            this.lbl_moneyLeft.Size = new System.Drawing.Size(100, 28);
            this.lbl_moneyLeft.TabIndex = 8;
            this.lbl_moneyLeft.Text = "잔액 : ";
            // 
            // lbl_machineMoney
            // 
            this.lbl_machineMoney.AutoSize = true;
            this.lbl_machineMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_machineMoney.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_machineMoney.Location = new System.Drawing.Point(46, 422);
            this.lbl_machineMoney.Name = "lbl_machineMoney";
            this.lbl_machineMoney.Size = new System.Drawing.Size(161, 23);
            this.lbl_machineMoney.TabIndex = 9;
            this.lbl_machineMoney.Text = "투입한 금액 : ";
            // 
            // lbl_dp02
            // 
            this.lbl_dp02.AutoSize = true;
            this.lbl_dp02.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_dp02.Location = new System.Drawing.Point(225, 258);
            this.lbl_dp02.Name = "lbl_dp02";
            this.lbl_dp02.Size = new System.Drawing.Size(53, 20);
            this.lbl_dp02.TabIndex = 12;
            this.lbl_dp02.Text = "Text";
            this.lbl_dp02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_dp02
            // 
            this.pic_dp02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_dp02.ImageLocation = "images/drink_sprite.png";
            this.pic_dp02.Location = new System.Drawing.Point(197, 109);
            this.pic_dp02.Name = "pic_dp02";
            this.pic_dp02.Size = new System.Drawing.Size(115, 131);
            this.pic_dp02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dp02.TabIndex = 11;
            this.pic_dp02.TabStop = false;
            // 
            // btn_sel02
            // 
            this.btn_sel02.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sel02.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sel02.Location = new System.Drawing.Point(217, 316);
            this.btn_sel02.Name = "btn_sel02";
            this.btn_sel02.Size = new System.Drawing.Size(80, 46);
            this.btn_sel02.TabIndex = 10;
            this.btn_sel02.UseVisualStyleBackColor = false;
            this.btn_sel02.Click += new System.EventHandler(this.btn_sel02_Click);
            // 
            // lbl_dp03
            // 
            this.lbl_dp03.AutoSize = true;
            this.lbl_dp03.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_dp03.Location = new System.Drawing.Point(382, 258);
            this.lbl_dp03.Name = "lbl_dp03";
            this.lbl_dp03.Size = new System.Drawing.Size(53, 20);
            this.lbl_dp03.TabIndex = 15;
            this.lbl_dp03.Text = "Text";
            this.lbl_dp03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_dp03
            // 
            this.pic_dp03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_dp03.ImageLocation = "images/drink_water.png";
            this.pic_dp03.Location = new System.Drawing.Point(354, 109);
            this.pic_dp03.Name = "pic_dp03";
            this.pic_dp03.Size = new System.Drawing.Size(115, 131);
            this.pic_dp03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dp03.TabIndex = 14;
            this.pic_dp03.TabStop = false;
            // 
            // btn_sel03
            // 
            this.btn_sel03.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sel03.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sel03.Location = new System.Drawing.Point(374, 316);
            this.btn_sel03.Name = "btn_sel03";
            this.btn_sel03.Size = new System.Drawing.Size(80, 46);
            this.btn_sel03.TabIndex = 13;
            this.btn_sel03.UseVisualStyleBackColor = false;
            this.btn_sel03.Click += new System.EventHandler(this.btn_sel03_Click);
            // 
            // lbl_dp04
            // 
            this.lbl_dp04.AutoSize = true;
            this.lbl_dp04.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_dp04.Location = new System.Drawing.Point(521, 258);
            this.lbl_dp04.Name = "lbl_dp04";
            this.lbl_dp04.Size = new System.Drawing.Size(53, 20);
            this.lbl_dp04.TabIndex = 18;
            this.lbl_dp04.Text = "Text";
            this.lbl_dp04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_dp04
            // 
            this.pic_dp04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_dp04.ImageLocation = "images/drink_pocari.png";
            this.pic_dp04.Location = new System.Drawing.Point(525, 109);
            this.pic_dp04.Name = "pic_dp04";
            this.pic_dp04.Size = new System.Drawing.Size(115, 131);
            this.pic_dp04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dp04.TabIndex = 17;
            this.pic_dp04.TabStop = false;
            // 
            // btn_sel04
            // 
            this.btn_sel04.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sel04.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sel04.Location = new System.Drawing.Point(545, 316);
            this.btn_sel04.Name = "btn_sel04";
            this.btn_sel04.Size = new System.Drawing.Size(80, 46);
            this.btn_sel04.TabIndex = 16;
            this.btn_sel04.UseVisualStyleBackColor = false;
            this.btn_sel04.Click += new System.EventHandler(this.btn_sel04_Click);
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_inventory.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_inventory.Location = new System.Drawing.Point(32, 673);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(129, 23);
            this.lbl_inventory.TabIndex = 20;
            this.lbl_inventory.Text = "인벤토리 : ";
            // 
            // pic_logo
            // 
            this.pic_logo.ImageLocation = "images/drinkMachine_logo.png";
            this.pic_logo.Location = new System.Drawing.Point(12, 7);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(163, 91);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 22;
            this.pic_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(36, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(190, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(346, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(518, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 142);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.Location = new System.Drawing.Point(140, 501);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(336, 144);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(690, 712);
            this.Controls.Add(this.pic_box);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tb_moneyInput);
            this.Controls.Add(this.lbl_moneyLeft);
            this.Controls.Add(this.lbl_machineMoney);
            this.Controls.Add(this.pic_dp04);
            this.Controls.Add(this.pic_dp03);
            this.Controls.Add(this.pic_dp02);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_dp01);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.lbl_inventory);
            this.Controls.Add(this.lbl_dp04);
            this.Controls.Add(this.btn_sel04);
            this.Controls.Add(this.lbl_dp03);
            this.Controls.Add(this.btn_sel03);
            this.Controls.Add(this.lbl_dp02);
            this.Controls.Add(this.btn_sel02);
            this.Controls.Add(this.lbl_dp01);
            this.Controls.Add(this.pic_moneyBack);
            this.Controls.Add(this.btn_moneyBack);
            this.Controls.Add(this.btn_moneyInput);
            this.Controls.Add(this.btn_sel01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_moneyBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dp04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sel01;
        private System.Windows.Forms.PictureBox pic_dp01;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Button btn_moneyInput;
        private System.Windows.Forms.TextBox tb_moneyInput;
        private System.Windows.Forms.Button btn_moneyBack;
        private System.Windows.Forms.PictureBox pic_moneyBack;
        private System.Windows.Forms.Label lbl_dp01;
        private System.Windows.Forms.Label lbl_moneyLeft;
        private System.Windows.Forms.Label lbl_machineMoney;
        private System.Windows.Forms.Label lbl_dp02;
        private System.Windows.Forms.PictureBox pic_dp02;
        private System.Windows.Forms.Button btn_sel02;
        private System.Windows.Forms.Label lbl_dp03;
        private System.Windows.Forms.PictureBox pic_dp03;
        private System.Windows.Forms.Button btn_sel03;
        private System.Windows.Forms.Label lbl_dp04;
        private System.Windows.Forms.PictureBox pic_dp04;
        private System.Windows.Forms.Button btn_sel04;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}