using System;
using System.Collections.Generic;

namespace ListePizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<pizza> pizzas = new List<pizza>();
            pizzas.Add(new pizza("vegetarienne", 12));
            pizzas.Add(new pizza("oriental", 10));
            pizzas.Add(new pizza("4 fromages", 14));
            pizzas.Add(new pizza("thon", 11));
            pizzas.Add(new pizza("4 saisons", 15));
            
            foreach (pizza p in pizzas)
            {
                p.PrintList();
            }
        }
    }
}
