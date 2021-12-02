using System;
using static System.Console;
using Inheritance;

namespace ConsoleApp_day2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = (MyClass)source.Clone();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }*/

            //=====================================================================
            //this 파트
            /*ThisClass myThis = new ThisClass();

            myThis.PrintFields();
            Console.WriteLine();

            ThisClass b = new ThisClass(1);
            b.PrintFields();
            Console.WriteLine();

            ThisClass c = new ThisClass(10, 20);
            c.PrintFields();*/

            //========================================================================
            //상속
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();

        }
    }
}