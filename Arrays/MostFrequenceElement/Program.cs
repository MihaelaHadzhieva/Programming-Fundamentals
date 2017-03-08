namespace MaxSequenceOfEqualNumbers
{
    using System;
    using System.Linq;

    class MaxSequenceOfEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxLength = 0;
            int index = 0;
            int startIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentLength = 1;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
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
