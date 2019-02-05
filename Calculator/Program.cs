using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
           calculator calc = new calculator();

           

            Console.WriteLine(calc.Add(5,1));
            Console.WriteLine(calc.Subtract(5, 4));
            Console.WriteLine(calc.Multiply(5, 2));
            Console.WriteLine(calc.Power(6, 1));
            Console.WriteLine(calc.Add(5, 10));
            Console.WriteLine(calc.Add(12, 1));
        }
    }
}
