using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace _0525_DrinkMachine
{
    public partial class Form1 : Form
    {
        Form2 machine;
        Machine drinkMachine;
        Human man;
        public Form1()
        {
            InitializeComponent();
            // 머신 인스턴스화
            drinkMachine = new Machine("drinkMachine", 0);
            drinkMachine.stock.Add(new Drink(1, "콜라", 1500, "images/drink_pepsi.png"));
            drinkMachine.stock.Add(new Drink(1, "사이다", 1300, "images/drink_sprite.png"));
            drinkMachine.stock.Add(new Drink(1, "물", 800, "images/drink_water.png"));
            drinkMachine.stock.Add(new Drink(1, "포카리스웨트", 2400, "images/drink_pocari.png"));
            // 인간 인스턴스화
            man = new Human("폴리", 10000);
            pic_guy.BackColor = Color.Transparent;
            // 머신 생성
            machine = new Form2(drinkMachine, man);
        }

        // 플레이어 이동 메서드
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pic_guy.Location.X;
            int y = pic_guy.Location.Y;
            if (x >= 330 && x <= 400)
            {
                if (e.KeyCode == Keys.Enter)
                {
                if (machine.Visible == false) machine.Show();
                else machine.Hide();
                }
            }
            else machine.Hide();

            if (e.KeyCode == Keys.Left)
            {
                pic_guy.ImageLocation = "images/guy_right.png";
                if (x <= 0) return;
                x -= 20;
                pic_guy.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.Right)
            {
                pic_guy.ImageLocation = "images/guy_left.png";
                if (x >= 500) return;
                x += 20;
                pic_guy.Location = new Point(x, y);
            }
        }
    }
}
