using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Sorting
    {
        public int[] SortElements(int[] elements)
        {
            int temp = 0;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] > elements[j])
                    {
                        temp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = temp;
                    }

                }
            }
            return elements;
        }
    }
}
