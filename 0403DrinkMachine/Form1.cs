using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0403DrinkMachine
{
    public partial class Form1: Form
    {
            List<Drink> drinks = new List<Drink> {
                new Drink(1, "콜라", 500),
                new Drink(2, "사이다", 500),
                new Drink(3, "물", 800),
                new Drink(4, "파워에이드", 1000)
                };

        int moneyLeft = 2000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            moneyLeft -= drinks[0].price;
            MessageBox.Show(moneyLeft.ToString());
        }
    }

    public class Drink
    {
        public int number;
        public string name;
        public int price;

        public Drink(int number, string name, int price)
        {
            this.number = number;
            this.name = name;
            this.price = price;
        }
    }
}
