

namespace ConsoleApp3
{
    internal class FindNthHighest
    {
        public string FindNthHighestElement(int[] elements, int n)
        {
            // Inbuild Function To get sort 
            // Array.Sort(elements);

            Sorting sorting = new Sorting();

            int[] ints = sorting.SortElements(elements);
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            string nthHighestValue = ints[ints.Length - n].ToString();

            return nthHighestValue;

        }
    }
}
