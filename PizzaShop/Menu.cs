using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Menu
    {
        List<Pizzas> InMenu;
        List<Warehouse> IngredientsMenu;

        public Menu()
        {
            IngredientsMenu = new List<Warehouse>();

            Ingredients salami = new Ingredients(1, "Salami", 0.50);
            

            Ingredients ham = new Ingredients(2, "Ham", 0.40);

            Ingredients onion = new Ingredients(3, "Onion", 0.20);


            Ingredients pineapple = new Ingredients(4, "Pineapple", 0.20);
        

            Ingredients bacon = new Ingredients(5, "Bacon", 0.30);
          

            Ingredients cheese = new Ingredients(6, "Cheese", 0.20);
          

            Ingredients mozarella = new Ingredients(7, "Mozarella", 0.30);
         

            Ingredients garlic = new Ingredients(8, "Garlic", 0.20);
          

            Ingredients texmexSauce = new Ingredients(9, "Tex-mex sauce", 0.40);
            

            Ingredients mushrooms = new Ingredients(10, "Mushrooms", 0.50);
          
            InMenu = new List<Pizzas>();

            Pizzas mexicana = new Pizzas("Mexicana", 5.99, salami,onion,garlic,mozarella);
            InMenu.Add(mexicana);

            Pizzas quattro = new Pizzas("Quattro", 5.40, ham, cheese, garlic, mushrooms);
            InMenu.Add(quattro);

            Pizzas rustica = new Pizzas("Rustica", 7,texmexSauce, mozarella,bacon,onion);
            InMenu.Add(rustica);

            Pizzas alSole = new Pizzas("Al Sole", 4.50,mushrooms,cheese,onion,bacon);
            InMenu.Add(alSole);

            Pizzas tropicana = new Pizzas("Tropicana", 6.50,ham,cheese,onion,garlic);
            InMenu.Add(tropicana);

           // Pizzas fantasy = new Pizzas("Fantasy", 8);
          //  InMenu.Add(fantasy);
            

        }

        public void ShowPizza()
        {
            foreach(Pizzas pizza in InMenu)
            {
                pizza.PrintPizza();
                Console.WriteLine();
            }
            

        }

        public void ShowIngredients()
        {
            foreach(Warehouse ingredient in IngredientsMenu)
            {
                ingredient.ShowIngredients();
                Console.WriteLine();
            }
        }
















    }
}
