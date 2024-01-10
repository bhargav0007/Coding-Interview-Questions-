using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Sort0s1s2s
    {
        // Input: {0, 1, 2, 0, 1, 2}
        // Output: {0, 0, 1, 1, 2, 2}

        // Input: {0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1}
        // Output: {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2}


        public void SortValues(int[] elements)
        {
            int temp = 0;
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[j] > elements[i])
                    {
                        temp = elements[j];
                        elements[i] = elements[j];
                        elements[j] = temp;
                    }
                }
            }

            foreach (var x in elements) 
            {
                Console.Write(x + " ");
            }

            Console.ReadLine();
        }
    }
}
