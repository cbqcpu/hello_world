using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_chapter_5
{
    
    public class Student
    {
        public int age;
        private string vage;
        private string rage
        {
            get { return vage; }
            set
            {
                value = vage;
            }
        }

        public Student(int ages)
        {
            age = ages;
            if (age >= 6)
                { vage = "适龄"; }
            else
                { vage = "非适龄"; }

        }

        public void show()
        {
            Console.WriteLine(rage);
        }
        ~Student() { }
    }
    

    public class Person
    {
        private int age;
        private string name;

        public int Age
        {
            get
            {return age;}
            set
            {
                if (value < 0 || value > 100)
                {
                    throw (new ArgumentOutOfRangeException("AgeIntPropery", value, "年龄必须在0到100之间"));
                }
                age = value;
            }
        }

        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new tutorial_chapter_5.Person();
            person.Age = 10;
            person.Name = "cpu";
            Console.WriteLine("name is: {0}", person.Name);
            Console.WriteLine("age is: {0}", person.Age);

            Father ff = new Father();
            Child cc = new Child();
            ff.Print();
            cc.Print();
            cc.PPrint();
            Console.ReadLine();

        }
    }
    //创建一个父类Father
    public class Father
    {
        //初始化他的实例字段
        private string name = "张三";
        public void Print()
        {
            Console.WriteLine(name);

        }
        //调用基类构造函数
        public Father()
        {
            Console.WriteLine("基类构造函数被调用了");
        }
    }
    //创建一个子类Child
    public class Child : Father
    {
        //初始化它的实例字段
        private int Age = 3;
        public void PPrint()
        {
            Console.WriteLine(Age);

        }
        //调用子类构造函数
        public Child()
        {
            Console.WriteLine("子类构造函数被调用了");
        }
    }

}
