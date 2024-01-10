using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CombineArrays
    {
        public void CombineTwoArrays(int[] array1, int[] array2)
        {
            List<int> union = new();

            union.AddRange(array1);
            union.AddRange(array2);


            List<int> res = new();

            var s = union.GroupBy(x => x).Where(x => x.Count() >= 1).Select(x => x.Key);

            foreach (int i in s)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
