﻿using System;
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
            string input = null;
            //array for toppings 
            string[] top = new string[10];
            int x = 0;
            string delivery;
            string delFee = 0;

            //loop to populate toppings array
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
            delivery = Console.ReadLine();
        }
    }
}
