using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    internal class RunPizza
    {
        static void Main(string[] args)
        {
            //variable for user input
            string input;
            //array for toppings 
            string[] top = new string[10];
            int x = 0;
            string del;
            double delFee = 0;

            //loop to populate toppings array
            //Console.Write("Enter topping: ");
            while (x < 10)
            {
                //ask user to enter topping
                Console.Write("Enter topping " + (x + 1) + ": ");
                input = Console.ReadLine();

                if(input.ToUpper() != "QUIT")
                {
                    top[x] = input;
                    x++;
                }
                else
                {
                    break;
                }
            }
            //new pizza object
            Pizza pizza = new Pizza(top, x);
            Console.WriteLine(pizza.ToString());

            string deliveryAdd = "";
            //ask user input for delivery option
            Console.WriteLine("Delivery? Y/N: ");
            del = Console.ReadLine();
            if (del.ToUpper() == "Y")
            {
                Console.WriteLine("Enter delivery address: ");
                deliveryAdd = Console.ReadLine();
                //new delivery object
                Delivery delPizza = new Delivery(top, deliveryAdd, x);
                delPizza.deliveryFee();
                delFee = delPizza.deliveryFee();
                Console.WriteLine("To be delivered at " + deliveryAdd + ", Pizza price is " + pizza.ToString() + " amd the delivery fee is: " + delFee);
            }
            else
            {
                Console.WriteLine("No delivery!" + "\nPizza price is " + pizza.ToString() + " and the delivery fee is: " + delFee);
            }
            Console.ReadLine();
        }
        
    }
}
