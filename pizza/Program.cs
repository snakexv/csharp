using System;
using System.Collections.Generic;
using System.Linq;

namespace pizza
{
    class Program
    {
        public static void PrintList(List<string> liste)
        {
            foreach (string p in liste)
            {
                Console.WriteLine(p);
            }
        }
        public static void Main(string[] args)
        {
            const int Nb_pizza = 10;
            string[] pizza = new string[Nb_pizza];
            
            for (int i = 0; i < Nb_pizza;i++)
                {
                    int j = i + 1;
                    pizza[i] = "Pizza "+ j;
                }

            List<string> Pizza = pizza.ToList();

            while (true)
            {

            Console.Write("Please add a new pizza (or nothing to close) : ");
                string NewPizza = Console.ReadLine();

                

            if (NewPizza=="")
                {

                    Console.WriteLine("");

                    break;
                  
                }
            else
                {
                    Pizza.Add(NewPizza);
                }

            }
            PrintList(Pizza);

        }
    }
}
