using System;

namespace KeyboardInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string appleCountDescription = "바구니 안에 담긴 사과의 개수: ";
            Console.Write(appleCountDescription);
            int appleCount = 12;
            Console.WriteLine(appleCount);

            Console.WriteLine("사과를 몇 개 먹을까요?");
            string userInput = Console.ReadLine();
            int eatenAppleCount = int.Parse(userInput);
            appleCount = appleCount - eatenAppleCount;

            appleCountDescription = "내가 먹고 난 뒤에 " + appleCountDescription;
            Console.Write(appleCountDescription);
            Console.WriteLine(appleCount);

            Console.WriteLine("사과 바구니의 무게는 얼마인가요?");
            userInput = Console.ReadLine();
            double basketWeight = double.Parse(userInput);

            Console.WriteLine("사과 하나의 무게는 얼마인가요?");
            userInput = Console.ReadLine();
            double appleWeight = double.Parse(userInput);

            Console.Write("사과와 바구니의 총 무게: ");
            Console.WriteLine(appleWeight * appleCount + basketWeight);
        }
    }
}