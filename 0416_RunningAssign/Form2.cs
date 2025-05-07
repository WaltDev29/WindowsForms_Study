using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0416_PositionAssign
{
    public partial class Form2 : Form
    {
        Form parentForm;
        public Form2(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }

        // 3초 후 게임 시작
        int readyCount = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            readyCount--;
            if (readyCount == 0)
            {
                timer1.Stop();
                timer2.Enabled = true;
                lblReady.Visible = false;
            }
            lblReady.Text = readyCount.ToString();
        }

        // 키보드로 플레이
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.Up) movePlayerUp();
            if (e.KeyCode == Keys.Down) movePlayerDown();
            if (e.KeyCode == Keys.Left) movePlayerLeft();
            if (e.KeyCode == Keys.Right) movePlayerRight();

        }

        // 플레이 시간 기록
        int milSecond = 0;
        int second = 0;
        int minute = 0;
        private void timeCount()
        {
            milSecond++;
            //lblTime.Text = "Time : " + milSecond.ToString();
            if (milSecond >= 50)
            {
                milSecond = 0;
                second++;
            }
            if (second >= 60)
            {
                second = 0;
                minute++;
            }
            if (minute >= 100)
            {
                milSecond = 0;
                second = 0;
                minute = 0;
            }
            lblTime.Text = "Time : " + minute.ToString("D2") + " : " + second.ToString("D2");
        }

        // 타이머 메서드.     // 접촉 여부 체크, 점수 계산
        int isHit = 0;
        int score = 0;
        Random rand = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            timeCount();
            // 좌표 변수 선언, 초기화
            int pX = picPlayer.Location.X;
            int pY = picPlayer.Location.Y;
            int tX = picCoin.Location.X;
            int tY = picCoin.Location.Y;

            // Target이 화면 끝까지 이동한 경우
            if (tX < 0)
            {
                // 점수가 0이면 Game Over
                if (score <= 0)
                {
                    isHit = 1;
                    timer2.Stop();
                    gameOver();
                    return;
                }
                // Target 좌표 초기화
                isHit = 0;
                tX = 700;
                tY = rand.Next(1, 8) * 70;
                picCoin.Visible = true;
                picCoin.Location = new Point(tX, tY);
            }

            // Target 왼쪽으로 이동
            if (score >= 10) tX -= score;
            else tX -= 10;
            picCoin.Location = new Point(tX, picCoin.Location.Y);
            // 점수 증가 or 감소
            hitOrMiss(pX, pY, tX, tY);
        }

        // 게임 오버 메시지박스 출력
        private void gameOver()
        {
            DialogResult ret = MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.RetryCancel);
            if (ret == DialogResult.Retry)
            {
                isHit = 0;
                readyCount = 3;
                lblReady.Text = "3";
                lblReady.Visible = true;
                timer1.Enabled = true;
                picCoin.Location = new Point(631, 210);
                lblTime.Text = "Time : 00 : 00";
            }
            else
            {
                this.Close();
                parentForm.Close();
            } 
        }

        bool blink = false;
        int blinkTime = 0;
        // Target과 접촉 or Miss여부 판단
        private void hitOrMiss(int pX, int pY, int tX, int tY)
        {
            // Target과 Player가 접촉한 경우
            if ((tX <= pX + 50 && tX >= pX - 50) && (tY <= pY + 40 && tY >= pY - 40))
            {
                // 첫 접촉일 경우 (접촉 시 다중 작동하지 않도록)
                if (isHit == 0)
                {
                    picCoin.Visible = false;
                    isHit = 1;
                    score++;
                    blink = true;
                    lblScore.Text = "Score : " + score.ToString();
                    picBlink.Location = new Point(picCoin.Location.X, picCoin.Location.Y);
                    picBlink.Visible = true;

                }
            }
            if (blink == true)
            {
                blinkTime++;
                if (blinkTime >= 40)
                {
                    blink = false;
                    blinkTime = 0;
                    picBlink.Visible = false;
                }
            }
            // Target을 지나친경우, score가 0보다 높을 경우 (점수 마이너스 방지)
            if ((tX < pX - 50 && isHit == 0) && score > 0)
            {
                isHit = 1;
                score--;
                lblScore.Text = "Score : " + score.ToString();
            }
        }

        // 플레이어 좌표 이동
        public void movePlayerUp()
        {
            int y = picPlayer.Location.Y;
            if (y <= 60) return;
            y -= 70;
            picPlayer.Location = new Point(picPlayer.Location.X, y);
        }
        public void movePlayerDown()
        {
            int y = picPlayer.Location.Y;
            if (y >= 420) return;
            y += 70;
            picPlayer.Location = new Point(picPlayer.Location.X, y);
        }
        public void movePlayerLeft()
        {
            int x = picPlayer.Location.X;
            if (x <= 30) return;
            x -= 70;
            picPlayer.Location = new Point(x, picPlayer.Location.Y);
        }
        public void movePlayerRight()
        {
            int x = picPlayer.Location.X;
            if (x >= 510) return;
            x += 70;
            picPlayer.Location = new Point(x, picPlayer.Location.Y);
        }
    }
}
