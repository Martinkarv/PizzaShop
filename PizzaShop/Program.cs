using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a console app to allow your users order a pizza.
            //1.You have got a menu of five pizza types.
            //2.A user can choose from two types of pizza dough.
            //3.A user can add some additional ingredients to their order.
            //4.A user can choose a custom pizza with four ingredients.
            //5.A user can order more than one pizza.
            //6.After the user confirms their order, the total is displayed.

           
            Menu menu = new Menu();

            menu.ShowPizza();


            Console.WriteLine("Choose your pizza.");
           string userInput = Console.ReadLine();

            Console.WriteLine("Which dough you would like? Fat or thick?");
            string userChoice = Console.ReadLine();

            if(userChoice.ToLower() == "fat")
            {
               
            }

            Console.WriteLine($"Your order:{userInput} with {userChoice} dough.");

            Menu ingredient = new Menu();
            ingredient.ShowIngredients();
            


            Console.ReadLine();

           




        }

       


    }
}
