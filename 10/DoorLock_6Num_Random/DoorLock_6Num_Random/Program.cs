using System;

namespace DoorLock_6Num_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int passcodeLength = 6;

            int[] passcodeNumbers = new int[passcodeLength];

            Console.WriteLine("비밀번호: ");
            for (int i = 0; i < passcodeLength; i++)
            {
                passcodeNumbers[i] = random.Next(0, 10);
                Console.Write(passcodeNumbers[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            int[] userInput = new int[passcodeLength];

            while (true)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    Console.Write(passcodeIndex);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isCorrectPassword = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isCorrectPassword = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }

                if (isCorrectPassword)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}
