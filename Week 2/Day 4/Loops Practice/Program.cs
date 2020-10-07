using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Loops_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter your number:");
            //int num = 5;
            //string input = Console.ReadLine();
            //num = Int32.Parse(input);



            ////First Part//////
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write("#");

            //}
            //Console.WriteLine();


            //            Secand part////////////////////////////////////////////


            //int i, x, number;

            //Console.Write("write your number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= number; i++)
            //{
            //    for (x = 1; x <= i; x++)
            //        Console.Write("*");
            //    Console.Write("\n");

            //                part three //////////////////////////////////////////////////////////////////////////////


            //            Console.Write("Enter your number:");
            //                int num = 5;
            //                string input = Console.ReadLine();
            //                num = Int32.Parse(input);
            //                for (int i = 0; i < num; i++)
            //                {
            //                    for (int x = 0; x < num; x++)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    Console.WriteLine();
            //                }

            //          part five/////////////////////////////////////////////////

            //            int i, x, number;
            //                    Console.Write("write your number: ");
            //                    number = Convert.ToInt32(Console.ReadLine());
            //                    Console.WriteLine();


            //                    for (i = 0; i < number; i++)
            //                    {

            //                        for (x = 0; x < number - 1 - i; x++)
            //                            Console.Write(" ");

            //                        for (x = 0; x < number; x++)
            //                            Console.Write("#");

            //                        Console.WriteLine();





            //            / part four/////////////////////////////////////////////////////////////////////////////



            //Console.Write("Enter your number:");
            //int num = 5;
            //string input = Console.ReadLine();
            //num = Int32.Parse(input);

            //for (int i = 0; i < num; i++)
            //{
            //    for (int x = 0; x < num; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //                part six////////////////////////////////////////////////////////////////////////

            //int i, x, number;
            //number = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < number; i++)
            //{
            //    for (x = 1; x <= number - i; x++)
            //        Console.Write(" ");
            //    for (x = 1; x <= 2 * i - 1; x++)
            //        Console.Write("*");
            //    Console.Write("\n");
            //      Part seven//////////////////////////////////////////////////////////////////



            //            Console.Write("Enter your number:");
            //                    int num = 5;
            //                    string input = Console.ReadLine();
            //                    num = Int32.Parse(input);

            //for (int i = 0; i < num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        for (int x = 0; x < num; x++)
            //        {
            //            Console.Write("#");
            //        }
            //    }


            //    Console.WriteLine();
            //}



            //    part 8      /////////////////////////////////////////////////////////


            //for (int i = 0; i < num; i++)
            //{
            //    if (i % num == 0)

            //    {
            //        for (int x = 0; x < num; x++)
            //        {
            //            Console.WriteLine("#" + "  " + "#"+" "+" #");





            //   part 9     ///////////////////

            //for (int i = 0; i < num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("#" + "#" + "#" + "#" + "#");
            //    }
            //    else if (i % 2 != 2)
            //        Console.WriteLine("#" + " " + "#" + " " + "#");

            //}

            //Console.WriteLine();
            //// part 10/////////////////////////////////////////////////////

            //for (int i = 0; i < num; i+=2)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(" "+"#"+" ");
            //        }
            //         else if (i % 5 == 0)
            //            {
            //        Console.WriteLine(num);

            //            }
            //        }


            //        Console.WriteLine();
            //    }


            //  part 12 ///////////////////////////////////////////////////////////////


            //int i, x;
            //for (i = 1; i <= num; i *= 2)
            //{
            //    for (x = 1; x <= i; x++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            // part 13///////////////////////////////////////////////////////////////



            //int i, x;
            //for (i = 0; i <= 7; i++)
            //{
            //    for (x = 1; x <= 40 - i; x++)
            //    Console.Write("*");
            //    Console.WriteLine();
            //}


            //part 14 //////////////////////////////////////////////////???????
            //Console.WriteLine("Enter the width ");
            //int width = 0, height = 0;

            ////height = int.Parse(Console.ReadLine());

            //width = int.Parse(Console.ReadLine());
            //while (width >= 0)
            //{
            //    for (int h = 1; h <= height; h++)

            //    {
            //        for (int w = 0; w <= width; w++)
            //        {
            //            Console.Write("#");

            //        }
            //        Console.WriteLine();
            //    }
            //    height++;
            //    width--;

            //}
            //   eleven //////////////////////////////////////////////////////7

            //for (int i = 0; i < num +1 ; i++)
            //{
            //    Console.Write("#");
            //    for (int x = 0; x < num -1; x++)
            //    {
            //        Console.WriteLine(" #");
            //    }

            //  part 16/////////////////////////////////



            int n = int.Parse(Console.ReadLine());

            /*
            while (startingLineLength >= 0)
            {
                int startingLineLength = n;
                for (int i = 0; i <= startingLineLength - 1; i++)
                {
                    int lineLength = startingLineLength-i;
                    for (int y = 0; y <= lineLength - 1; y++)
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");

                }
                Console.WriteLine();

                startingLineLength--;
            }*/

            /*
            int startingLineLength = n;
            while (startingLineLength >= 0)
            {
                for (int lineLength = startingLineLength; lineLength >= 1; lineLength--)
                {
                    for (int y = 0; y <= lineLength - 1; y++)
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");

                }
                Console.WriteLine();

                startingLineLength--;
            }
            */

            for (int startingLineLength = n; startingLineLength >= 1; startingLineLength--)
            {
                for (int lineLength = startingLineLength; lineLength >= 1; lineLength--)
                {
                    for (int y = 0; y <= lineLength - 1; y++)
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}




