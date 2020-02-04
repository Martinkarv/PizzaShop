using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Pizzas
    {
        string name;
        List<Ingredients> ingredients;
        double price;
        //string ing1;



        public Pizzas(string _name,  double _price, Ingredients ing1, Ingredients ing2, Ingredients ing3, Ingredients ing4)
        {
            ingredients = new List<Ingredients>();

            ingredients.Add(ing1);
            ingredients.Add(ing2);
            ingredients.Add(ing3);
            ingredients.Add(ing4);
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

        public void PrintPizza()
        {
            Console.WriteLine($"Pizza {Name}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine("Ingredients: ");
            foreach(Ingredients ingredient in ingredients)
            {
                Console.WriteLine(ingredient.Name);
            }
        }
        public void PrintIngredients()
        {
            foreach (Ingredients ingredient in ingredients)
            {
                Console.WriteLine(ingredient.Name);
            }
        }
        
    }

    
}
