using System;

namespace StudentList_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];

            for (int studentNumber = 0; studentNumber < studentCount; studentNumber++)
            {
                Console.Write(studentNumber);
                Console.WriteLine("번째 학생의 정보를 입력할 차례입니다.");

                Console.WriteLine("나이를 입력하세요.");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[studentNumber] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("입력된 학생정보를 출력할 차례입니다.");

            for (int studentNumber = 0; studentNumber < studentCount; studentNumber++)
            {
                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentNumber]);
                Console.Write("나이: ");
                Console.WriteLine(ages[studentNumber]);
                Console.Write("키: ");
                Console.WriteLine(heights[studentNumber]);
            }
        }
    }
}