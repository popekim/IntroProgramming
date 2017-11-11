using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int passcodeNumber1 = 6;
            int passcodeNumber2 = 2;

            Console.WriteLine("첫 번째 숫자를 넣어주세요.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 넣어주세요.");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == passcodeNumber1 && number2 == passcodeNumber2)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
        }
    }
}