using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var list = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                    list[i] = numbers[i];               
            }
            list.Reverse();
            list.ForEach(Console.WriteLine);
                
        }
    }
}
