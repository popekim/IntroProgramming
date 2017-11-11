using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연신지를 입력하세요.");
            string inputOperator = Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperator);
            Console.Write(number2);
            Console.Write(" = ");

            if (inputOperator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (inputOperator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (inputOperator == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (inputOperator == "/")
            {
                Console.WriteLine(number1 / number2);
            }
        }
    }
}