using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class ItemsTogether
    {
        Pizzas pizzas;
        int quantity;


        public ItemsTogether(Pizzas _pizzas, int _quantity)
        {
            pizzas = _pizzas;
            quantity = _quantity;
        }

        public Pizzas Pizzas
        {
            get { return pizzas; }
        }

        public void PrintItems()
        {
            Console.WriteLine($"Name:{pizzas.Name} \n Price:{pizzas.Price} \n Quantity:{quantity} Total:{CalculateItemTotal()}$ ");
        }

        public double CalculateItemTotal()
        {
            return pizzas.Price * quantity;
        }


    }
}
