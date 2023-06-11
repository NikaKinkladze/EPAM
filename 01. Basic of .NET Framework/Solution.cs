using System;

namespace Solutions
{
    public class Solution
    {
        public static void mainmethod()
        {
            Console.Write("Enter a decimal number: ");
            string decimalString = Console.ReadLine();

            Console.Write("Enter the base to convert to (between 2 and 20): ");
            string baseString = Console.ReadLine();

            int num, baseNum;

            if (!int.TryParse(decimalString, out num))
            {
                Console.WriteLine("Error: Input must be an integer");
                return;
            }

            if (!int.TryParse(baseString, out baseNum) || baseNum < 2 || baseNum > 20)
            {
                Console.WriteLine("Error: Base must be an integer between 2 and 20");
                return;
            }

            string result = DecimalToBase(num, baseNum);

            Console.WriteLine("Result: " + result);
        }

        static string DecimalToBase(int num, int baseNum)
        {
            string digits = "0123456789ABCDEFGHIJ";
            string result = "";

            while (num > 0)
            {
                int digit = num % baseNum;
                result = digits[digit] + result;
                num /= baseNum;
            }

            return result;
        }
    }
}