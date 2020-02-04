using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class ShoppingCart
    {

        List<ItemsTogether> shoppingCart;
        double total;

        public ShoppingCart()
        {
            shoppingCart = new List<ItemsTogether>();
            total = 0;
        }

        public double Total
        {
            get { return total; }
        }

        public void AddToShoppingCart(Pizzas pizzas, int quantity)
        {
            ItemsTogether newItems = new ItemsTogether(pizzas, quantity);
            shoppingCart.Add(newItems);
        }

        public void RemoveFromShoppingCart(string name)
        {
            
        }


        public void PrintShoppingCart()
        {
            foreach(ItemsTogether items in shoppingCart)
            {
                items.PrintItems();
            }
        }

        public void PrintTotal()
        {
            foreach(ItemsTogether items in shoppingCart)
            {
                total += items.CalculateItemTotal();
            }
        }

    }

   


}
