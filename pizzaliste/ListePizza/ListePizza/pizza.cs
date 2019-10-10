using System;
using System.Collections.Generic;

namespace ListePizza
{
    public class pizza
    {
        List<string> listpizza = new List<string>(5);
        //List<string> prixPizza = new List<string>();
        string nom;
        int prix;

        public pizza(string nom, int prix)
        {
            this.nom = nom;
            this.prix = prix;
        }



        public void PrintList()
        {
            Console.WriteLine("Pizza : " + nom + " - " + prix + " Euros ");
        }


    }
}