﻿namespace Exer_08_LettersChangeNums
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputArray = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal sum = 0m;

            foreach (string word in inputArray)
            {
                string numToString = new string(word
                    .Skip(1).ToArray());

                numToString = numToString
                    .Remove(numToString.Length - 1);

                char firstLetter = word[0];
                char secondLetter = word[word.Length - 1];
                decimal number = decimal.Parse(numToString);

                int firstLetterPos = firstLetter % 32;
                int secondLetterPos = secondLetter % 32;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= firstLetterPos;
                }
                else
                {
                    number *= firstLetterPos;
                }

                if (secondLetter >= 65 && secondLetter <= 90)
                {
                    number -= secondLetterPos;
                }
                else
                {
                    number += secondLetterPos;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
