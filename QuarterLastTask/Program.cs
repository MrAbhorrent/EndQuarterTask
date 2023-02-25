using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuarterLastTask
{
    class Program
    {
        private static int screenWidth = 119;
        private static String divider = new String('=', screenWidth);
        private const int MAX_LENGTH = 3;

        private static String[] filterArrayLength( String[] inputArray, int _LengthMax )
        {
            String[] tempArray = new String[inputArray.Length];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].ToString().Length <= _LengthMax)
                {
                    tempArray[j++] = inputArray[i];
                }
            }
            String[] resultArray = tempArray.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            return resultArray;
        }

        private static void PrintArray<T>( T[] _array )
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.Write("[");
            for (int i = 0; i < _array.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (_array[i] is double)
                {
                    Console.Write("{0:F2}", _array[i]);
                }
                else
                {
                    Console.Write("{0}", _array[i]);
                }
                Console.ForegroundColor = color;
                if (i != _array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
            Console.ForegroundColor = color;
        }

        static void Main( string[] args )
        {
            String[] testArray1 = { "hello", "2", "world", ":-)" };
            String[] testArray2 = { "1234", "1567", "-2", "computer science" };
            String[] testArray3 = { "Russia", "Denmark", "Kazan" };

            String[] outputArray1 = filterArrayLength(testArray1, MAX_LENGTH);
            String[] outputArray2 = filterArrayLength(testArray2, MAX_LENGTH);
            String[] outputArray3 = filterArrayLength(testArray3, MAX_LENGTH);

            PrintArray(testArray1);
            Console.Write(" -> ");
            PrintArray(outputArray1);
            Console.WriteLine();
            PrintArray(testArray2);
            Console.Write(" -> ");
            PrintArray(outputArray2);
            Console.WriteLine();
            PrintArray(testArray3);
            Console.Write(" -> ");
            PrintArray(outputArray3);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
