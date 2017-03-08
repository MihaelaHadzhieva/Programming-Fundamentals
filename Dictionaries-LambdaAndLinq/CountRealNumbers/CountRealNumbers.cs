
namespace CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var countInDic = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!countInDic.ContainsKey(number))
                {
                    countInDic[number] = 0;
                }
                countInDic[number]++;
            }

            foreach (var item in countInDic)
            {
                Console.Write(item.Key+" -> ");
                Console.Write(item.Value);
                Console.WriteLine();
            }
        }
    }
}
