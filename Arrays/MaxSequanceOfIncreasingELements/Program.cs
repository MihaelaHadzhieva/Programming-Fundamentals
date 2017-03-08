
namespace MaxSequnceOfIncreasingElements
{
    using System;
    using System.Linq;

    class MaxSequnceOfIncreasingElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

            int maxLength = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentLength = 1;

                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] < numbers[j+1])
                    {
                        currentLength++;

                    }
                    else
                    {
                        break;
                    }
                  
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    index = i;
                }

            }

            for (int i = index; i < index + maxLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
