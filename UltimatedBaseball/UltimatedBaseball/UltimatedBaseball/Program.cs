using System;

namespace UltimatedBaseball
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
            int number1 = 3;
            int number2 = 1;
            int number3 = 9;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.WriteLine("> 수비수가 다시 고른 숫자");
            number1 = 8;
            number2 = 2;
            number3 = 0;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }
    }
}
