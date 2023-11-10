using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_04_Generics
{
    public class Equality
    {
        public static bool Test(int num1, int num2)
        {
            return num1 == num2;
        }

        public static bool Test(char ch1, char ch2)
        {
            return ch1 == ch2;
        }

        public static bool Test(string str1, string str2)
        {
            return str1 == str2;
        }

        public static bool TestObj(Object val1, Object val2)
        {
            // return val1 == val2 (this is wrong)
            return val1.Equals(val2);

        }

        public static bool TestGeneric<Thing>(Thing val1, Thing val2)
        {
            return val1.Equals(val2);
        }
    }
}
