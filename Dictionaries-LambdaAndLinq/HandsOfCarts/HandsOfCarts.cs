
namespace HandsOfCarts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HandsOfCarts
    {
        public static void Main()
        {
            var players = new Dictionary<string, List<string>>();
            var cardPower = new Dictionary<string, int>();
            cardPower.Add("2", 2);
            cardPower.Add("3", 3);
            cardPower.Add("4", 4);
            cardPower.Add("5", 5);
            cardPower.Add("6", 6);
            cardPower.Add("7", 7);
            cardPower.Add("8", 8);
            cardPower.Add("9", 9);
            cardPower.Add("10", 10);
            cardPower.Add("J", 11);
            cardPower.Add("Q", 12);
            cardPower.Add("K", 13);
            cardPower.Add("A", 14);
            cardPower.Add("", 0);

            var type = new Dictionary<string, int>();
            type.Add("S", 4);
            type.Add("H", 3);
            type.Add("D", 2);
            type.Add("C", 1);
            type.Add("", 0);

            string line = Console.ReadLine();
            var cases = 0;
            var concatList = new List<string>();
            var secondName = string.Empty;
            var proverka = new List<string>();
            var name = string.Empty;
            while (line != "JOKER")
            {
                var input = line.Split(new string[] { "\r\n", " ", ":", "," },
                           StringSplitOptions.RemoveEmptyEntries).ToList();
                 name = input[0];
                if (!players.ContainsKey(name))
                {
                    List<string> list = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                    players.Add(input[0], list);                    
                }
                else
                {
                    List<string> list = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    concatList = players[input[0]].Concat(list).Distinct().ToList();
                    players[input[0]] = concatList;
                    cases++;
                }
                if (cases==0)
                {
                    for (int i = 1; i <= input.Count; i++)
                    {
                        if (i + 1 <= input.Count)
                        {
                            if (i + 1 == input.Count && input[i] == input[i - 1])
                            {
                                input.RemoveAt(i);

                            }
                            else if (input[i] == input[i + 1])
                            {
                                input.RemoveAt(i + 1);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= concatList.Count; i++)
                    {
                        if (i + 1 <=concatList.Count)
                        {
                            if (i + 1 == concatList.Count && concatList[i] == concatList[i - 1])
                            {
                                concatList.RemoveAt(i);

                            }
                            else if (input[i] == concatList[i + 1])
                            {
                                concatList.RemoveAt(i + 1);
                            }

                        }
                    }
                }
                if (cases==0)
                {
                    input.RemoveAt(0);
                }
                else
                {
                    concatList.RemoveAt(0);
                }
                foreach (var item in players[name])
                {
                    proverka.Add(item.ToString());
                }
                var sum = 0;
                var emergency = 0;
                for (int i = 0; i < proverka.Count; i += 2)
                {
                    var index = i;
                    var power = string.Empty;
                    var t = string.Empty;
                    if (emergency != 0)
                    {
                        index++;
                    }
                    if (index >= proverka.Count)
                    {
                        break;
                    }
                    if (proverka[index] == "1" && proverka[index + 1] == "0")
                    {
                        proverka[i] = "10";
                        proverka[i + 1] = proverka[i + 2];
                        emergency++;
                    }
                    if (proverka[index] != "0" || proverka[index + 1] != "0")
                    {
                        if (index + 1 == proverka.Count)
                        {
                            t = proverka[index];
                            var m = 1;
                            while (proverka[index - m] == "0")
                            {
                                m++;
                            }
                            power = proverka[index - m];
                        }
                        else
                        {
                            power = proverka[index];
                            t = proverka[index + 1];
                        }

                    }
                    sum += cardPower[power] * type[t];
                    players[name].Clear();
                    players[name].Add(sum.ToString());                                   
                }
                proverka.Clear();
                line = Console.ReadLine();
            }
            foreach (var item in players)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
