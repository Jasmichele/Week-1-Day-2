﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;

            Console.WriteLine("Pick # 1 - 100 to play FizzBuzz");

            y = Console.ReadLine();

            int newNum;

            if (!Int32.TryParse(y, out newNum))
            {
                Console.WriteLine("You didn't enter a #");
            }
            else if (newNum % 3 == 0 && newNum % 5 ==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (newNum % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (newNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Game Over");
            }






            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
