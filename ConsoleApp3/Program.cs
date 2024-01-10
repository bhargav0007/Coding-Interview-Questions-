
namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] elements = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            int[] elements2 = { 4, 5, 6, 78, 2, 34, 5, 0, 2, 1, 0 };

            CombineArrays peekElement = new CombineArrays();

            peekElement.CombineTwoArrays(elements, elements2);

            Console.WriteLine();
            //Console.WriteLine($"Find Occrance of the value {90} " + s);

            Console.ReadLine();


        }
    }
}
