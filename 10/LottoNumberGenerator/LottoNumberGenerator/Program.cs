using System;

namespace LottoNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lottoLength = 6;
            int[] lottoNumbers = new int[lottoLength];

            Random random = new Random();

            int lottoNumberIndex = 0;
            while (lottoNumberIndex < lottoLength)
            {
                lottoNumbers[lottoNumberIndex] = random.Next(1, 46);

                bool hasDuplicate = false;
                for (int i = 0; i < lottoNumberIndex; i++)
                {
                    if (lottoNumbers[lottoNumberIndex] == lottoNumbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (!hasDuplicate)
                {
                    lottoNumberIndex++;
                }
            }

            Console.Write("로또 번호: ");
            for (int i = 0; i < lottoLength; ++i)
            {
                Console.Write(lottoNumbers[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}