using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartingValue = 2137;
            PartOne i = new PartOne();
            int result = i.Calcumulator(StartingValue);

            Console.WriteLine(StartingValue + " = " + result);
        }
    }
}
