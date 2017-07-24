using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] doorLockNumber = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];

            while (true)
            {
                Console.WriteLine("첫번째 숫자를 넣어주세요.");
                userInput[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("두번째 숫자를 넣어주세요.");
                userInput[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("세번째 숫자를 넣어주세요.");
                userInput[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("네번째 숫자를 넣어주세요.");
                userInput[3] = int.Parse(Console.ReadLine());
                Console.WriteLine("다섯번째 숫자를 넣어주세요.");
                userInput[4] = int.Parse(Console.ReadLine());
                Console.WriteLine("여섯번째 숫자를 넣어주세요.");
                userInput[5] = int.Parse(Console.ReadLine());

                if (userInput[0] == doorLockNumber[0] && userInput[1] == doorLockNumber[1] && userInput[2] == doorLockNumber[2] && userInput[3] == doorLockNumber[3] && userInput[4] == doorLockNumber[4] && userInput[5] == doorLockNumber[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다.");
                }
            }
        }
    }
}
