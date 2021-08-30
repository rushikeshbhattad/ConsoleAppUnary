using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnary
{
    class Unary_Operators
    {
        static void Main()
        {
            int x = 10;
            int result;

            Console.WriteLine("x is " + x);
            result = x++;
            Console.WriteLine("Post increment of x is " + x);

            Console.WriteLine("x is " + x);
            result = x--;
            Console.WriteLine("Post decrement of x is " + x);

            Console.WriteLine("x is " + x);
            result = ++x;
            Console.WriteLine("Pre increment of x is " + x);

            Console.WriteLine("x is " + x);
            result = --x;
            Console.WriteLine("Pre decrement of x is " + x);
            Console.ReadKey();
        }
    }
}
