using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_chapter_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rain rain = new Rain();
            Sun sun = new Sun();
            rain.Print();
            sun.Print();
            Console.ReadLine();

            Son son = new Son();
            son.Name();
            ((Father)son).Name();
            Console.ReadLine();
        }
    }

    public abstract class Wether
    {
        public virtual void Print()
        {
            Console.WriteLine("天气为：");
        }
    }

    public class Rain : Wether
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("雨");
        }

    }
    public class Sun : Wether
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("晴");
        }
    }
    //用new关键字隐藏基类成员
    public class Father
    {
        public void Name()
        {
            Console.WriteLine("爸爸叫大明");
        }
    }

    public class Son : Father
    {
        public new void Name()
        {
            Console.WriteLine("儿子叫小明");
        }
    }



}
