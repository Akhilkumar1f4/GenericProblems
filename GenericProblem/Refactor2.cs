using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProblem
{
    internal class TestClass<T> where T : IComparable
    {
        public T FirstValue, SecondValue, ThirdValue;

        public TestClass(T firstvalue, T secondvalue, T thirdvalue)
        {
            this.FirstValue = firstvalue;
            this.SecondValue = secondvalue;
            this.ThirdValue = thirdvalue;
        }
        public T Compare(T firstvalue, T secondvalue, T thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            return default;
        }
    }
}
