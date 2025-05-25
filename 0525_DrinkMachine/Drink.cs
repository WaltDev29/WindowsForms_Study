using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0525_DrinkMachine
{
    public class Drink
    {
        public int number;
        public String name;
        public int price;       
        public int stock;
        public String image;
        public Drink(int number, string name, int price, String image)
        {
            this.number = number;
            this.name = name;
            this.price = price;
            this.stock = 5;
            this.image = image;
        }

    }
}
