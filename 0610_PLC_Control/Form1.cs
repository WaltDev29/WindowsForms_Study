using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACTMULTILIB_K;

namespace _0610_PLC_Control
{
    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }

        short value = 0;
        short sens = 0;
        bool cylB_stat = false;
        bool cylC_stat = false;
        bool liftA_stat = false;
        bool liftB_stat = false;
        bool liftA_sens = false;
        bool liftB_sens = false;

        // 연결
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (plc.Open() == 0)
            {
                MessageBox.Show("연결되었습니다.");
                btn_connect.Enabled = false;
                timer1.Enabled = true;
            }
            else MessageBox.Show("연결에 실패하였습니다.");
        }

        // 실린더 제어
        private void btn_cylB_mvF_Click(object sender, EventArgs e)
        {
            cyl_mv('B', 'F');
        }

        private void btn_cylB_mvB_Click(object sender, EventArgs e)
        {
            cyl_mv('B', 'B');
        }

        private void btn_cylC_mvF_Click(object sender, EventArgs e)
        {
            cyl_mv('C', 'F');
        }

        private void btn_cylC_mvB_Click(object sender, EventArgs e)
        {
            cyl_mv('C', 'B');
        }

        // 리프트 제어
        private void btn_liftA_up_Click(object sender, EventArgs e)
        {
            lift_mv('A', 'U');
        }

        private void btn_liftA_down_Click(object sender, EventArgs e)
        {
            lift_mv('A', 'D');
        }

        private void btn_liftB_up_Click(object sender, EventArgs e)
        {
            lift_mv('B', 'U');
        }

        private void btn_liftB_down_Click(object sender, EventArgs e)
        {
            lift_mv('B', 'D');
        }

        // 실린더 제어 함수
        private void cyl_mv(char target, char direction)
        {
            ushort reset = 0;
            short mask = 0;
            plc.ReadDeviceBlock2("Y0", 1, out sens); 
            switch (target)
            {
                case 'B':
                    reset = (ushort)(0b1111111111111001);
                    if (direction == 'F') mask = 0b0000000000000010;
                    else mask = 0b0000000000000100;
                        break;
                case 'C':
                    reset = 0b1111111111100111;
                    if (direction == 'F') mask = 0b0000000000001000;
                    else mask = 0b0000000000010000;
                    break;
                default:
                    break;
            }
            value = (short)(sens & reset);
            value = (short)(value | mask);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 리프트 제어 함수
        private void lift_mv(char target, char direction)
        {
            int reset = 0;
            short mask = 0;
            switch (target) {
                case 'A':
                    reset = 0b1111111110011111;
                    if (direction == 'U') mask = 0b0000000000100000;
                    else mask = 0b0000000001000000;
                    break;
                case 'B':
                    reset = 0b1111111001111111;
                    if (direction == 'U') mask = 0b0000000100000000;
                    else mask = 0b0000000010000000;
                    break;
                default: break;
            }
            plc.ReadDeviceBlock2("Y0", 1, out sens);
            value = (short)(sens & reset);
            value = (short)(value | mask);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }

        // 타이머 함수
        private void timer1_Tick(object sender, EventArgs e)
        {
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // bool 값 전환
            if ((sens & 0x04) != 0) cylB_stat = true;
            else if ((sens & 0x08) != 0) cylB_stat = false;

            if ((sens & 0x10) != 0) cylC_stat = false;
            else if ((sens & 0x20) != 0) cylC_stat = true;

            if ((sens & 0x40) != 0) liftA_stat = true;
            else if ((sens & 0x80) != 0) liftA_stat = false;

            if ((sens & 0x100) != 0) liftB_stat = true;
            else if ((sens & 0x200) != 0) liftB_stat = false;

            if ((sens & 0x400) != 0) liftA_sens = true;
            else liftA_sens = false;

            if ((sens & 0x800) != 0) liftB_sens = true;
            else liftB_sens = false;

            // 라벨 텍스트 변경
            if (cylB_stat == true) lbl_cylB.Text = "CylB : 전진";
            else lbl_cylB.Text = "CylB : 후진";
            if (cylC_stat == true) lbl_cylC.Text = "CylC : 전진";
            else lbl_cylC.Text = "CylB : 후진";

            if (liftA_stat == true) lbl_liftA.Text = "LiftA : 상승";
            else lbl_liftA.Text = "LiftA : 하강";
            if (liftB_stat == true) lbl_liftB.Text = "LiftB : 상승";
            else lbl_liftB.Text = "LiftB : 하강";

            if (liftA_sens == true) lbl_liftA_sens.Text = "LiftA sens : ON";
            else lbl_liftA_sens.Text = "LiftA sens : OFF";
            if (liftB_sens == true) lbl_liftB_sens.Text = "LiftB sens : ON";
            else lbl_liftB_sens.Text = "LiftB sens : OFF";

            // 자동 루프 제어
            if (liftA_sens == true && liftA_stat == true) lift_mv('B', 'U');
            if (liftA_sens == true && liftB_stat == true) cyl_mv('B', 'F');
            if ((liftB_sens == true && liftB_stat == true) && cylC_stat == false)
            {
                lift_mv('A', 'D');
                lift_mv('B', 'D');
            }
            if (liftB_sens == true && liftB_stat == false) cyl_mv('C', 'F');
            if ((liftA_sens == true && liftA_stat == false) && cylB_stat == false)
            {
                lift_mv('A', 'U');
                lift_mv('B', 'U');
            }

            if (cylB_stat == true) cyl_mv('B', 'B');
            if (cylC_stat == true) cyl_mv('C', 'B');
        }
    }
}

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