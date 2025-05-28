using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0525_DrinkMachine
{
    public class Human
    {
        public String name;
        public int money;
        public List<Drink> inventory;

        public Human(string name, int money)
        {
            this.name = name;
            this.money = money;
            this.inventory = new List<Drink>();
        }

        public void getDrink(Drink drink)
        {
            inventory.Add(drink);
        }
    }
}
