﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        /// <summary>
        /// 输出字符串
        /// </summary>
        /// <param name="massage"></param>
        public void show_massage(string massage)
        {
            Console.WriteLine(massage);
        }

        static void Main(string[] args)
        {
            /* my first C# program and tutorial*/
            Console.WriteLine("Hello World!");

            char testType = new char();
            if (testType.GetType().IsValueType)
            {
                Console.WriteLine("{0} is value type.", testType.ToString());
            }
            int num1 = 15;
            int num2 = 45;
            int num = num1 * num2;
            Console.WriteLine("number1 {0}, number2 {1}, number1*number2 {2}", num1, num2, num);

            string result = string.Format("1+2={0}", 1 + 2); /* string.format 的用法*/
            Console.WriteLine(result);

            Console.WriteLine("abcd,\nefgh.");
            Console.WriteLine(@"abcd,\nefgh."); /*@的用法 */

            double dou = 15.1234567;
            float flo = (float)dou; /* 类型转换*/
            int intnum = (int)dou;
            Console.WriteLine("双精度浮点{0}, 单精度浮点{1}， 整形{2}", dou, flo, intnum);

            string num3 = "123.3464456"; /*Convert  的方法*/
            string num4 = "3878943.3423";
            string a = num3 + num4;
            Console.WriteLine(a);
            double b = Convert.ToDouble(num3) + Convert.ToDouble(num4);
            Console.WriteLine(b);

            int val = 100;
            object obj = val; //装箱
            Console.WriteLine("object = {0}", obj);
            int obj_num = (int)obj; //拆箱
            Console.WriteLine("object 拆箱后 = {0}", obj_num);

            float docname = 322343.13432F;
            string country = docname.GetType().Name; //变量类型
            Console.WriteLine(country);

            #region  折叠注释
            int ab = 1;
            Console.WriteLine(ab);
            #endregion


            Console.ReadKey();
        }
    }
}
