
namespace ConsoleApp3
{
    internal class ReverseArray
    {
        public int[] ReverseArrayValues(int[] elements)
        { 
            List<int> result = new List<int>();
            for (int i = elements.Length - 1; i >= 0; i--) 
            {
                result.Add (elements[i]);
            }
            return result.ToArray();
        }
    }
}
