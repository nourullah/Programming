using System;
using System.Diagnostics.CodeAnalysis;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int hitpoint = 0;
            hitpoint = random.Next(1, 100);

            Console.WriteLine($"Warrior HP: {hitpoint} ");
            Console.WriteLine("Regenerate spell is cast!");

            while (hitpoint < 50)
            {
                hitpoint += 10; 
                Console.WriteLine($"Warrior Hp: {hitpoint}");
                
            }
            Console.WriteLine("Regenerate spell is complete");

        }










    }
}
