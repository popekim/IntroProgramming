using System;

namespace DoubleParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사과 바구니의 무게는 얼마인가요?");
            string userInput = Console.ReadLine();
            double basketWeight = double.Parse(userInput);

            Console.Write("사과 바구니의 무게: ");
            Console.WriteLine(basketWeight);
        }
    }
}
