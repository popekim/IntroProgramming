using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string appleCountDescription = "바구니 안에 담긴 사과의 개수: ";
            Console.Write(appleCountDescription);
            int appleCount = 12;
            Console.WriteLine(appleCount);

            appleCount = appleCount - 2;
            appleCountDescription = "내가 먹고 난 뒤에 " + appleCountDescription;

            Console.Write(appleCountDescription);
            Console.WriteLine(appleCount);

        }
    }
}
