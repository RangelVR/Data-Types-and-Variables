using System;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= countOfNumbers; i++)
            {
                decimal inputNum = decimal.Parse(Console.ReadLine());
                sum += inputNum;

            }
            Console.WriteLine(sum);
        }
    }
}
