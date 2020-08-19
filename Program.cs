using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
           var calculator = new Calculator();
          var result = calculator.Add(1,2);
          System.Console.WriteLine(result);
        }
    }
}
