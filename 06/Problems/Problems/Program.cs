using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("등수를 입력하세요.");
            int rank = int.Parse(Console.ReadLine());
            Console.WriteLine("점수를 입력하세요.");
            int score = int.Parse(Console.ReadLine());
            if (rank < 10)
            {
                Console.WriteLine("A입니다.");
            }
            if (score > 90)
            {
                Console.WriteLine("A입니다.");
            }
        }
    }
}
