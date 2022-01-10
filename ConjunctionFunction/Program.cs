using System;

namespace ConjunctionFunction
{
    class Program
    {
 // program takes number as input, print the multi table
      
        static void Alt(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers to multiply. Please hit ENTER after each number to add the next number.");
            var A = Convert.ToInt16(Console.ReadLine());
            var B = Convert.ToInt16(Console.ReadLine());
            var C = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine( A* B *C);
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Insert Number for Times Table");
        //    int[] X = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    var Z = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < length; i++)
        //    {

        //    }

        //    Console.WriteLine(X * Z);
        }
    }
}
