using System;

namespace NombreMagique
{
    class Program
    {
        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10;
            const int NumberLife = 4;
            Random random = new Random();
            int nb_mag = random.Next(min, max);
            int NumberOfLife = NumberLife;

            while (NumberOfLife > 0)
             {

            Console.WriteLine("Can you guess the magic number between "+ min +" and "  +max +" (there is still " + NumberOfLife + " lives left) : " );
            String nombre = Console.ReadLine();
            

            int nombre_num = 0;
            if (int.TryParse(nombre, out nombre_num) == true)
            {
                
                if((nombre_num > max) | (nombre_num < min))
                        {
                        Console.WriteLine("You didn't guess a number between " + min + " and " + max +", please try again");
                        NumberOfLife++;
                        }
                else
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
                Console.WriteLine("Sorry Game over ! The number that you had to guess was : " + nb_mag);
            }
            
        }
    }
}
