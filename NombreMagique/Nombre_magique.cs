using System;

namespace NombreMagique
{
    class Program
    {
        static void Main(string[] args)
        {
            int  nb_mag = 5;
            
            Console.WriteLine("Please choose a number between 0 and 10!");
            String nombre = Console.ReadLine();

            int nombre_num = 0;
            if (int.TryParse(nombre, out nombre_num) == true)
            {
                //while (nombre_num != nb_mag)
                //{
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
                    };
                //};
            }
            else
            {
                Console.WriteLine("Please enter a number !");
            };


        }
    }
}
