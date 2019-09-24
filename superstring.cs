using System;


namespace Super
{
    public class superstring
    {   
        private string chaine; // chaine de catactère

 
    public string Chaine
    {
        get { return chaine; }
    }


    // Constructeur
        public superstring(string lachaine)
        {
            chaine = lachaine;
        }

    // Ajoute un character
        public void ajoute(string charac)
        {
            chaine = chaine + charac;
        }

    // ajoute à un endroit de la chaine
        public void insert(string charac, int i)
        {
            int j = chaine.Length;
            chaine = chaine.Substring(0,i) + charac + chaine.Substring(i, j-i);
        }

    // met en majuscule
        public void upper()
        {
            chaine = chaine.ToUpper();
        }

    // met en minuscule
        public void lower()
        {
            chaine = chaine.ToLower();
        }

    // Renvoie la description de la chaine
        public string affiche()
        {
            return chaine;
        }
    }
}

namespace Super
{
    class Prog
    {
    static void Main()
        {
superstring s1 = new superstring("Debout les DAMNES");
s1.ajoute("s");
s1.insert("l", 9);
s1.upper();
//s1.lower();
Console.WriteLine(s1.affiche());;
        }
    }
}