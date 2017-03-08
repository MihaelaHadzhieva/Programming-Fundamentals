using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            var diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int j = 0; j < numbers.Length; j ++)
            {
                for (int i = j+1; i < numbers.Length; i++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == diff)
                    {
                        count++;
                    }
                }
            }         
                Console.WriteLine(count);          
        }
    }
}
