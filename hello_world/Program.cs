using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            /* my first C# program */
            Console.WriteLine("Hello World!");

            char testType = new char();
            if (testType.GetType().IsValueType)
            {
                Console.WriteLine("{0} is value type.", testType.ToString());
            }
            Console.ReadKey();
        }
    }
}
