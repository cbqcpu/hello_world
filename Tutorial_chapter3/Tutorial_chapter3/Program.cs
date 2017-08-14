using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            //example1
            /*
            Console.WriteLine("Please enter your name");
            int age = Convert.ToInt32(Console.ReadLine());
            while (age< 18 || age > 100)
            {
                Console.WriteLine("The age you entered is not allowed, please enter again");
                age = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("The age you entered is: {0}", age);
            Console.ReadLine();
            */

            //example2 foreach语句
            //foreach 语句类似python 中的for循环，可以遍历集合中的元素，如果用C的for 可能会发生溢出

            /*
            Console.WriteLine("Please enter some thing and press enter to start");
            string str = Console.ReadLine();
            Console.WriteLine("You entered is:");
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
            */

            int[] array1 = new int[10]; //创建数组
            int[] array2 = new int[3] { 13, 23, 33 };
            double[] prices = new double[4] {1.2, 3.4, 5.6, 7.8 };
            char[] cs = new char[] { 'a', 'b', 'c', 'd' };
            object[] objs = { array1, array2, prices, cs };
            Console.WriteLine(array2[2]);
            Console.WriteLine(objs[1]);

            Console.WriteLine("\"prices\" 数组中");
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("第{0}个元素是: {1}", i+1, prices[i]);
            }

            Console.WriteLine("用 foreach遍历");
            foreach (double d in prices)
            {
                Console.WriteLine(d);
            }

            //二维数组
            int[,] d_2_array1 = new int[3, 3] { {1, 2, 3 }, {4, 5, 6 }, {7, 8, 9 } };
            Console.WriteLine("\n二维数组[2,1]");
            Console.WriteLine(d_2_array1[2,1]);

            Console.ReadLine();
        }
    }
}
