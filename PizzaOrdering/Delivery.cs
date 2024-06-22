using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrdering
{
    //inheritance
    internal class Delivery:Pizza
    {
        private double DeliveryFee;
        private string DeliveryAddress;

        //delivery pizza constructor
        public DeliveryPizza(string[] top, string _deliveryAddress, int num): base(top, num)
        {
            DeliveryAddress = _deliveryAddress;

        }
        //method to calculate delivery fee
        public double deliveryFee()
        {
            if(price < 50)
            {
                DeliveryFee = 20;
            }
            else
            {
                DeliveryFee = 30;
            }
            return DeliveryFee;
        }
    }
}
