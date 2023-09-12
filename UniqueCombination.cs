using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlashX.Net
{
    public class UniqueCombination
    {
        public static List<List<string>> Generate(string[] arr)
        {
            List<List<string>> combinations = new List<List<string>>();
            int length = arr.Length;

            for (int i = 0; i < (1 << length); ++i)
            {
                List<string> combination = new List<string>();
                int count;
                for (count = 0; count < length; ++count)
                {
                    if ((i & 1 << count) > 0)
                        combination.Add(arr[count]);
                }

                if (count > 0 && combination.Count > 0)
                    combinations.Add(combination);
            }

            return combinations;
        }
    }
}
