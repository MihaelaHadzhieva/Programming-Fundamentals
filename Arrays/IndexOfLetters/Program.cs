using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {

            var text = Console.ReadLine().ToCharArray();

            var alphabet = new List<char>(){ 'a', 'b', 'c',
                'd','e','f','g', 'h','i','j','k', 'l','m',
                'n','o','p','q','r','s','t','u','v','w','x','y','z' };

            for (int j = 0; j < text.Length; j++)
            {
                for (int i = 0; i < alphabet.Count; i++)
                {
                    if (text[j] == alphabet[i])
                    {
                        Console.WriteLine(text[j] + " -> " + i);
                    }
                }
            }
        }
    }
}
