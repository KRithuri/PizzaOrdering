using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    internal class Pizza
    {
        //array to hold pizza toppings
        public string[] toppings = new string[10];
        //data field for price
        public double price;
        public string line = null;

        //pizza constructor
        public Pizza(string[] top, int num)
        {
            //loop to add toppings to array
            for (int i = 0; i < num; i++)
            {
                line += top[i] + " , ";
            }
            //adjust price based on the number of toppings
            price = 40 + (num * 4);
        }
        public double Price { set; get; }

        //method to display the Pizza description and price
        public override string ToString()
        {
            return price + " with " + line + "topping(s)";
        }
    }
}
