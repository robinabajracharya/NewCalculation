using System;
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

            double division = Divide(a, b);
            double difference = Sub(a, b);
            Console.WriteLine("difference={0}", difference);

            
            Console.WriteLine("sum={0}", add);
            Console.WriteLine("division={0}", division);
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
        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }


    }
}
