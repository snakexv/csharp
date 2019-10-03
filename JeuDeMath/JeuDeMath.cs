using System;

namespace JeuDeMath
{
    class Program
    {
            const int min = 1;
            const int max = 9;
            public int point = 0;
            

        private static bool AskAddition()
        {

            Random random = new Random();
            int nbal1 = random.Next(min, max);
            int nbal2 = random.Next(min, max); ;


                while (true)
                {
                    Console.WriteLine( nbal1 + " + " + nbal2 + " = ?");
                    string result = Console.ReadLine();


                    int nombre = 0;
                    if (int.TryParse(result, out nombre) == true)
                    {
                        int answer = nbal1 + nbal2;
                        if (nombre == answer)
                        {
                            Console.WriteLine("Congrats ! You found it");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, but the result was : " + answer + " !");
                            return false;
                        };
                    }
                    else
                    {
                        Console.WriteLine("please enter a integer between " + min + " and " + max);
                    }
                }
            
        }
        static void Main(string[] args)
            {

            int point = 0;
            for (int i = 1; i <= 5; i++)
            {
                if (AskAddition())
                    {
                    point++;
                    
                    Console.WriteLine("you're still " + (5 - i) + " question left");
                    Console.WriteLine();  
                    }
                else
                    {  
                    Console.WriteLine("you're still " + (5 - i) + " question left");
                    Console.WriteLine();
                    }

            }
            if (point == 5)
            {
                Console.WriteLine("Perfect ! Your score is " + point + "/5");
            }
            else if ((point>=3) && (point<=4))
            {
                Console.WriteLine("Not bad ! You've got a score of " + point + "/5");
            }
            else
            {
                Console.WriteLine("Can be better ! This is your score :  " + point + "/5");
            }

            }
    }
}
