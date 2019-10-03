using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class MaisonTest
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("Create Cat object from Maison(string,string,double,double,string)");


            Maison m1 = new Maison("haussmanien", 3, 18, "sud");
            Console.WriteLine(m1.houseID);
            Maison m2 = new Maison("nouveau", 45, 18, "ouest");
            Console.WriteLine(m2.houseID);
            Maison m3 = new Maison("cheverny", 30, 18, "est");
            Console.WriteLine(m3.houseID);
            Maison m4 = new Maison("chambord", 52, 20, "nord");
            Console.WriteLine(m4.houseID);
            Maison m5 = new Maison("ancien", 45, 85, "sud");
            Maison m7 = new Maison("dur", 20, 20, "nord-est");
            Console.WriteLine(m7.houseID);

            Console.WriteLine("------");

            Console.WriteLine("model = {0}", m1.model);
            Console.WriteLine("longitude = {0}", m4.longitude);
            Console.WriteLine("latitude = {0}", m2.latitude);
            Console.WriteLine("latitude = {0}", m2.latitude);
            Console.WriteLine("orientation = {0}", m3.orientation);
            Console.WriteLine("nb_houses = {0}", m7.houseID);
            Console.WriteLine("categorie = {0}", m5.categorie);

            Console.WriteLine("------");


            //Console.ReadLine();
        }
    }
}
