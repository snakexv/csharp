using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public class Batiment
    {
        protected static int id = 1;
        public string categorie;
        public double longitude;
        public double latitude;

        public Batiment(string categorie="habitat", double longitude=0, double latitude=0)
        {

            this.categorie = categorie;
            this.longitude = longitude;
            this.latitude = latitude;
            //Console.WriteLine("- Batiment(string,double,double)");
        }

        public Batiment(double longitude = 0, double latitude = 0)
        {

            this.longitude = longitude;
            this.latitude = latitude;
            //Console.WriteLine("- Batiment(double,double)");
        }


    }
}