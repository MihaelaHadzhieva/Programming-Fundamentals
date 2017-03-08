namespace _05.CompareCharArrays
{
    using System;

    public class CompareCharArrays
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var secondLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Math.Min(firstLine.Length, secondLine.Length); i++)
            {
                if (!firstLine[i].Equals(secondLine[i]))
                {
                    if (firstLine[i].CompareTo(secondLine[i]) < 0)
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        return;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        return;
                    }
                }
            }

            if (secondLine.Length < firstLine.Length)
            {
                Console.WriteLine(string.Join("", secondLine));
                Console.WriteLine(string.Join("", firstLine));
            }
            else
            {
                Console.WriteLine(string.Join("", firstLine));
                Console.WriteLine(string.Join("", secondLine));
            }
        }
    }
}
