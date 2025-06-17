using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACTMULTILIB_K;

namespace _0617_PLC_Guide_Img
{
    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }

        short value, sens;

        bool cylB, cylC;
        bool liftA_stat, liftB_stat, liftA_sens, liftB_sens;
        bool auto = false;

        // 연결 버튼 클릭 함수
        private void pic_connect_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                disconnect();
                MessageBox.Show("연결을 해제하였습니다.");
                return;
            }
            else
            {
                plc = new ActEasyIF();
                if (plc.Open() == 0)
                {
                    MessageBox.Show("연결되었습니다.");
                    pic_connect.ImageLocation = "images/btn_on.png";
                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("연결 실패");
                }
            }
        }

        // 제어 버튼 클릭 함수
        private void btn_cylB_mvF_Click(object sender, EventArgs e)
        {
            mv_cyl('B', 'F');
        }

        private void btn_cylB_mvB_Click(object sender, EventArgs e)
        {
            mv_cyl('B', 'B');
        }

        private void btn_cylC_mvF_Click(object sender, EventArgs e)
        {
            mv_cyl('C', 'F');
        }

        private void btn_cylC_mvB_Click(object sender, EventArgs e)
        {
            mv_cyl('C', 'B');
        }

        private void btn_liftA_up_Click(object sender, EventArgs e)
        {
            mv_lift('A', 'U');
        }

        private void btn_liftA_down_Click(object sender, EventArgs e)
        {
            mv_lift('A', 'D');
        }

        private void btn_liftB_up_Click(object sender, EventArgs e)
        {
            mv_lift('B', 'U');
        }

        private void btn_liftB_down_Click(object sender, EventArgs e)
        {
            mv_lift('B', 'D');
        }

        // 실린더 제어 함수
        private void mv_cyl(char target, char direction)
        {
            if (!timer1.Enabled) return;
            ushort reset = 0;
            ushort mask = 0;
            plc.ReadDeviceBlock2("Y0", 1, out sens);
            if (target == 'B')
            {
                reset = 0b1111111111111001;
                if (direction == 'F') mask = 0b0000000000000010;
                else if (direction == 'B') mask = 0b0000000000000100;

            }
            else if (target == 'C')
            {
                reset = 0b1111111111100111;
                if (direction == 'F') mask = 0b0000000000001000;
                else if (direction == 'B') mask = 0b0000000000010000;
            }
            value = (short)((sens & reset) | mask);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 리프트 제어 함수
        private void mv_lift(char target, char direction)
        {
            if (!timer1.Enabled) return;
            ushort reset = 0;
            ushort mask = 0;

            plc.ReadDeviceBlock2("Y0", 1, out sens);
            if (target == 'A')
            {
                reset = 0b1111111110011111;
                if (direction == 'U') mask = 0b0000000000100000;
                else if (direction == 'D') mask = 0b0000000001000000;

            }
            else if (target == 'B')
            {
                reset = 0b1111111001111111;
                if (direction == 'U') mask = 0b0000000100000000;
                else if (direction == 'D') mask = 0b0000000010000000;
            }
            value = (short)((sens & reset) | mask);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }

        // 자동 제어 버튼 클릭 함수
        private void pic_auto_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled) return;
            if (auto)
            {
                MessageBox.Show("Auto Loop Off");
                auto = false;
                pic_auto.ImageLocation = "images/btn_off.png";
            }
            else
            {
                MessageBox.Show("Auto Loop On");
                auto = true;
                pic_auto.ImageLocation = "images/btn_on.png";
            }
        }

        // 타이머 함수
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (plc == null) return;
            plc.ReadDeviceBlock2("X0", 1, out sens);

            // 실린더 인식
            // 실린더 B
            if ((sens & 0x04) != 0) cylB = true;
            else if ((sens & 0x08) != 0) cylB = false;
            // 실린더 C
            if ((sens & 0x20) != 0) cylC = true;
            else if ((sens & 0x10) != 0) cylC = false;

            // 리프트 상태 인식
            // 리프트 A
            if ((sens & 0x40) != 0) liftA_stat = true;
            else if ((sens & 0x80) != 0) liftA_stat = false;
            // 리프트 B
            if ((sens & 0x100) != 0) liftB_stat = true;
            else if ((sens & 0x200) != 0) liftB_stat = false;

            // 리프트 센서 인식
            // 리프트 A
            if ((sens & 0x400) != 0) liftA_sens = true;
            else liftA_sens = false;
            // 리프트 B
            if ((sens & 0x800) != 0) liftB_sens = true;
            else liftB_sens = false;


            // 라벨 텍스트 변경
            updateStatus();

            // 루프 제어
            if (auto) autoLoop();
        }

        // 이미지 업데이트 함수
        private void updateStatus()
        {
            int x;
            int y;
            // 실린더 B
            if (cylB == true) pic_cylB.Location = new Point(141, 378);
            else pic_cylB.Location = new Point(81, 378);
            // 실린더 C
            if (cylC == true) pic_cylC.Location = new Point(427, 453);
            else pic_cylC.Location = new Point(487, 453);
            // 리프트 A 상태
            if (liftA_stat == true) pic_liftA.Location = new Point(117, 422);
            else pic_liftA.Location = new Point(117, 497);
            // 리프트 B 상태
            if (liftB_stat == true) pic_liftB.Location = new Point(430, 422);
            else pic_liftB.Location = new Point(430, 497);
            // 리프트 A 센서
            if (liftA_sens == true)
            {
                Console.Write("Lift A On");
                x = pic_liftA.Location.X;
                y = pic_liftA.Location.Y;
                pic_box1.Location = new Point(x + 10, y - 27);
                pic_box1.Visible = true;
            }
            else pic_box1.Visible = false;

            // 리프트 B 센서
            if (liftB_sens == true)
            {
                x = pic_liftB.Location.X;
                y = pic_liftB.Location.Y;
                pic_box2.Location = new Point(x + 10, y - 27);
                pic_box2.Visible = true;
            }
            else pic_box2.Visible = false;
        }

        // 루프 제어
        private void autoLoop()
        {
            if (liftA_sens == true && liftA_stat == true) mv_lift('B', 'U');
            if (liftA_sens == true && liftB_stat == true) mv_cyl('B', 'F'); //mvTwiceB = true;
            if ((liftB_sens == true && liftB_stat == true) && cylC == false)
            {
                mv_lift('A', 'D');
                mv_lift('B', 'D');
            }
            if (liftB_sens == true && liftB_stat == false) mv_cyl('C', 'F'); //mvTwiceC = true;
            if ((liftA_sens == true && liftA_stat == false) && (cylB == false && cylC == false))
            {
                mv_lift('A', 'U');
                mv_lift('B', 'U');
            }

            if (cylB == true) mv_cyl('B', 'B');
            if (cylC == true) mv_cyl('C', 'B');
        }

        // 연결 해제 함수
        private void disconnect()
        {
            plc.Close();
            plc = null;
            timer1.Enabled = false;
            auto = false;
            pic_connect.ImageLocation = "images/btn_off.png";
            pic_auto.ImageLocation = "images/btn_off.png";
        }
    }
}

// 자동 돌림
// 수동 돌림
// 차트 그리기
// 로그 남기기 (그리드 데이터 뷰)


// 0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0
// F E D C  B A 9 8  7 6 5 4  3 2 1 0

//[OUTPUTS]
//CylinderA = Y0
//CylinderB_F = Y1
//CylinderB_B = Y2
//CylinderC_F = Y3
//CylinderC_B = Y4
//LiftA_Up = Y5
//LiftA_Down = Y6
//LiftB_Up = Y7
//LiftB_Down = Y8

//[INPUTS]
//CylinderA_F = X0
//CylinderA_B = X1
//CylinderB_F = X2
//CylinderB_B = X3
//CylinderC_F = X4
//CylinderC_B = X5
//LiftA_Up = X6
//LiftA_Down = X7
//LiftB_Up = X8
//LiftB_Down = X9
//LiftA_ON = XA
//LiftB_ON = XB


// 25분 소요

// 09시 55분 부터 시작