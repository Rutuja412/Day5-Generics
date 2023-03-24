using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problems
{
    internal class FindMinimumGenericClass <T> where T : IComparable
    {
        public T FirstValue, SecondValue, ThirdValue;
        public FindMinimumGenericClass(T FirstValue, T SecondValue, T ThirdValue)
        {
           this. FirstValue = FirstValue;
           this. SecondValue = SecondValue;
           this. ThirdValue = ThirdValue;
        }
        public static T FindMinimum(T FirstValue, T SecondValue, T ThirdValue)
        {
            if (FirstValue .CompareTo(SecondValue) < 0 && (FirstValue .CompareTo(ThirdValue)) < 0)
            {
                return FirstValue;
            }
            if (SecondValue.CompareTo(FirstValue) < 0 && (SecondValue.CompareTo(ThirdValue)) < 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(FirstValue) < 0 && (ThirdValue.CompareTo(SecondValue)) < 0)
            {
                return ThirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
