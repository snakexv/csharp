using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public class Maison : Batiment
    {
        
        public int houseID { get; set; }
        public int max_maisons = 5;
        public string model;
        public string orientation;


        public Maison(string model, double longitude, double latitude, string orientation)
            : base(longitude, latitude)
        {
            if (Batiment.id >= this.max_maisons)
            {
                Console.WriteLine("Trop de maisons contruite");
            }
            else
            {
                this.categorie = "habitat";
                this.model = model;
                this.orientation = orientation;
                //Console.WriteLine("- Maison(string,double,double,string)");
                this.houseID = Batiment.id++;

            }
        }




    }
}