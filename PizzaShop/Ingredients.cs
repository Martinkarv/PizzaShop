using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Ingredients
    {
        int id;
        string name;
        double price;
        

      
        

        public Ingredients(int _id, string _name, double _price)
        {
            id = _id;
            name = _name;
            price = _price;
        }

        public string Name
        {
            get { return name; }
        }

        public double Price
        {
            get { return price; }
        }

    }
}
