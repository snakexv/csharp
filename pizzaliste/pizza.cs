using System;
using System.Collections.Generic;

namespace ListePizza
{
    public class pizza
    {
        public static pizza pizzaLaMoinsChere;
        public static pizza pizzaLaPlusChere;
        List<string> listpizza = new List<string>(5);
        //List<string> prixPizza = new List<string>();
        string nom; 
        int prix;

        public pizza(string nom, int prix)
        {
            this.nom = nom;
            this.prix = prix;
            if (pizzaLaMoinsChere == null){ pizzaLaMoinsChere = this; }
            else 
                { if (prix > pizzaLaPlusChere.prix) {pizzaLaPlusChere = this; }}
            if (pizzaLaPlusChere == null) { pizzaLaPlusChere = this; }
            else
            { if (prix < pizzaLaMoinsChere.prix) { pizzaLaMoinsChere = this; } }

        }

       public int Prix
        {
            get { return prix; }
        }


        public void PrintList()
        {
            Console.WriteLine("Pizza : " + nom + " - " + prix + " Euros ");
        }

        public static void printCheapAndExpensive()
        {
            if (pizzaLaPlusChere != null) { Console.WriteLine("Pizza la plus chère "); pizzaLaPlusChere.PrintList(); }
            ;
            if (pizzaLaMoinsChere != null) { Console.WriteLine("Pizza la moins chère "); pizzaLaMoinsChere.PrintList(); }
        }

        //internal void PrixCompareTo(object prix)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
