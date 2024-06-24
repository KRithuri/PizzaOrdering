using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    internal class Pizza
    {
        //array to hold pizza flavours
        private string [] pizzaFlavour = new string [10];
        //array to hold pizza toppings
        private string[] toppings = new string[10];
        
        //data field for price
        private double price;

        //data field for pizza price
        private double pizzaPrice;

        
        public string line = null;

        public string pizz = null;
        //pizza constructor
        public Pizza(string[]pizzaFlavour, int num1,string[] top, int num2)
        {

            for(int i = 0; i < num1; i++){
                pizz += pizzaFlavour[i] + " , ";
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

        public double PizzaPrice { 
            get { return pizzaPrice; }
            set { pizzaPrice = value;}
        }
        public string [] PizzaFlavour{
            get { return pizzaFlavour;}
            set { pizzaFlavour = value;}
        }
        public string [] Toppings{
            get { return toppings;}
            set { toppings = value;}
        }

        //method to display the Pizza description and price
        public override string ToString()
        {
            return pizz +  "flavours\nTotal cost is: R"+price + " with " + line + "topping(s)";
        }
    }
}
