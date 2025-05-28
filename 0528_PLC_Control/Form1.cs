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
using PLC_Test_0528;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _0528_PLC_Control
{
    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }

        short value;    // Y에 입력할 값
        short sens = 0; // X로부터 받아올 값
        int count = 0;  // 작업 횟수
        bool task = false;  // 작업 수행 여부

        // 연결 버튼 클릭
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

        // 타이머 (센서, 그래프, 데이터 그리드)
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;
            if (chart1.Series[0].Points.Count > 20) chart1.Series[0].Points.RemoveAt(0);
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // 전진 센서
            if ((sens & 0x04) != 0)
            {
                // 라벨
                lbl_cylStatus.Text = "실린더 상태 : 전진";   
                // 차트
                chart1.Series[0].Points.AddXY(curTime.ToString(), 1);
                pic_cyl.ImageLocation = "Images/cylinderon.png";
                // 실린더 제어
                value = 0x01 << 2;  
                plc.WriteDeviceBlock2("Y0", 1, ref value);
                // 작업을 수행한 경우
                if (task)
                {
                    // 데이터 기록
                    count++;
                    lbl_count.Text = "총 작업 횟수 : " + count.ToString();
                    workBindingSource.Add(new Work { count = count, time = curTime.ToString() });
                    task = false;
                }
            }
            // 후진 센서
            else if ((sens & 0x08) != 0)
            {
                lbl_cylStatus.Text = "실린더 상태 : 후진";
                chart1.Series[0].Points.AddXY(curTime.ToString(), 0);
                pic_cyl.ImageLocation = "Images/cylinderoff.png";
            }
            // 리프트 on 센서
            if ((sens & 0x400) != 0)
            {
                task = true;
                lbl_liftStatus.Text = "리프트 상태 : On";
                pic_lift.ImageLocation = "Images/cube.png";
                value = 0x01 << 1;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            else
            {
                lbl_liftStatus.Text = "리프트 상태 : Off";
                pic_lift.ImageLocation = "Images/cube_back.png";
            }
        }

        // 작동 제어 버튼
        // 전진
        private void btn_mvF_Click(object sender, EventArgs e)
        {
            value = 0x01 << 1;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 후진
        private void btn_mvB_Click(object sender, EventArgs e)
        {
            value = 0x01 << 2;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
    }
}
