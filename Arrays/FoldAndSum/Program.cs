using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
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
            int[] firstNumbers = new int[numbers.Length / 4];
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                firstNumbers[i] = arrOfNums[i];
            }
            firstNumbers = firstNumbers.Reverse().ToArray();
            int[] lastNumbers = new int[numbers.Length / 4];
            int countlastnum = 0;

            for (int i = numbers.Length - 1; i >= numbers.Length - (numbers.Length / 4); i--)
            {
                lastNumbers[countlastnum] = arrOfNums[i];
                countlastnum++;
            }
            int[] combined = firstNumbers.Concat(lastNumbers).ToArray();

            int count = 0;
            int countCombine = 0;
            int[] sumArray = new int[numbers.Length / 2];
            for (int i = numbers.Length / 4; i < numbers.Length - (numbers.Length / 4); i++)
            {
                
                    sumArray[count] = arrOfNums[i] + combined[countCombine];
                    count++;
                    countCombine++;
                
                
            }
            foreach (var item in sumArray)
            {
                Console.Write(item+" ");
            }
            
        }
    }
}
