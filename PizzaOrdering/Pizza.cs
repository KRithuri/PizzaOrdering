﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    internal class Pizza
    {
        //array to hold pizza flavours
        private string[] pizzaFlavour = new string[10];
        //array to hold pizza toppings
        private string[] toppings = new string[10];

        //data field for price
        private double price;

        //data field for pizza price
        private double pizzaPrice;

        private string line = null;

        private string pizz = null;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double PizzaPrice
        {
            get { return pizzaPrice; }
            set { pizzaPrice = value; }
        }
        public string Line
        {
            get { return line; }
            set { line = value; }
        }
        public string Pizz
        {
            get { return pizz; }
            set { pizz = value; }
        }
        public string[] PizzaFlavour
        {
            get { return pizzaFlavour; }
            set { pizzaFlavour = value; }
        }
        public string[] Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }
        //pizza constructor
        public Pizza(string[] pizzaFlavour, int num, string[] top)
        {
            //loop to add pizza flavours and toppings 
            for (int i = 0; i < num; i++)
            {
                //add to pizza flavour array
                pizz += pizzaFlavour[i] + " , ";
                pizzaPrice += 40;
                //add to toppings array
                line += top[i] + " , ";
            }
            //adjust price based on number of toppings
            price = pizzaPrice + (num * 4);
        }
        //method to display the Pizza description and price
        public override string ToString()
        {
            return pizz + "\nTopping(s): " + Line + "\nTotal cost is: R" + price  ;
        }
    }
}
