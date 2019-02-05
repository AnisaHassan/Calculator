using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class calculator
    //jaja  jjjjj
    {
        public double a { get; set; }
        public double b { get; set; }

        public double Divident { get; set; }

        public double Divisor { get; set; }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);

        }

        public double Divide(double Divident, double Divisor)
        {
            return Divident / Divisor;
        }
        //Det er bar en prøve...

        public double Accumulator { get; private set; }
    
    }
}
