namespace _01_ReverseString
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var inputString = Console.ReadLine();
                var strBuilder = new StringBuilder();

                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    strBuilder.Append(inputString[i]);
                }

                Console.WriteLine(strBuilder.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Input string was in wrong format.");
            }
        }
    }
}
