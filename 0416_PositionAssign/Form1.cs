using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0416_PositionAssign
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // From2 선언
        Form2 form;
        
        // 시작 버튼 클릭
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (form != null) return;
            form = new Form2();
            form.Show();
        }

        // 종료 버튼 클릭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 플레이어 좌표 이동   // form2의 함수 호출
        public void movePlayer(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnUp":
                    form.movePlayerUp();
                    break;
                case "btnDown":
                    form.movePlayerDown();
                    break;
                case "btnLeft":
                    form.movePlayerLeft();
                    break;
                case "btnRight":
                    form.movePlayerRight();
                    break;

            }
        }
    }
}
