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
            string answer;
            //variable for user input
            string input;
            //array for toppings 
            string[] top = new string[10];

            //arra for pizza 
            string [] pizz = new string[10];

            int x = 0;
            //int y = 0;
            string del;
            double delFee = 0;
            string reorder;
            bool order =true;

            while(order){
                Console.Write("Enter pizza flavour " + ": ");
                answer = Console.ReadLine();
                //populate pizza flavours array
                pizz[x] = answer;
                Console.Write("Enter topping "  + ": ");
                input = Console.ReadLine();
                //populate toppings array
                top[x] = input;
                //increment x
                x++;

                Console.WriteLine("Would you like to order another pizza?");
                reorder = Console.ReadLine();
            
                
                if(reorder.ToUpper() == "Y"){
                    // Console.Write("Enter pizza flavour " + ": ");
                    // answer = Console.ReadLine();
                    // pizz[x] = answer;
                    // Console.Write("Enter topping " + ": ");
                    // input = Console.ReadLine();
                    // top[x] = input;
                    order = true;
                }
                //if (answer.ToUpper() != "QUIT"){
                   // pizz[x] = answer;
                    //x++;
                //}
                else{
                    // break;
                    order = false;

                }

            }
            //new pizza object
            Pizza pizza = new Pizza(top, x, pizz);

            string deliveryAdd = "";
            //ask user input for delivery option
            Console.WriteLine("Delivery? Y/N: ");
            del = Console.ReadLine();
            if (del.ToUpper() == "Y")
            {
                Console.WriteLine("Enter delivery address: ");
                deliveryAdd = Console.ReadLine();
                //new delivery object
                Delivery delPizza = new Delivery(top, deliveryAdd, x, pizz);
                delPizza.deliveryFee();
                delFee = delPizza.deliveryFee();
                Console.WriteLine("To be delivered at " + deliveryAdd + ",\nPizza flavours: " + pizza.ToString() + " and the delivery fee is: " + delFee);
            }
            else
            {
                Console.WriteLine("No delivery!" + "\nPizza price for pizza(s): "  + pizza.ToString() + " and the delivery fee is: " + delFee);
            }
            Console.ReadLine();
        }
        
    }
}
