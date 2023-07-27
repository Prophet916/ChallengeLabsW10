using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChallengeLabsW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin pinVal");
            Console.WriteLine(pinVal("1234")); // true
            Console.WriteLine(pinVal("12345")); // false
            Console.WriteLine(pinVal("a234"));  // false
            Console.WriteLine(pinVal(""));      // false
            Console.WriteLine("End pinVal");
            Console.ReadKey();

            Console.WriteLine("Begin CountPosSumNeg");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] arr2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] arr3 = { 91, -4, 80, -73, -28 };
            int[] arr4 = { };

            Console.WriteLine(string.Join(", ", CountPosSumNeg(arr1))); // Output: 10, -65
            Console.WriteLine(string.Join(", ", CountPosSumNeg(arr2))); // Output: 7, -252
            Console.WriteLine(string.Join(", ", CountPosSumNeg(arr3))); // Output: 2, -105
            Console.WriteLine(string.Join(", ", CountPosSumNeg(arr4))); // Output: 
            Console.WriteLine("End CountPosSumNeg");
            Console.ReadKey();

            Console.WriteLine("Begin IndexOfCapitals");
            Console.WriteLine(string.Join(", ", IndexOfCapitals("eDaBiT"))); // Output: 1, 3, 5
            Console.WriteLine(string.Join(", ", IndexOfCapitals("eQuINoX"))); // Output: 1, 3, 4, 6
            Console.WriteLine(string.Join(", ", IndexOfCapitals("determine"))); // Output: 
            Console.WriteLine(string.Join(", ", IndexOfCapitals("STRIKE"))); // Output: 0, 1, 2, 3, 4, 5
            Console.WriteLine(string.Join(", ", IndexOfCapitals("sUn"))); // Output: 1
            Console.WriteLine("End IndexOfCapitals");
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

        }

        public static bool pinVal(string s)
        {
            string isVal = @"^(?:\d{4}|\d{6})$";

            return Regex.IsMatch(s, isVal);
        }

        public static int[] CountPosSumNeg(int[] arr)
        {
            int positiveCount = 0;
            int negativeSum = 0;

            foreach (int num in arr)
            {
                if (num > 0)
                {
                    positiveCount++;
                }
                else if (num < 0)
                {
                    negativeSum += num;
                }
            }

            return new int[] { positiveCount, negativeSum };
        }

        public static int[] IndexOfCapitals(string input)
        {
            List<int> capitalIndices = new List<int>();

            // Regular expression pattern to find capital letters
            string pattern = @"[A-Z]";

            // Use Regex.Matches to find all capital letter matches in the input string
            var matches = Regex.Matches(input, pattern);

            // Add the indices of capital letters to the capitalIndices list
            foreach (Match match in matches)
            {
                capitalIndices.Add(match.Index);
            }

            return capitalIndices.ToArray();
        }
    }
}
