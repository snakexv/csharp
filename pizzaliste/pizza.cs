using System;
using System.Collections.Generic;

namespace ListePizza
{
    public class pizza
    {
        public static pizza pizzaLaMoinsChere;
        public static pizza pizzaLaPlusChere;

        protected string nom; // protected est utilisé pour autoriser la classe enfant à utiliser cet variable
        int prix;
        const int nb_element=4;
        protected string[] ingredients;


        public pizza(string nom, int prix, string [] ingredients) // celui-ci va avec override et autorise la classe enfant à la modifier
        {
            this.nom = nom;
            this.prix = prix;
            this.ingredients = ingredients;
            
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


        virtual public void PrintList() // celui-ci va avec override et autorise la classe enfant à la modifier
        {
            Console.WriteLine("Pizza : " + nom + " - " + prix + " Euros ");
            Console.WriteLine(String.Join(", ", ingredients));
            Console.WriteLine("");
        }

        public static void printCheapAndExpensive()
        {
            if (pizzaLaPlusChere != null) { Console.WriteLine("Pizza la plus chère "); pizzaLaPlusChere.PrintList(); }
            ;
            if (pizzaLaMoinsChere != null) { Console.WriteLine("Pizza la moins chère "); pizzaLaMoinsChere.PrintList(); }
        }

    }

    class PizzaGratuite : pizza
    {
        public PizzaGratuite(string nom, string[] ingredients) : base(nom, 0, ingredients)
        { }
            override public void PrintList() //// celui-ci va avec virtual et est autorisé par la classe parent à la modifier
            {
                Console.WriteLine("Pizza : " + nom + " -  GRATUIT");
                Console.WriteLine(String.Join(", ", ingredients));
                Console.WriteLine("");
            }
       
    }
}
