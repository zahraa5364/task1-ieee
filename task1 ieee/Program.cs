using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_ieee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number : ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number : ");
            float num2 = float.Parse(Console.ReadLine());

            float sum = num1 + num2;
            Console.WriteLine("the sum is : " + sum);

        }
    }
}
