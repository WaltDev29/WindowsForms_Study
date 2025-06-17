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
using System.Windows.Forms.DataVisualization.Charting;
using ACTMULTILIB_K;

namespace _0617_PLC_Graph
{
    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }

        short value;
        short sens;
        bool cylB, cylC, liftA, liftB, liftA_sens, liftB_sens;

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (plc.Open() == 0)
            {
                MessageBox.Show("연결되었습니다.");
                timer1.Enabled = true;
            }
            else MessageBox.Show("연결되었습니다.");
        }

        // 실린더 제어 함수
        private void mv_cyl(char target, char direction)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            plc.ReadDeviceBlock2("X0", 1, out sens);

            // cyl B
            if ((sens & 0x04) != 0) cylB = true;
            else if ((sens & 0x08) != 0) cylB = false;
            // cyl C
            if ((sens & 0x20) != 0) cylC = true;
            else if ((sens & 0x10) != 0) cylC = false;
            // lift A
            if ((sens & 0x40) != 0) liftA = true;
            else if ((sens & 0x80) != 0) liftA = false;
            // lift B
            if ((sens & 0x100) != 0) liftB = true;
            else if ((sens & 0x200) != 0) liftB = false;
            // lift A sens
            if ((sens & 0x400) != 0) liftA_sens = true;
            else liftA_sens = false;
            // lift B sens
            if ((sens & 0x800) != 0) liftB_sens = true;
            else liftB_sens = false;

            autoLoop();
        }

        private void autoLoop()
        {
            if (liftA_sens && liftA) mv_lift('B', 'U');
            if (liftA_sens && liftB) mv_cyl('B', 'F');
            if (liftB_sens && liftB)
            {
                mv_lift('A', 'D');
                mv_lift('B', 'D');
            }
            if (liftB_sens && !liftB) mv_cyl('C', 'F');
            if (liftA_sens && !liftA)
            {
                mv_lift('A', 'U');
                mv_lift('B', 'U');
            }

            if (cylB) mv_cyl('B', 'B');
            if (cylC) mv_cyl('C', 'B');
        }
    }
}
