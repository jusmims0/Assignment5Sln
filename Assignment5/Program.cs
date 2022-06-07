using System;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] totalNumber = { -1, 2, 4, 6, 9 };
            int positveNumbers = 0;
            int negativeNumbers = 0;
            for (int i = 0; i < totalNumber.Length; i++)
            {
                if (totalNumber[i] < 0)
                {
                    negativeNumbers++;
                }
                else
                {
                    positveNumbers++;
                }
            }
            Console.WriteLine($"postive numbers:{positveNumbers}");
            Console.WriteLine($"negative numbers:{negativeNumbers}");


        }
    }
}
