using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            double num = double.Parse(data);

            data = Console.ReadLine();
            double num2 = double.Parse(data);

            Console.WriteLine("Sum: " + (num + num2));
            Console.WriteLine("Difference: " + (num - num2));
            Console.WriteLine("Product: " + (num * num2));
            
            if (num2 == 0)
            {
                Console.WriteLine("Modulo: " + (num % num2));
                Console.WriteLine("Cannot divide by zero!";
            }
            else
            {
                Console.WriteLine("Division: " + (num / num2));
            }
               

            Console.ReadLine();
        
        }
    }
}
