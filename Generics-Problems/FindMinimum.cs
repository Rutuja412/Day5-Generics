using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problems
{
    internal class FindMinimum
    {
        public static int FindMinIntegerNumbar(int FirstValue,int SecondValue,int ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) < 0 && FirstValue.CompareTo(ThirdValue) < 0)
            {
                return FirstValue;
            }
            if (SecondValue.CompareTo(FirstValue) < 0 && SecondValue.CompareTo(ThirdValue) < 0)
            {
               return SecondValue;
            }
            if (SecondValue.CompareTo(FirstValue) < 0 && SecondValue.CompareTo(ThirdValue) < 0)
            {
                return ThirdValue;
            }
            throw new Exception("First ,second and third number are same");

        }
    }
}
