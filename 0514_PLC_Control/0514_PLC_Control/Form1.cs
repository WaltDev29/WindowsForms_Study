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

namespace _0514_PLC_Control
{
    public partial class Form1 : Form
    {
        ActEasyIF control;
        bool autoMode = false;   // 자동모드 활성화 여부
        short sens; // 센서 값
        bool alert; // 오류 메시지 표시 여부
        public Form1()
        {
            InitializeComponent();
            control = new ActEasyIF();
        }

        // PLC 제어       
        // 모드 선택
        private void picBox_mode_Click(object sender, EventArgs e)
        {
            if (!autoMode)
            {
                autoMode = true;
                timer2.Enabled = true;
                picBox_mode.ImageLocation = "Images/btn_on.png";
            }
            else
            {
                autoMode = false;
                timer2.Enabled = false;
                picBox_mode.ImageLocation = "Images/btn_off.png";
            }
        }

        // 연결
        private void picBox_OnOff_Click(object sender, EventArgs e)
        {
            // 연결 해제
            if (timer1.Enabled)
            {
                disconnect();
                MessageBox.Show("연결을 해제하였습니다.");
                return;
            }
            else
            {
                if (control == null) control = new ActEasyIF();
                control.ActLogicalStationNumber = 0;
                if (control.Open() == 0)
                {
                    timer1.Enabled = true;
                    alert = false;
                    MessageBox.Show("연결되었습니다.");
                    picBox_OnOff.ImageLocation = "Images/btn_on.png";
                }
                else MessageBox.Show("연결에 실패하였습니다.");
            }
        }
        // 전진
        private void btn_MvForward_Click(object sender, EventArgs e)
        {
            if (control == null || autoMode) return;
            short value = 0x01 << 1;
            control.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 후진
        private void btn_MvBackward_Click(object sender, EventArgs e)
        {
            if (control == null || autoMode) return;
            short value = 0x01 << 2;
            control.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 자동 제어
        private void timer2_Tick(object sender, EventArgs e)
        {
            // 자동 제어
            if (autoMode)
            {
                short value;
                if ((sens & 0x04) != 0)
                {
                    value = 0x01 << 2;
                    control.WriteDeviceBlock2("Y0", 1, ref value);
                }
                else if ((sens & 0x08) != 0)
                {
                    value = 0x01 << 1;
                    control.WriteDeviceBlock2("Y0", 1, ref value);
                }
                else return;
            }
        }

        // 센서, 그래프 (타이머)
        private void timer1_Tick(object sender, EventArgs e)
        {
            sens = 0;
            String curTime = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            control.ReadDeviceBlock2("X0", 1, out sens);            
            // 그래프 기록, 텍스트 출력
            if (chart1.Series[0].Points.Count >= 30) chart1.Series[0].Points.RemoveAt(0);
            if ((sens & 0x04) != 0)
            {
                chart1.Series[0].Points.AddXY(curTime, 1);
                lblSens.Text = "전진";
                picBox_cylinder.ImageLocation = "Images/cylinderon.png";
            }
            else if ((sens & 0x08) != 0)
            {
                chart1.Series[0].Points.AddXY(curTime, 0);
                lblSens.Text = "후진";
                picBox_cylinder.ImageLocation = "Images/cylinderoff.png";
            }
            else
            {
                chart1.Series[0].Points.AddXY(curTime, 0.5);
                // 비정상 작동 감지
                int pointCount = chart1.Series[0].Points.Count - 1;
                if (!alert 
                    && pointCount > 10 
                    && chart1.Series[0].Points[pointCount - 2].YValues[0] == 0.5
                    && chart1.Series[0].Points[pointCount - 3].YValues[0] == 0.5
                    && chart1.Series[0].Points[pointCount - 4].YValues[0] == 0.5
                    && chart1.Series[0].Points[pointCount - 5].YValues[0] == 0.5)
                {
                    alert = true;
                    disconnect();
                    MessageBox.Show("비정상적인 작동을 감지했습니다. 실린더 상태를 확인해주세요.");
                    return;
                }
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        // 연결 해제 메서드
        private void disconnect()
        {
            control.Close();
            control = null;
            timer1.Enabled = false;
            timer2.Enabled = false;
            autoMode = false;
            picBox_OnOff.ImageLocation = "Images/btn_off.png";
            picBox_mode.ImageLocation = "Images/btn_off.png";            
        }
    }
}

