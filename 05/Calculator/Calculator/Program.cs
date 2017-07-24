using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            double number1 = double.Parse(userInput1);
            Console.WriteLine("두번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            double number2 = double.Parse(userInput2);

            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 + number2);
        }
    }
}
