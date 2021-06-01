using System;
using System.Collections.Generic;
using System.Linq;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int m = Convert.ToInt32(firstMultipleInput[0]);
            int n = Convert.ToInt32(firstMultipleInput[1]);

            List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();
            List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

            checkMagazine(magazine, note);

        }

        private static void checkMagazine(List<string> magazine, List<string> note)
        {

            string result = "Yes";

            Dictionary<string, int> dicMagazine = new Dictionary<string, int>();
            foreach (var item in magazine)
            {
                if (!dicMagazine.ContainsKey(item))
                    dicMagazine.Add(item, 1);
                else dicMagazine[item] += 1;
            }

            foreach (var item in note)
            {
                if (dicMagazine.ContainsKey(item))
                {
                    if (dicMagazine[item] > 0)
                    {
                        result = "Yes";
                        dicMagazine[item] -= 1;

                    }
                    else
                    {
                        result = "No";
                        break;
                    }
                }
                else
                {
                    result = "No";
                    break;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
