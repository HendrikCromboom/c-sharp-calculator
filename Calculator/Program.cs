using System;
using Calculator.calc;

namespace Calculator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What kind of calculation do you want to do? +,-,*,/");
            var outputOne = Console.ReadLine();
            var opp = outputOne;
            Console.WriteLine("What is the first number?");
            var outputTwo = Console.ReadLine();
            var numberOne = int.Parse(outputTwo);
            Console.WriteLine("What is the second number?");
            var outputThree = Console.ReadLine();
            var numberTwo = int.Parse(outputThree);
            var output = calc.Calculator.Calculate(opp, numberOne, numberTwo);
            Console.WriteLine("The result is "+ output);

        }
    }
}