using System;

namespace JeuDeMath
{
    class Program
    {
            const int min = 1;
            const int max = 9;
        private static void AskAddition()
        {
            Random random = new Random();
            int nbal1 = random.Next(min, max);
            int nbal2 = random.Next(min, max); ;

            Console.WriteLine("Please calculate the result of this operation :" + nbal1 + " + " + nbal2 + " = ?");
            string result = Console.ReadLine();


            int nombre = 0;
            if (int.TryParse(result, out nombre) == true)
            {
                int answer = nbal1 + nbal2;
                if (nombre == answer)
                {
                    Console.WriteLine("Congrats ! You found it");
                }
                else
                {
                    Console.WriteLine("Sorry, but the result was : " + answer + ", game over");
                };
            }
            else
            {
                Console.WriteLine("please enter a integer between " + min + " and " + max);
            }
            ;
        }
       static void Main(string[] args)
        {
            AskAddition();
        }
    }
}
