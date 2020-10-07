using System;

namespace Week_2_day_3_mission_1_ob
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numbergen = new Random();
            int firstThrow = numbergen.Next(0, 11);
            int secondThrow = numbergen.Next(0, 11 - firstThrow);

            Console.Write("First roll: ");

            if (firstThrow < 10)
            {
                if (firstThrow == 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine(firstThrow);
                }
                Console.Write("Second roll: ");

                if (secondThrow == 0)
                {
                    Console.WriteLine("-");
                }
                else if (firstThrow + secondThrow == 10)
                {
                    Console.WriteLine("/");
                }
                else
                {
                    Console.WriteLine(secondThrow);
                }
            }

            else
            {
                Console.WriteLine("x");
            }

            Console.WriteLine($"Knocked pins: {firstThrow + secondThrow}");


            }
            





        
    }
}
