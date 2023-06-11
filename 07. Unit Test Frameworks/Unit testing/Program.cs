using System;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer in decimal: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter the new base (2 to 20): ");
            int newBase = int.Parse(Console.ReadLine());

            string convertedNum = ConvertToBase(num, newBase);
            Console.WriteLine($"The number {num} in base {newBase} is {convertedNum}.");

            Console.Write("Enter a string to analyze: ");
            string str = Console.ReadLine();

            int maxUnequal = CountMaxUnequal(str);
            Console.WriteLine($"The maximum number of unequal consecutive characters is {maxUnequal}.");

            int maxAlphaConsecutive = CountMaxConsecutive(str, CharType.Alpha);
            Console.WriteLine($"The maximum number of consecutive identical letters of the Latin alphabet is {maxAlphaConsecutive}.");

            int maxDigitConsecutive = CountMaxConsecutive(str, CharType.Digit);
            Console.WriteLine($"The maximum number of consecutive identical digits is {maxDigitConsecutive}.");
        }

        public static string ConvertToBase(int num, int newBase)
        {
            string digits = "0123456789ABCDEFGHIJ";
            string result = "";
            while (num > 0)
            {
                int digit = num % newBase;
                result = digits[digit] + result;
                num /= newBase;
            }
            return result;
        }

        public enum CharType { Alpha, Digit };

        public static int CountMaxConsecutive(string str, CharType charType)
        {
            char prevChar = '\0';
            int maxCount = 0;
            int count = 0;
            foreach (char c in str)
            {
                bool isMatch = false;
                switch (charType)
                {
                    case CharType.Alpha:
                        isMatch = Char.IsLetter(c) && c >= 'A' && c <= 'Z';
                        break;
                    case CharType.Digit:
                        isMatch = Char.IsDigit(c);
                        break;
                }

                if (isMatch)
                {
                    if (c == prevChar)
                    {
                        count++;
                    }
                    else
                    {
                        maxCount = Math.Max(maxCount, count);
                        count = 1;
                    }
                    prevChar = c;
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                    prevChar = '\0';
                }
            }
            return maxCount;
        }

        public static int CountMaxUnequal(string str)
        {
            char prevChar = '\0';
            int maxCount = 0;
            int count = 0;
            foreach (char c in str)
            {
                if (c == prevChar)
                {
                    count++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 1;
                    prevChar = c;
                }
            }
            return maxCount;
        }
    }
}