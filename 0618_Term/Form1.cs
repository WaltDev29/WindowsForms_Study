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

namespace _0618_Term
{
    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }

        short sens;
        short value;

        bool cylB, cylC;
        String time;
        int cylB_stat, cylC_stat = 0;

        // 연결 버튼 클릭 함수
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (plc.Open() == 0)
            {
                MessageBox.Show("연결되었습니다.");
                timer1.Enabled = true;
            }
            else MessageBox.Show("연결에 실패하였습니다.");
        }

        // 실린더 제어 버튼 클릭 함수
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

        // 타이머 틱 함수
        private void timer1_Tick(object sender, EventArgs e)
        {
            plc.ReadDeviceBlock2("X0", 1, out sens);

            // 실린더 B
            if ((sens & 0x04) != 0) cylB = true;
            else if ((sens & 0x08) != 0) cylB = false;
            // 실린더 C
            if ((sens & 0x20) != 0) cylC = true;
            else if ((sens & 0x10) != 0) cylC = false;

            updateStat();
            updateChart();
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

        // 실린더 상태 이미지 업데이트 함수
        private void updateStat()
        {
            // 실린더 B
            if (cylB) pic_cylB.ImageLocation = "images/cylinder_on.png";
            if (!cylB) pic_cylB.ImageLocation = "images/cylinder_off.png";
            // 실린더 C
            if (cylC) pic_cylC.ImageLocation = "images/cylinder_on.png";
            if (!cylC) pic_cylC.ImageLocation = "images/cylinder_off.png";
        }

        // 그래프 상태 업데이트 함수
        private void updateChart()
        {
            // 실린더 B
            if (cylB) cylB_stat = 1;
            if (!cylB) cylB_stat = 0;
            // 실린더 C
            if (cylC) cylC_stat = 1;
            if (!cylC) cylC_stat = 0;

            time = DateTime.Now.ToString("yy년MM월dd일 HH.mm.ss");
            // 포인트 개수 조절
            if (chart_cylB.Series[0].Points.Count >= 10) chart_cylB.Series[0].Points.RemoveAt(0);
            if (chart_cylC.Series[0].Points.Count >= 10) chart_cylC.Series[0].Points.RemoveAt(0);
            // 그래프 작성
            chart_cylB.Series[0].Points.AddXY(time, cylB_stat);
            chart_cylC.Series[0].Points.AddXY(time, cylC_stat);
        }
    }
}
