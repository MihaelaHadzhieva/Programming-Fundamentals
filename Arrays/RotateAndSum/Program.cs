using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int[] arrOfNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arrOfNums[i] = int.Parse(numbers[i]);
            }
            int rotation = int.Parse(Console.ReadLine());
            int[] sumAray = new int[numbers.Length];
            for (int i = 0; i < rotation; i++)
            {
                int lastNumber = arrOfNums[numbers.Length - 1];

                for (int j = arrOfNums.Length - 1; j > 0; j--)
                {
                    arrOfNums[j] = arrOfNums[j - 1];
                }
                arrOfNums[0] = lastNumber;

                for (int j = 0; j < numbers.Length; j++)
                {
                    sumAray[j] += arrOfNums[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumAray));

        }

    }
}
}
