using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int doorLockNumber1 = 6;
            int doorLockNumber2 = 2;

            Console.WriteLine("첫번째 숫자를 넣어주세요.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 넣어주세요.");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == doorLockNumber1 &&number2 == doorLockNumber2)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
        }
    }
}
