using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0525_DrinkMachine
{
    public class Machine
    {
        public String name { get; set; }
        public int money { get; set; }  // 사용자가 넣은 돈
        public int moneyBox { get; set; }  // 금고
        public List<Drink> stock { get; set; }

        public Machine(string name, int moneyBox)
        {
            this.name = name;
            this.moneyBox = moneyBox;
            this.stock = new List<Drink>();
        }

        public void takeMoney(int money)
        {
            this.money += money;
        }
        public void moneyBack()
        {
            this.money = 0;
        }


        public bool run(int index)
        {
            if (stock[index].price > money)
            {
                MessageBox.Show("잔액이 부족합니다.");
                return false;
            }
            money -= stock[index].price;
            moneyBox += stock[index].price;
            stock[index].stock--;
            return true;
        }
    }
}
