using System;
using System.Collections.Generic;

namespace ListePizza
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<pizza> pizzas = new List<pizza>();
            pizzas.Add(new pizza("vegetarienne", 12, new string[] { "mozzarella", "oignons", "tomate" }));
            pizzas.Add(new pizza("oriental", 10, new string[] { "mozzarella", "gruyere", "emmental", "merguez" }));
            pizzas.Add(new pizza("4 fromages", 14, new string[] { "mozzarella", "gruyere", "emmental", "chevre" }));
            pizzas.Add(new pizza("thon", 11, new string[] { "thons", "oignons", "tomate" }));
            pizzas.Add(new PizzaGratuite("4 saisons", new string[] { "olive", "oignons", "courgette","poivrons" }));

            pizzas.Sort((pizza x, pizza y) =>
            {
                return x.Prix.CompareTo(y.Prix);
            });


            foreach (pizza p in pizzas)
            {
                p.PrintList();
            }

            pizza.printCheapAndExpensive();


        }
    }
}
