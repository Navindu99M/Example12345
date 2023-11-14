using System;

namespace Application01
{
    class Program
    {
        static void Main(string[] args)
        {
            Summation objSum = new Summation();

            Console.WriteLine("Summation is " + objSum.GetSummation());

            Console.ReadKey();

        }
    }
}
