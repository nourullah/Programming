using System;
using System.Collections.Generic;
using System.Linq;

namespace day_5
{
    class Program
    {
        static void Main(string[] args)
        {

            List < int >summa= new List<int>();


            for (int i = 0; i < 6; i++)
            {
                summa.Add(roll());
            }

            summa.Sort();
            Console.WriteLine($"Your available ability scores are {summa[0]}, {summa[1]}, {summa[2]}, {summa[3]} , {summa[4]} , {summa[5]}");

        }


        static int roll()
        {



            Random randon = new Random();
            int time = 0;
            int sum = 0;
            List<int> number = new List<int>();


            for (int i = 0; i < 4; i++)
            {
                number.Add(randon.Next(1, 7));

            }

            number = number.OrderByDescending(i => i).ToList();
            for (int i = 0; i < 3; i++)
            {
                sum = sum + number[i];
            }


            Console.Write($"you roll is {number[0]}, {number[1]}, {number[2]}, {number[3]}");

            Console.WriteLine($" The ability score is {sum}");

            return sum;








        }
    
    
    
    
    
    
    
    
    
    }


}
