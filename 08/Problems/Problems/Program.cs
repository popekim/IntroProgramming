using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            while (userInput != "끝")
            {
                Console.WriteLine("아무 글자나 입력하세요. 끝내려면 '끝'을 입력하세요.");
                userInput = Console.ReadLine();
                Console.WriteLine(userInput);
            }
        }
    }
}
