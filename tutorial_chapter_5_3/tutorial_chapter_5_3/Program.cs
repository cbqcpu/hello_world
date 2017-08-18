using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_chapter_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            Show shownum = new Show();
            Console.WriteLine("num1 = {0}", num1);
            Console.WriteLine("执行shownum中的Number1方法{0}", shownum.Numbers1(num1));
            Console.WriteLine("按值传递后 num1 = {0}", num1);
            Console.WriteLine("num2 = {0}", num2);
            Console.WriteLine("执行shownum中的Number2方法{0}", shownum.Numbers2(ref num2));
            Console.WriteLine("引用传递后 num2 = {0}", num2);

            Stashow.writeshow();
            Unstashow.writeshow();
            Unstashow unstashow = new Unstashow();
            unstashow.writeshow2();

            Console.ReadLine();
        }
    }

    //参数传递
    class Show
    {
        public int Numbers1(int number)
        {
            number = number * 2;
            return number;
        }

        public int Numbers2(ref int number)
        {
            number = number * 2;
            return number;
        }
    }

    //静态方法与静态类
    public static class Stashow
    {
        public static void writeshow()
        {
            Console.WriteLine("静态类中的静态方法被调用了");

        }
    }

    public class Unstashow
    {
        public static void writeshow()
        {
            Console.WriteLine("非静态类中的静态方法被调用了");

        }

        public void writeshow2()
        {
            Console.WriteLine("非静态类中的非静态方法被调用了");
        }
    }

    

}
