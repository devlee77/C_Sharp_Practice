using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 0; i < exponent; i++)
                result *= myInt;
            return result;
        }

        public static string Append(this string myString, string appendData)
        {
            return myString + appendData;
        }
    }

    
}
