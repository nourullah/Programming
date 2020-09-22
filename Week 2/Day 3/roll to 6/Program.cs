using System;

namespace roll_to_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = 0;          
            int total = 0;
            
            do
            {
                number = random.Next(1, 7);
                Console.WriteLine($"the player rolls {number}");
                total = number + total;
            } 
            while (number < 6);

            Console.WriteLine($"total score {total}");

        }

    }
}
