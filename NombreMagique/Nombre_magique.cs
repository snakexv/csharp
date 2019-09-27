using System;

namespace NombreMagique
{
    class Program
    {
        static void Main(string[] args)
        {
            int  nb_mag = 5;
            int NumberOfLife = 4;
            while (NumberOfLife > 0)
             {

            Console.WriteLine("Can you guess the magic number (there is still " + NumberOfLife + " lives left) : " );
            String nombre = Console.ReadLine();

            int nombre_num = 0;
            if (int.TryParse(nombre, out nombre_num) == true)
            {
                
               
                    if (nombre_num > nb_mag)
                    {
                        Console.WriteLine("The number is higher, please try again");
                    }
                    else if (nombre_num < nb_mag)
                    {
                        Console.WriteLine("The number is lower, please try again");
                    }
                    else
                    {
                        Console.WriteLine("Congrat ! You found the good one !");
                        break;
                    };

                    NumberOfLife--;
            }
            else
            {
                Console.WriteLine("Please enter a number !");
            };
                
            };
            if (NumberOfLife>0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Sorry Game over !");
            }
            
        }
    }
}
