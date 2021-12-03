using System;
using IntegerExtension;
using MultiInterfaceInheritance;
using Abstract;

namespace ConsoleApp_day3
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //확장메소드 - IntegerExtension
            /*Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");

            string a = "My name is ";
            Console.WriteLine($"{a.Append("sungclee")}");*/

            //======================================================================
            //튜플
            /*// 명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // 명명된 튜플
            var b = (Name: "박상현", Age: 17);
            Console.WriteLine($"{b.Name}, {b.Age}");

            // 분해
            var (name, age) = b; // (var name, var age) = b;
            Console.WriteLine($"{name}, {age}");

            // 분해2
            var (name2, age2) = ("박문수", 34);
            Console.WriteLine($"{name2}, {age2}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");*/


            //======================================================================
            //인터페이스
           /* FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();*/

            //=======================================================================
            //
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();

        }
    }
}