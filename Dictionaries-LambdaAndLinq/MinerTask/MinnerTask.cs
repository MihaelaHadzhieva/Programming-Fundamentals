
namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            var minner = new Dictionary<string, string>();

            string line = Console.ReadLine();
            int count = 0;
            string name = string.Empty;
            int prevNum = 0;
            int caseq= 0;
            string secondName = string.Empty;
            while (line!="stop")
            {
                var inputs = line.Split(new string[] { "\r\n" },
                           StringSplitOptions.RemoveEmptyEntries);
               
                if (count%2==0)
                {
                    if (!minner.ContainsKey(inputs[0]))
                    {
                        minner[inputs[0]] = string.Empty;
                        name = inputs[0];
                    }
                    else
                    {
                        prevNum = int.Parse(minner[inputs[0]]);
                        caseq++;
                        secondName = inputs[0];
                    }
                }
                else
                {
                    if (caseq != 0)
                    {
                        int current = prevNum +int.Parse( inputs[0]);
                        minner[secondName] =current.ToString();
                    }
                    else
                    {
                        minner[name] = inputs[0];
                    }
                }
                count++;
                line = Console.ReadLine();
            }
            foreach (var item in minner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
