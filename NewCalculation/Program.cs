﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 5;
            double add = Add(a, b);
            double product = Multiply(a, b);
            Console.WriteLine("sum={0}", add);
            Console.WriteLine("product={0}", product);
        }

        static double Add(double a,double b)
        {
            return a + b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }

    }
}
