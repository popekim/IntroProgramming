using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("10 > 10 은 ");
            Console.WriteLine(10 > 10);     // 거짓

            Console.Write("10 >= 10 은 ");
            Console.WriteLine(10 >= 10);    // 참

            Console.Write("5 < 10 은 ");
            Console.WriteLine(5 < 10);      // 참

            Console.Write("5 <= 10 은 ");
            Console.WriteLine(5 <= 10);     // 참

            Console.Write("5 == 4 는 ");
            Console.WriteLine(5 == 4);      // 거짓

            Console.Write("5 != 4 는 ");
            Console.WriteLine(5 != 4);	    // 참
        }
    }
}
