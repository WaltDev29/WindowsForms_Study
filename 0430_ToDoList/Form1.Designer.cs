using System;

namespace _0430_ToDoList
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
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.lblIncompletedCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSun = new System.Windows.Forms.Button();
            this.btnFri = new System.Windows.Forms.Button();
            this.btnThu = new System.Windows.Forms.Button();
            this.btnWed = new System.Windows.Forms.Button();
            this.btnTue = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.tbInputName = new System.Windows.Forms.TextBox();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblSunCount = new System.Windows.Forms.Label();
            this.lblMonCount = new System.Windows.Forms.Label();
            this.lblTueCount = new System.Windows.Forms.Label();
            this.lblWedCount = new System.Windows.Forms.Label();
            this.lblThuCount = new System.Windows.Forms.Label();
            this.lblFriCount = new System.Windows.Forms.Label();
            this.lblSatCount = new System.Windows.Forms.Label();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.btnEditName = new System.Windows.Forms.Button();
            this.btnToggleComplete = new System.Windows.Forms.Button();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblCompletedAt = new System.Windows.Forms.Label();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMemo = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblItemList = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblCompletedCount.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompletedCount.ForeColor = System.Drawing.Color.White;
            this.lblCompletedCount.Location = new System.Drawing.Point(570, 0);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Padding = new System.Windows.Forms.Padding(10, 10, 15, 10);
            this.lblCompletedCount.Size = new System.Drawing.Size(112, 40);
            this.lblCompletedCount.TabIndex = 0;
            this.lblCompletedCount.Text = "완료 : 0";
            // 
            // lblIncompletedCount
            // 
            this.lblIncompletedCount.AutoSize = true;
            this.lblIncompletedCount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblIncompletedCount.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIncompletedCount.ForeColor = System.Drawing.Color.White;
            this.lblIncompletedCount.Location = new System.Drawing.Point(674, 0);
            this.lblIncompletedCount.Name = "lblIncompletedCount";
            this.lblIncompletedCount.Padding = new System.Windows.Forms.Padding(10, 10, 18, 10);
            this.lblIncompletedCount.Size = new System.Drawing.Size(136, 40);
            this.lblIncompletedCount.TabIndex = 1;
            this.lblIncompletedCount.Text = "미완료 : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(164, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "To-Do List";
            // 
            // btnSun
            // 
            this.btnSun.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSun.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.btnSun.ForeColor = System.Drawing.Color.White;
            this.btnSun.Location = new System.Drawing.Point(35, 98);
            this.btnSun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(59, 40);
            this.btnSun.TabIndex = 3;
            this.btnSun.Tag = System.DayOfWeek.Sunday;
            this.btnSun.Text = "Sun";
            this.btnSun.UseVisualStyleBackColor = false;
            this.btnSun.Click += new System.EventHandler(this.dayBtn_Clicked);
            // 
            // btnFri
            // 
            this.btnFri.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFri.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.btnFri.ForeColor = System.Drawing.Color.White;
            this.btnFri.Location = new System.Drawing.Point(585, 98);
            this.btnFri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFri.Name = "btnFri";
            this.btnFri.Size = new System.Drawing.Size(59, 40);
            this.btnFri.TabIndex = 4;
            this.btnFri.Tag = System.DayOfWeek.Friday;
            this.btnFri.Text = "Fri";
            this.btnFri.UseVisualStyleBackColor = false;
            this.btnFri.Click += new System.EventHandler(this.dayBtn_Clicked);
            // 
            // btnThu
            // 
            this.btnThu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThu.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.btnThu.ForeColor = System.Drawing.Color.White;
            this.btnThu.Location = new System.Drawing.Point(475, 98);
            this.btnThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThu.Name = "btnThu";
            this.btnThu.Size = new System.Drawing.Size(59, 40);
            this.btnThu.TabIndex = 5;
            this.btnThu.Tag = System.DayOfWeek.Thursday;
            this.btnThu.Text = "Thu";
            this.btnThu.UseVisualStyleBackColor = false;
            this.btnThu.Click += new System.EventHandler(this.dayBtn_Clicked);
            // 
            // btnWed
            // 
            this.btnWed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWed.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.btnWed.ForeColor = System.Drawing.Color.White;
            this.btnWed.Location = new System.Drawing.Point(365, 98);
            this.btnWed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWed.Name = "btnWed";
            this.btnWed.Size = new System.Drawing.Size(59, 40);
            this.btnWed.TabIndex = 6;
            this.btnWed.Tag = System.DayOfWeek.Wednesday;
            this.btnWed.Text = "Wed";
            this.btnWed.UseVisualStyleBackColor = false;
            this.btnWed.Click += new System.EventHandler(this.dayBtn_Clicked);
            // 
            // btnTue
            // 
            this.btnTue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTue.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.btnTue.ForeColor = System.Drawing.Color.White;
            this.btnTue.Location = new System.Drawing.Point(255, 98);
            this.btnTue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTue.Name = "btnTue";
            this.btnTue.Size = new System.Drawing.Size(59, 40);
            this.btnTue.TabIndex = 7;
            this.btnTue.Tag = System.DayOfWeek.Tuesday;
            this.btnTue.Text = "Tue";
            this.btnTue.UseVisualStyleBackColor = false;
            this.btnTue.Click += new System.EventHandler(this.dayBtn_Clicked);
            // 
            // btnMon
            // 
            this.btnMon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMon.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.btnMon.ForeColor = System.Drawing.Color.White;
            this.btnMon.Location = new System.Drawing.Point(145, 98);
            this.btnMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(59, 40);
            this.btnMon.TabIndex = 8;
            this.btnMon.Tag = System.DayOfWeek.Monday;
            this.btnMon.Text = "Mon";
            this.btnMon.UseVisualStyleBackColor = false;
            this.btnMon.Click += new System.EventHandler(this.dayBtn_Clicked);
            // 
            // btnSat
            // 
            this.btnSat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSat.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.btnSat.ForeColor = System.Drawing.Color.White;
            this.btnSat.Location = new System.Drawing.Point(695, 98);
            this.btnSat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(59, 40);
            this.btnSat.TabIndex = 9;
            this.btnSat.Tag = System.DayOfWeek.Saturday;
            this.btnSat.Text = "Sat";
            this.btnSat.UseVisualStyleBackColor = false;
            this.btnSat.Click += new System.EventHandler(this.dayBtn_Clicked);
            // 
            // tbInputName
            // 
            this.tbInputName.BackColor = System.Drawing.Color.Snow;
            this.tbInputName.Font = new System.Drawing.Font("굴림", 10F);
            this.tbInputName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbInputName.Location = new System.Drawing.Point(35, 210);
            this.tbInputName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInputName.Name = "tbInputName";
            this.tbInputName.Size = new System.Drawing.Size(222, 27);
            this.tbInputName.TabIndex = 17;
            this.tbInputName.Visible = false;
            this.tbInputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCreateItem_Click);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreateItem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreateItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCreateItem.Location = new System.Drawing.Point(276, 210);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Padding = new System.Windows.Forms.Padding(1);
            this.btnCreateItem.Size = new System.Drawing.Size(62, 27);
            this.btnCreateItem.TabIndex = 18;
            this.btnCreateItem.Tag = "";
            this.btnCreateItem.Text = "등록";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Visible = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowList.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShowList.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnShowList.Location = new System.Drawing.Point(659, 210);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(129, 27);
            this.btnShowList.TabIndex = 19;
            this.btnShowList.Text = "완료한 목록";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Azure;
            this.listBox.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(35, 272);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(303, 310);
            this.listBox.TabIndex = 23;
            this.listBox.Visible = false;
            this.listBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedValueChanged);
            // 
            // lblSunCount
            // 
            this.lblSunCount.AutoSize = true;
            this.lblSunCount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lblSunCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSunCount.Location = new System.Drawing.Point(50, 152);
            this.lblSunCount.Name = "lblSunCount";
            this.lblSunCount.Size = new System.Drawing.Size(33, 22);
            this.lblSunCount.TabIndex = 10;
            this.lblSunCount.Tag = System.DayOfWeek.Sunday;
            this.lblSunCount.Text = "😎";
            this.lblSunCount.Visible = false;
            // 
            // lblMonCount
            // 
            this.lblMonCount.AutoSize = true;
            this.lblMonCount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lblMonCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMonCount.Location = new System.Drawing.Point(160, 152);
            this.lblMonCount.Name = "lblMonCount";
            this.lblMonCount.Size = new System.Drawing.Size(33, 22);
            this.lblMonCount.TabIndex = 11;
            this.lblMonCount.Tag = System.DayOfWeek.Monday;
            this.lblMonCount.Text = "😎";
            this.lblMonCount.Visible = false;
            // 
            // lblTueCount
            // 
            this.lblTueCount.AutoSize = true;
            this.lblTueCount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lblTueCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTueCount.Location = new System.Drawing.Point(270, 152);
            this.lblTueCount.Name = "lblTueCount";
            this.lblTueCount.Size = new System.Drawing.Size(33, 22);
            this.lblTueCount.TabIndex = 12;
            this.lblTueCount.Tag = System.DayOfWeek.Tuesday;
            this.lblTueCount.Text = "😎";
            this.lblTueCount.Visible = false;
            // 
            // lblWedCount
            // 
            this.lblWedCount.AutoSize = true;
            this.lblWedCount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lblWedCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWedCount.Location = new System.Drawing.Point(380, 152);
            this.lblWedCount.Name = "lblWedCount";
            this.lblWedCount.Size = new System.Drawing.Size(33, 22);
            this.lblWedCount.TabIndex = 13;
            this.lblWedCount.Tag = System.DayOfWeek.Wednesday;
            this.lblWedCount.Text = "😎";
            this.lblWedCount.Visible = false;
            // 
            // lblThuCount
            // 
            this.lblThuCount.AutoSize = true;
            this.lblThuCount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lblThuCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblThuCount.Location = new System.Drawing.Point(490, 152);
            this.lblThuCount.Name = "lblThuCount";
            this.lblThuCount.Size = new System.Drawing.Size(33, 22);
            this.lblThuCount.TabIndex = 14;
            this.lblThuCount.Tag = System.DayOfWeek.Thursday;
            this.lblThuCount.Text = "😎";
            this.lblThuCount.Visible = false;
            // 
            // lblFriCount
            // 
            this.lblFriCount.AutoSize = true;
            this.lblFriCount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lblFriCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFriCount.Location = new System.Drawing.Point(600, 152);
            this.lblFriCount.Name = "lblFriCount";
            this.lblFriCount.Size = new System.Drawing.Size(33, 22);
            this.lblFriCount.TabIndex = 15;
            this.lblFriCount.Tag = System.DayOfWeek.Friday;
            this.lblFriCount.Text = "😎";
            this.lblFriCount.Visible = false;
            // 
            // lblSatCount
            // 
            this.lblSatCount.AutoSize = true;
            this.lblSatCount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lblSatCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSatCount.Location = new System.Drawing.Point(710, 152);
            this.lblSatCount.Name = "lblSatCount";
            this.lblSatCount.Size = new System.Drawing.Size(33, 22);
            this.lblSatCount.TabIndex = 16;
            this.lblSatCount.Tag = System.DayOfWeek.Saturday;
            this.lblSatCount.Text = "😎";
            this.lblSatCount.Visible = false;
            // 
            // tbEditName
            // 
            this.tbEditName.BackColor = System.Drawing.Color.Snow;
            this.tbEditName.Font = new System.Drawing.Font("굴림", 10F);
            this.tbEditName.Location = new System.Drawing.Point(6, 8);
            this.tbEditName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(187, 27);
            this.tbEditName.TabIndex = 0;
            // 
            // btnEditName
            // 
            this.btnEditName.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEditName.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEditName.Location = new System.Drawing.Point(208, 8);
            this.btnEditName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(54, 28);
            this.btnEditName.TabIndex = 23;
            this.btnEditName.Text = "수정";
            this.btnEditName.UseVisualStyleBackColor = false;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // btnToggleComplete
            // 
            this.btnToggleComplete.BackColor = System.Drawing.Color.Azure;
            this.btnToggleComplete.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnToggleComplete.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnToggleComplete.Location = new System.Drawing.Point(368, 8);
            this.btnToggleComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToggleComplete.Name = "btnToggleComplete";
            this.btnToggleComplete.Size = new System.Drawing.Size(29, 28);
            this.btnToggleComplete.TabIndex = 24;
            this.btnToggleComplete.Text = "✔";
            this.btnToggleComplete.UseVisualStyleBackColor = false;
            this.btnToggleComplete.Click += new System.EventHandler(this.btnToggleComplete_Click);
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("굴림", 8F);
            this.lblCreatedAt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCreatedAt.Location = new System.Drawing.Point(3, 51);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(78, 14);
            this.lblCreatedAt.TabIndex = 25;
            this.lblCreatedAt.Text = "생성날짜 : ";
            // 
            // lblCompletedAt
            // 
            this.lblCompletedAt.AutoSize = true;
            this.lblCompletedAt.Font = new System.Drawing.Font("굴림", 8F);
            this.lblCompletedAt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCompletedAt.Location = new System.Drawing.Point(3, 77);
            this.lblCompletedAt.Name = "lblCompletedAt";
            this.lblCompletedAt.Size = new System.Drawing.Size(78, 14);
            this.lblCompletedAt.TabIndex = 26;
            this.lblCompletedAt.Text = "완료날짜 : ";
            // 
            // tbMemo
            // 
            this.tbMemo.BackColor = System.Drawing.Color.Snow;
            this.tbMemo.Font = new System.Drawing.Font("굴림", 10F);
            this.tbMemo.Location = new System.Drawing.Point(6, 143);
            this.tbMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(391, 154);
            this.tbMemo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Memo";
            // 
            // btnMemo
            // 
            this.btnMemo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMemo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMemo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnMemo.Location = new System.Drawing.Point(284, 107);
            this.btnMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMemo.Name = "btnMemo";
            this.btnMemo.Size = new System.Drawing.Size(113, 28);
            this.btnMemo.TabIndex = 29;
            this.btnMemo.Text = "Memo 저장";
            this.btnMemo.UseVisualStyleBackColor = false;
            this.btnMemo.Click += new System.EventHandler(this.btnMemo_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRemove.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemove.ForeColor = System.Drawing.Color.Tomato;
            this.btnRemove.Location = new System.Drawing.Point(327, 51);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 28);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlInfo.Controls.Add(this.tbMemo);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.btnMemo);
            this.pnlInfo.Controls.Add(this.btnRemove);
            this.pnlInfo.Controls.Add(this.lblCompletedAt);
            this.pnlInfo.Controls.Add(this.lblCreatedAt);
            this.pnlInfo.Controls.Add(this.btnToggleComplete);
            this.pnlInfo.Controls.Add(this.btnEditName);
            this.pnlInfo.Controls.Add(this.tbEditName);
            this.pnlInfo.Location = new System.Drawing.Point(384, 272);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(404, 304);
            this.pnlInfo.TabIndex = 31;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblInfo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblInfo.Location = new System.Drawing.Point(384, 254);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(43, 20);
            this.lblInfo.TabIndex = 32;
            this.lblInfo.Text = "Info";
            this.lblInfo.Visible = false;
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.BackColor = System.Drawing.Color.LightBlue;
            this.lblItemList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemList.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblItemList.Location = new System.Drawing.Point(35, 254);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(43, 20);
            this.lblItemList.TabIndex = 33;
            this.lblItemList.Text = "List";
            this.lblItemList.Visible = false;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(_0430_ToDoList.Item);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.lblItemList);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblSatCount);
            this.Controls.Add(this.lblFriCount);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lblThuCount);
            this.Controls.Add(this.lblWedCount);
            this.Controls.Add(this.lblTueCount);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.lblMonCount);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.lblSunCount);
            this.Controls.Add(this.tbInputName);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.btnMon);
            this.Controls.Add(this.btnTue);
            this.Controls.Add(this.btnWed);
            this.Controls.Add(this.btnThu);
            this.Controls.Add(this.btnFri);
            this.Controls.Add(this.btnSun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIncompletedCount);
            this.Controls.Add(this.lblCompletedCount);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_Click);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Label lblIncompletedCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.Button btnFri;
        private System.Windows.Forms.Button btnThu;
        private System.Windows.Forms.Button btnWed;
        private System.Windows.Forms.Button btnTue;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.TextBox tbInputName;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Label lblSunCount;
        private System.Windows.Forms.Label lblMonCount;
        private System.Windows.Forms.Label lblTueCount;
        private System.Windows.Forms.Label lblWedCount;
        private System.Windows.Forms.Label lblThuCount;
        private System.Windows.Forms.Label lblFriCount;
        private System.Windows.Forms.Label lblSatCount;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.Button btnToggleComplete;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblCompletedAt;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMemo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblItemList;
    }
}

