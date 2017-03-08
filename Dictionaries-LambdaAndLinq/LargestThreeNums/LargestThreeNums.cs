
namespace LargestThreeNums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestThreeNums
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
