using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0525_DrinkMachine
{
    public partial class Form2 : Form
    {
        private Human man;
        private Machine machine;
        public Form2(Machine machine, Human man)
        {
            InitializeComponent();
            this.machine = machine;
            this.man = man;
            lbl_dp01.Text = machine.stock[0].name.ToString() + "\n" + machine.stock[0].price.ToString() + "원";
            lbl_dp02.Text = machine.stock[1].name.ToString() + "\n" + machine.stock[1].price.ToString() + "원";
            lbl_dp03.Text = machine.stock[2].name.ToString() + "\n" + machine.stock[2].price.ToString() + "원";
            lbl_dp04.Text = machine.stock[3].name.ToString() + "\n" + machine.stock[3].price.ToString() + "원";
            refreshLabel();
        }
        
        // 현금 투입
        private void btn_moneyInput_Click(object sender, EventArgs e)
        {
            if (tb_moneyInput.Text == "") return;
            if (sender == tb_moneyInput && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
            int money;
            bool success = int.TryParse(tb_moneyInput.Text, out money);
            if (success)
            {
                if (man.money < money)
                {
                    MessageBox.Show("현금이 부족합니다.");
                    return;
                }
                man.money -= money;
                machine.takeMoney(money);                
                refreshLabel();
                MessageBox.Show(money + "원을 투입하였습니다.");
                tb_moneyInput.Text = "";
            }
            else MessageBox.Show("숫자를 입력해주세요.");
        }
        // 엔터키로 입력
        private void tb_moneyInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_moneyInput_Click(this, e);
        }
        // 잔돈 반환     
        private void btn_moneyBack_Click(object sender, EventArgs e)
        {
            if (machine.money == 0) return;
            man.money += machine.money;
            MessageBox.Show("잔돈 " + machine.money + "원을 받았습니다.");
            machine.moneyBack();
            refreshLabel();
        }

        // 음료 선택
        private void btn_sel01_Click(object sender, EventArgs e)
        {
            btn_sel_Click(0);
        }    
        private void btn_sel02_Click(object sender, EventArgs e)
        {
            btn_sel_Click(1);
        }
        private void btn_sel03_Click(object sender, EventArgs e)
        {
            btn_sel_Click(2);
        }
        private void btn_sel04_Click(object sender, EventArgs e)
        {
            btn_sel_Click(3);
        }
        // 음료수 수령
        private void pic_box_Click(object sender, EventArgs e)
        {
            if (pic_box.Tag == null) return;
            MessageBox.Show(((Drink)pic_box.Tag).name + "을 받았습니다.");
            man.getDrink((Drink)pic_box.Tag);
            lbl_inventory.Text += ((Drink)pic_box.Tag).name + " ";
            pic_box.Image = null;
            pic_box.Tag = null;
        }

        // 음료 선택
        private void btn_sel_Click(int index)
        {
            if (pic_box.Image != null)
            {
                MessageBox.Show("음료수를 먼저 챙겨주세요.");
                return;
            }
            if (machine.run(index))
            {
                pic_box.ImageLocation = machine.stock[index].image;
                pic_box.Tag = machine.stock[index];
                refreshLabel();
            }
        }
        // 라벨 새로고침
        private void refreshLabel()
        {
            lbl_moneyLeft.Text = "잔액 : " + man.money.ToString() + "원";
            lbl_machineMoney.Text = "투입한 금액 : " + machine.money.ToString() + "원";
        }
        
        // 자판기 닫기
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
