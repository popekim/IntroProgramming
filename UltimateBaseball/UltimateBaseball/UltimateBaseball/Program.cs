using System;

namespace UltimateBaseball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("|                궁극의 숫자 야구 게임                |");
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("| 컴퓨터가 수비수가 되어 세 자리 수를 하나 골랐습니다.|");
            Console.WriteLine("| 각 숫자는 0~9 중에 하나며 중복되는 숫자는 없습니다. |");
            Console.WriteLine("| 모든 숫자와 위치를 맞추면 승리합니다.               |");
            Console.WriteLine("| 숫자와 순서가 둘 다 맞으면 스트라이크입니다.        |");
            Console.WriteLine("| 숫자만 맞고 순서가 틀리면 볼입니다.                 |");
            Console.WriteLine("| 숫자가 틀리면 아웃입니다.                           |");
            Console.WriteLine("+-----------------------------------------------------+");

            Random random = new Random();

            int[] numbers = new int[3];
            int index = 0;
            while (index < 3)
            {
                numbers[index] = random.Next(0, 10);

                bool isSameNumer = false;
                for (int j = 0; j < index; j++)
                {
                    if (numbers[index] == numbers[j])
                    {
                        isSameNumer = true;
                        break;
                    }
                }

                if (!isSameNumer)
                {
                    index++;
                }
            }

            int[] guesses = new int[3];
            string[] inputMessages = { "> 첫 번째 숫자를 입력하세요.", "> 두 번째 숫자를 입력하세요.", "> 세 번째 숫자를 입력하세요." };

            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(inputMessages[i]);
                    guesses[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("> 공격수가 고른 숫자");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(guesses[i]);
                }

                if (guesses[0] == guesses[1] || guesses[0] == guesses[2] || guesses[1] == guesses[2])
                {
                    Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
                    continue;
                }

                int strikeCount = 0;
                int ballCount = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (guesses[i] == numbers[j])
                        {
                            if (i == j)
                            {
                                strikeCount++;
                            }
                            else
                            {
                                ballCount++;
                            }
                        }
                    }
                }

                Console.Write("스트라이크 ");
                Console.WriteLine(strikeCount);
                Console.Write("볼 ");
                Console.WriteLine(ballCount);
                Console.Write("아웃 ");
                Console.WriteLine(3 - strikeCount - ballCount);

                if (strikeCount == 3)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}