
using System;
 
namespace Compte
{
    public class CompteBancaire
    {   
        private string titulaire; // Titulaire du compte
        private double solde;    // Solde du compte
 
 
    public string Titulaire
    {
        get { return titulaire; }
    }
 
    public double Solde
    {
        get { return solde; }
    }
   
 
    // Constructeur
        public CompteBancaire(string leTitulaire="Dupont", double soldeInitial=1000)
        {
            titulaire = leTitulaire;
            solde = soldeInitial;
        }
 
    // Ajoute un montant au compte
        public void depot(double montant)
        {
            solde = solde + montant;
        }
 
    // Retire un montant au compte
        public void retrait(double montant)
        {
            solde = solde - montant;
        }
 
    // Renvoie la description du compte
        public string affiche()
        {
            string description = "Le solde du compte de " + titulaire + " est de " + solde;
            return description;
        }
    }
}
 
namespace Compte
{
    class Programme
    {
        public static void Main(string[] args)
        {
CompteBancaire compte = new CompteBancaire("Johnny", 100);
Console.WriteLine(compte.affiche());;
        }
    }
}

