
namespace MaxSequnceOfEqualElements
{
    using System;
    using System.Linq;
 
    class MaxSequnceOfEqualElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int maxLength = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentLength = 1;

                for (int j = i+1; j < numbers.Length; j++)
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
                if (currentLength>maxLength)
                {
                    maxLength = currentLength;
                    index = i;
                }               
            }
            for (int i = index; i < index+maxLength; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
