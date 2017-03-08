using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SievOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> primeNums = new List<int>();
            for (int i = 0; i <=num; i++)
            {
                for (int j = 2; j <= num; j++)
                {
                    if (j >i)
                    {
                        break;
                    }
                    else if (i == 0 || i == 1)
                    {
                        break;
                    }
                    else if (i % j == 0 && i != j)
                    {
                        break;
                    }
                    else if (i == j)
                    {
                        primeNums.Add(i);
                    }
                }               
            }
            foreach (var item in primeNums)
            {
                Console.Write(item + " ");
            }
        }
    }
}
