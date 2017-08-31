using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_chapter7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Students stu1 = new Students();
            stu1.Name = "aa";
            stu1.Sex = "女";
            stu1.Hight = 1.58;
            stu1.show();
            Console.ReadLine();

        }
    }

    struct Students
    {
        public int ID;
        public string Name;
        public string Sex;
        public double Hight;
        public string Phone;
        public Students(int ID, string Name, string Sex, double Hight, string Phone)
        {
            this.ID = ID;
            this.Name = Name;
            this.Sex = Sex;
            this.Hight = Hight;
            this.Phone = Phone;

        }

        public void show()
        {
            Console.WriteLine("学生姓名：{0} 性别：{1} 身高：{2}",this.Name, this.Sex, this.Hight);
        }
    }

    

}
