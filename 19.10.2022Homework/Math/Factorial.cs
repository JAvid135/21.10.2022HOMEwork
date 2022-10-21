using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    public class Factorial
    {
        public void Faktorial()
        {   int multiply = 1;
            Console.Write("Reqemi daxil ele : ");
            string num = Console.ReadLine();
            int num1 = int.Parse(num);
            if (num1 > 0)
            {
                for (int i = 1; i <= num1; i++)
                {
                    multiply *= i;
                }
                Console.Write("Bu reqemin faktoriali = ");
                Console.WriteLine(multiply);
            }else if(num1 == 0)
            {
                Console.WriteLine("Cavab 0di");
            }
            else
            {
                Console.WriteLine("Duzgun daxil eleyin");
            }
        }
    }
}
