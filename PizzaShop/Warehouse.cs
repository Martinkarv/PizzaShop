using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Warehouse
    {
        List<Ingredients> InStock;

        public Warehouse()
        {
            InStock = new List<Ingredients>();

            Ingredients salami = new Ingredients(1, "Salami", 0.50);
            InStock.Add(salami);

            Ingredients ham = new Ingredients(2, "Ham", 0.40);
            InStock.Add(ham);

            Ingredients onion = new Ingredients(3, "Onion", 0.20);
            InStock.Add(onion);

            Ingredients pineapple = new Ingredients(4, "Pineapple", 0.20);
            InStock.Add(pineapple);

            Ingredients bacon = new Ingredients(5, "Bacon", 0.30);
            InStock.Add(bacon);

            Ingredients cheese = new Ingredients(6, "Cheese", 0.20);
            InStock.Add(cheese);

            Ingredients mozarella = new Ingredients(7, "Mozarella", 0.30);
            InStock.Add(mozarella);

            Ingredients garlic = new Ingredients(8, "Garlic", 0.20);
            InStock.Add(garlic);

            Ingredients texmexSauce = new Ingredients(9, "Tex-mex sauce", 0.40);
            InStock.Add(texmexSauce);

            Ingredients mushrooms = new Ingredients(10, "Mushrooms", 0.50);
            InStock.Add(mushrooms);



        }
        public void ShowIngredients()
        {
            foreach (Ingredients ingredient in InStock)
            {
                Console.WriteLine(ingredient);
            }
        }






    }



}
