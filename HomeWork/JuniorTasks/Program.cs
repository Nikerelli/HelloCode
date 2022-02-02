using System;
using System.Linq;

namespace InternTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayLastDigit(323);
            DisplayPrelastDigit(323);
            DisplayMaxDigit(12);
            DisplayMultiplicity(12, 5);
            DisplaydThirdDigit(1203);
        }

        /// Task0
        public static int Sqr(int val)
        {
            return val * val;
        }

        // Task1
        public static bool IsSqr(int sqr, int target)
        {
            return sqr == Sqr(target);
        }

        // Task2
        public static void DisplayCompare(int left, int right)
        {
            Console.WriteLine($"Value {Math.Max(left, right)} more than {Math.Min(left, right)}");
        }

        // Task3
        public static void DisplayDayOfWeek(int val)
        {
            if(val < 0)
            {
                Console.WriteLine("No negative values, it's days of week, little bitch!");
                return;
            }

            Console.WriteLine((DayOfWeek)(val % 7));
        }

        // Task4
        public static int MaxFrom4(int val1, int val2, int val3, int val4)
        {
            var arr = new int[] { val1, val2, val3, val4 };
            return arr.Max();
        }

        // Task5
        // [TODO]
        public static int CalcFunc(int val1, int val2, int val3, int val4)
        {
            var arr = new int[] { val1, val2, val3, val4 };
            return arr.Max();
        }

        // Task6
        public static bool IsEven(int val)
        {
            return val % 2 == 0;
        }

        // Task7
        public static void DisplayFromNegativeNToN(int n)
        {
            for(int i = -Math.Abs(n); i <= Math.Abs(n); i++)
            {
                Console.Write(i);
            }
        }

        // Task8
        public static void DisplayEvens(int n)
        {
            if(n < 2)
            {
                return;
            }

            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i);
            }
        }

        // Task9
        public static void DisplayLastDigit(int n)
        {
            Console.WriteLine(n % 10);
        }

        // Task10
        public static void DisplayPrelastDigit(int n)
        {
            Console.WriteLine(n % 100 / 10);
        }

        // Task11
        public static void DisplayMaxDigit(int n)
        {
            Console.WriteLine(Math.Max(n % 10, n / 10));
        }

        // Task12
        public static void RemoveMidDigit(int n)
        {
            Console.WriteLine(n / 100 * 10 + n % 10);
        }

        // Task13
        public static void DisplayMultiplicity(int target, int divider)
        {
            Console.WriteLine(target % divider == 0 ? "Hell yeah" : target % divider);
        }

        // Task14
        public static void DisplaydThirdDigit(int value)
        {
            value /= 100;
            if(value == 0)
            {
                Console.WriteLine("Value has no third digit");
                return;
            }

            Console.WriteLine(value % 10);
        }
    }
}