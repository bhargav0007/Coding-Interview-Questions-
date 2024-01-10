using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class FindOccurance
    {
        // Input: arr[] = {1, 1, 2, 2, 2, 2, 3,},   x = 2
        // Output: 4 // x (or 2) occurs 4 times in arr[]
        // Input: arr[] = {1, 1, 2, 2, 2, 2, 3,},   x = 3
        // Output: 1 

        public string OccuranceCount(int[] elements, int y)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < elements.Length; i++)
            {
                {
                    if (result.ContainsKey(elements[i]))
                    {
                        int count = result[elements[i]];
                        result[elements[i]] = count + 1;
                    }
                    else
                    {
                        result.Add((int)elements[i], 1);
                    }
                }
            }

            var res = result.Where(x => x.Key == y).Select(x => x.Value);

            Console.ReadLine();

            return res.FirstOrDefault().ToString();
        }
    }
}
