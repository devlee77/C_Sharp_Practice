using System;
using static System.Console;

namespace Hello
{
    public class Program
    {
        public static int plus(int a, int b)
        {
            Console.WriteLine("Input : {0}, {1}", a, b);
            int result = a + b;
            return result;
        }

        static void Main(string[] args)
        {
            int a = 10;
            ref int b = ref a;
            Console.WriteLine(b);
        }
    }
}
