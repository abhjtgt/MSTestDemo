using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Demo!");
            // Calling the Sum method from the MathWorks class
            Console.WriteLine("2 + 3: " + MathWorks.Sum(2, 3));
            
            // Calling the Minus method from the MathWorks class
            Console.WriteLine("5 - 2: " + MathWorks.Minus(5, 2));
            
            // Calling the Multiple method from the MathWorks class
            Console.WriteLine("4 * 6: " + MathWorks.Multiple(4, 6));

            // Calling the Divide method from the MathWorks class
            Console.WriteLine("10 / 2: " + MathWorks.Divide(10, 2));
        }


    }
}
