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
            Console.WriteLine("| 컴퓨터가 수비수가 되어 세자리 수를 하나 골랐습니다. |");
            Console.WriteLine("| 각 숫자는 0~9 중에 하나며 중복되는 숫자는 없습니다. |");
            Console.WriteLine("| 모든 숫자와 위치를 맞추면 승리합니다.               |");
            Console.WriteLine("| 숫자와 순서가 둘다 맞으면 스트라이크                |");
            Console.WriteLine("| 숫자만 맞고 순서가 틀리면 볼입니다.                 |");
            Console.WriteLine("| 숫자가 틀리면 아웃입니다.                           |");
            Console.WriteLine("+-----------------------------------------------------+");

            Console.WriteLine("> 수비수가 고른 숫자");
            int[] numbers = { 3, 1, 9 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            int[] guesses = new int[3];

            while (true)
            {
                Console.WriteLine("> 첫번째 숫자를 입력하세요.");
                guesses[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("> 두번째 숫자를 입력하세요.");
                guesses[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("> 세번째 숫자를 입력하세요.");
                guesses[2] = int.Parse(Console.ReadLine());

                Console.WriteLine("> 공격수가 고른 숫자");
                Console.WriteLine(guesses[0]);
                Console.WriteLine(guesses[1]);
                Console.WriteLine(guesses[2]);

                if (guesses[0] == guesses[1] || guesses[0] == guesses[2] || guesses[1] == guesses[2])
                {
                    Console.WriteLine("같은 숫자를 입력하면 안됩니다.");
                    continue;
                }

                int strikeCount = 0;
                int ballCount = 0;

                if (guesses[0] == numbers[0])
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guesses[0] == numbers[1] || guesses[0] == numbers[2])
                {
                    ballCount = ballCount + 1;
                }

                if (guesses[1] == numbers[1])
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guesses[1] == numbers[0] || guesses[1] == numbers[2])
                {
                    ballCount = ballCount + 1;
                }

                if (guesses[2] == numbers[2])
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guesses[2] == numbers[0] || guesses[2] == numbers[1])
                {
                    ballCount = ballCount + 1;
                }

                Console.Write("스트라이크: ");
                Console.WriteLine(strikeCount);
                Console.Write("볼: ");
                Console.WriteLine(ballCount);
                Console.Write("아웃: ");
                Console.WriteLine(3 - strikeCount - ballCount);

                if (guesses[0] == numbers[0] && guesses[1] == numbers[1] && guesses[2] == numbers[2])
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}
