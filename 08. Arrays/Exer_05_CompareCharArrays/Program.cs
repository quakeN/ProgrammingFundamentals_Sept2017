using System;
using System.Linq;

namespace Exer_05_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var shorterArray = Math.Min(firstArray.Length, secondArray.Length);
            bool equal = false;


            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    equal = false;
                }
                else
                {
                    equal = true;
                }
            }

            if (equal)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else if (!equal)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
            else if (firstArray.Length == secondArray.Length && equal == true)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
        }
    }
}
