using System;

namespace Calculator.calc
{
    public static class Calculator
    {
         public static int Calculate(string opp, int num1, int num2)
        { 
            var result = 0;
            switch (opp)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Something went wrong...");
                    break;
            }

            return result;
        }
    }
}