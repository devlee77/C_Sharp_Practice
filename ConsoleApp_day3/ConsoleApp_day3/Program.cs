using System;
using IntegerExtension;

namespace ConsoleApp_day3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //확장메소드 - IntegerExtension
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");

            string a = "My name is ";
            Console.WriteLine($"{a.Append("sungclee")}");
        }
    }
}