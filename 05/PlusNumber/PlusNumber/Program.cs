using System;

namespace PlusNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();

            int number1 = int.Parse(userInput1);
            int number2 = int.Parse(userInput2);
            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 + number2);
        }
    }
}
