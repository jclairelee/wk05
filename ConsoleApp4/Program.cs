using System;

namespace lab_wk05
{
   internal class Program
{
    static double calculate(double inputA, double inputB, double inputC)
    {
        double result = (inputA+inputB+inputC)/3;
        return result;
    }
    static void Main(string[] args)
    {
        int num1 = 50;
        int num2 = 20;
        int num3 = 40;
        double average = calculate(num1, num2, num3);
        Console.WriteLine($"the average is {average:F1}");
    }
}
}