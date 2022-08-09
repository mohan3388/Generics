using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class MaxNumber
    {
        public int FindMax(int first, int second, int third)
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is Greater " + first);
                return first;

            }
            if (second.CompareTo(first) >= 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is Greater "+second);
                return second;
            }
            else
            {
                Console.Write("Greatest Number is third "+third);
                return third;
            }
        }
        public float MaxFloat(float first, float second, float third)
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Number is Greater " + first);
                return first;

            }
            if (second.CompareTo(first) >= 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Number is Greater " + second);
                return second;
            }
            else
            {
                Console.Write("Greatest Number is third " + third);
                return third;
            }
        }
        public string MaxString(string first, string second, string third)
        {
            int length1 = first.Length;
            int length2 = second.Length;
            int length3 = third.Length;

            if (length1.CompareTo(length2) > 0 && length1.CompareTo(length3) > 0)
            {
                Console.WriteLine("First String is Greater: "+first);
                return first;
            }
            if (length2.CompareTo(length1) >= 0 && length2.CompareTo(length3) > 0)
            {
                Console.WriteLine("Second string is Greater: "+second);
                return second;
            }
            else
            {
                Console.Write("Greatest string is third: "+third);
                return third;
            }
        }
    }
}
