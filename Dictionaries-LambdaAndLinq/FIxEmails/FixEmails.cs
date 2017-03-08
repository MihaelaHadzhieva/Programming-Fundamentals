
namespace FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();

            string line = Console.ReadLine();
            var count = 0;
            string name = string.Empty;
            string mail = string.Empty;
            while (line != "stop")
            {
                var input = line.Split(new string[] { "\r\n" },
                           StringSplitOptions.RemoveEmptyEntries);
                if (count % 2 == 0)
                {
                    name = input[0];
                    if (!emails.ContainsKey(name))
                    {
                        emails[name] = string.Empty;
                    }
                }
                else
                {
                    mail = input[0];
                    bool result = true;
                    var proverka = new List<char>();
                    var preLastLetter = proverka.Count - 2;
                    var lastLetter = proverka.Count - 1;
                    foreach (var symbol in mail)
                    {
                        proverka.Add(symbol);
                    }
                    for (int i = proverka.Count - 2; i < proverka.Count; i++)
                    {
                        if (proverka[i] == 117)
                        {
                            if (proverka[i + 1] == 115
                                || proverka[i + 1] == 107)
                            {
                                result = false;
                                break;
                            }
                        }
                        else
                        {
                            result = true;
                            break;
                        }
                    }

                    if (result)
                    {
                        emails[name] = mail;
                    }
                    else
                    {
                        emails.Remove(name);
                     }
                }

                count++;
                line = Console.ReadLine();
            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
