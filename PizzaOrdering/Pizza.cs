using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    internal class Pizza
    {
        //string to hold pizza flavours
        public string [] pizza = new string [10];


        //array to hold pizza toppings
        public string[] toppings = new string[10];
        
        //data field for price
        public double price;

        public double pizzaPrice;

        public string line = null;

        public string pizz = null;
        //pizza constructor
        public Pizza(string[]pizza, int num1,string[] top, int num2)
        {

            for(int i = 0; i < num1; i++){
                pizz += pizza[i] + " , ";
            }
            pizzaPrice = 40;
            //loop to add toppings to array
            for (int i = 0; i < num2; i++)
            {
                line += top[i] + " , ";
            }
            //adjust price based on the number of toppings
            price = pizzaPrice + (num2 * 4);
        }
        public double Price { set; get; }

        //method to display the Pizza description and price
        public override string ToString()
        {
            return pizz +  "flavours\nTotal cost is: R"+price + " with " + line + "topping(s)";
        }
    }
}
