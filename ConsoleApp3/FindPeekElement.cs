
using System.Collections;

namespace ConsoleApp3
{
    public class FindPeekElement
    {
        // Case 1 :
        // Input: array[]= {5, 10, 20, 15}
        // Output: 20
        // Explanation: The element 20 has neighbors 10 and 15, both of them are less than 20.

        // Case 2 : 
        // Input: array[] = {10, 20, 15, 2, 23, 90, 67}
        // Output: 20 or 90
        // Explanation: The element 20 has neighbors 10 and 15, both of them are less than 20, similarly 90 has neighbors 23 and 67.        //Input: array[] = {10, 20, 15, 2, 23, 90, 67}
        // Output: 20 or 90


        public string FindElement(int[] element)
        {
            string result = null;
            for (int i = 0; i < element.Length - 2; i++)
            {
                int firstNumber = element[i];
                int secondNumber = element[i + 1];
                int thirdNumber = element[i + 2];

                if (firstNumber < secondNumber && secondNumber > thirdNumber)
                {
                    result = result +" "+ secondNumber;
                }
            }

            return result;
        }
    }
}
