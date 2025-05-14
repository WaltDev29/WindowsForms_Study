using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _0512_TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picBox_light.BackColor = Color.Transparent;
            picBox_player.BackColor = Color.Transparent;
            picBox_car.BackColor = Color.Transparent;
            picBox_title.BackColor = Color.Transparent;
            SoundPlayer player = new SoundPlayer("bgm.mp3");
            player.PlayLooping();
        }
        int sec = 0;
        int state = 0;  // 0 : 빨강, 1: 주황, 2 : 초록
        int dead = 0;   // 플레이어 사망 여부   0 : 생존  1 : 사망

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            lblSec.Text = sec.ToString();
            switch (sec % 12)
            {
                case 0:
                case 1:
                case 2:
                    picBox_light.ImageLocation = "./red.png";
                    if (picBox_player.Location.X >= 100 && picBox_player.Location.X <= 450)
                    {
                        if (dead == 0) playerDead();
                    }
                    state = 0;
                    break;
                case 3:
                case 4:
                case 5:
                    picBox_light.ImageLocation = "./yellow.png";
                    state = 1;
                    break;
                case 6:
                case 7:
                case 8:
                    picBox_light.ImageLocation = "./green.png";
                    state = 2;
                    break;
                case 9:
                case 10:
                case 11:
                    picBox_light.ImageLocation = "./yellow.png";
                    break;
            }
        }

        // 플레이어 이동 메서드
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = picBox_player.Location.X;
            int y = picBox_player.Location.Y;
            if (dead == 1) return;
            if (e.KeyCode == Keys.Left)
            {
                picBox_player.ImageLocation = "./guy_right.png";
                if (x <= 0) return;
                if (state == 0 && (x - 20 >= 100 && x - 20 <= 450)) return;
                x -= 20;
                picBox_player.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.Right)
            {
                picBox_player.ImageLocation = "./guy_left.png";
                if (x >= 500) return;
                if (state == 0 && (x + 20 >= 100 && x + 20 <= 450)) return;
                x += 20;
                picBox_player.Location = new Point(x, y);
            }
        }

        // 플레이어 사망 메서드
        private void playerDead()
        {
            int x = picBox_player.Location.X;
            int y = picBox_player.Location.Y;
            picBox_car.Location = new Point(x, 187);
            picBox_car.Visible = true;
            picBox_player.ImageLocation = "./guy_dead.png";
            picBox_player.Location = new Point(x - 100, y+20);
            dead = 1;
            DialogResult result = MessageBox.Show("Play Again?", "you died", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dead = 0;
                sec = 0;
                picBox_player.Location = new Point(0, 198);
                picBox_car.Visible = false;
                picBox_player.ImageLocation = "./guy_left.png";
            }
            else
            {
                this.Close();
            }
        }
    }
}
