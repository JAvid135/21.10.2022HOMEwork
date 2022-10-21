using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Service
{
    public interface ICalculation
    
    {
        void Calc();
    }
    public class Calculation : ICalculation
    {
        public void Calc()
        {
            double a, b, result;
            char sym;
            Console.WriteLine("1ci reqemi daxil ele: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operatoru daxil ele: ");
            sym = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("3ci reqemi daxil ele: ");
            b = Convert.ToDouble(Console.ReadLine());

            switch (sym)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        result = a / b;
                    }
                    break;
            }
            
        }
    }
}
