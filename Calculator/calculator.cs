﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class calculator
 
    {
        public double a { get; set; }
        public double b { get; set; }

        public double Accumulator { get; private set; } 

        public double Divident { get; set; }

        public double Divisor { get; set; }


        public calculator()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            double result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double a, double b)
        {
            if (a < 0 && b % 1 > 0)
            {

                Console.WriteLine("Kan ikke lade sig gøre.");
                return 0;
            }
            if (a < 0 && b % 1 < 0)
            {

                Console.WriteLine("Kan ikke lade sig gøre.");
                return 0;
            }
            else
            {
                double result = Math.Pow(a, b);
                Accumulator = result;
                return result;
            }


        }

        public double Divide(double Divident, double Divisor)
        {

            if (Divisor == 0)
            {

                Console.WriteLine("Kan ikke lade sig gøre.");
                return 0;
            }
            else
            {
                return Divident / Divisor;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }


    }
}
