using CalculatorApp;
using System;
namespace CalculatorApp 
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2,3));
        }
    }

}
