using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("100 + 10 = ");
            Console.WriteLine(100 + 10);
            Console.Write("100 - 10 = ");
            Console.WriteLine(100 - 10);
            Console.Write("100 * 10 = ");
            Console.WriteLine(100 * 10);
            Console.Write("84 / 10 = ");
            Console.WriteLine(84 / 10);
            Console.Write("84 % 10 = ");
            Console.WriteLine(84 % 10);

            Console.WriteLine("글" + "붙여쓰기");

            Console.WriteLine("글붙여쓰기" - "붙여쓰기"); // 문자열에는 ‘-‘연산자가 없어서 오류!
        }
    }
}
