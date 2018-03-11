using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            bool parsed_a, parsed_b;
            do
            {
                Console.WriteLine("Enter value for 'a'");
                parsed_a = float.TryParse(Console.ReadLine(), out  a);
                if (!parsed_a)
                {
                    Console.WriteLine("Incorrect value for 'a'. Please enter new correct value of type float");
                }
            } while (parsed_a == false);
            do
            {
                Console.WriteLine("Enter value for 'b'");
                parsed_b = float.TryParse(Console.ReadLine(), out b);
                if (!parsed_b)
                {
                    Console.WriteLine("Incorrect value for 'b'. Please enter new correct value of type float");
                }
            } while (parsed_b == false);
            bool equal = Math.Abs(a - b) < 0.000001;
            if (equal)
                {
                Console.WriteLine("a equals b");
            }
            else if (a > b)
                {
                Console.WriteLine("a is greater than b");
            }
            else
                {
                Console.WriteLine("a is less than b");
            }
            Console.ReadLine();
        }
    }
}
