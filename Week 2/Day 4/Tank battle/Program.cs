using System;
using System.Collections.Generic;

namespace Tank_battle
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randon = new Random();

            int fireDistance;
            int shellsLeft = 5;

            Console.Write("Write your name :");
            Console.WriteLine();
            string name = Console.ReadLine();

            fireDistance = randon.Next(1, 20);

            Console.Write("-");
            Console.Write("/");

            for (int i = 0; i < fireDistance; i++)
            {
                Console.Write("-");
            }

            Console.Write($"F");

            int placeAfterFire = 30 - fireDistance - 3;

            for (int i = 0; i < placeAfterFire; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine($"Aim your water hose, {name}!");

            Console.Write("Enter distance: ");
            string waterDistanceText = Console.ReadLine();
            int waterDistance = Int32.Parse(waterDistanceText);

            Console.Write(" ");
            Console.Write(" ");





            for (int i = 0; i < waterDistance; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine($"W");

            Console.WriteLine($"Aim your shot, {name}");

            do
            {

                if (waterDistance > fireDistance)
                {
                    Console.WriteLine("oh no your shot was too long");
                }
                else if (waterDistance < fireDistance)
                {
                    Console.WriteLine("oh no your shot was too short");
                }
                else
                {
                    Console.WriteLine("it is ok");

                    Console.WriteLine("");

                }

                return;
            } while (true);

            Console.WriteLine(" loser");
            Console.WriteLine();
            Console.WriteLine("Alsa, the shell files past the tank");
            Console.WriteLine("you have 4 shells left");



            

        }
    }
}
    








    