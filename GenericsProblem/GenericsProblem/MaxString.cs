using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class MaxString
    {
        public string MaxInString(string first, string second, string third)
        {
            int length1 = first.Length;
            int length2 = second.Length;
            int length3 = third.Length;

            if (length1.CompareTo(length2) > 0 && length1.CompareTo(length3) > 0)
            {
                Console.WriteLine("First String is Greater: " + first);
                return first;
            }
            if (length2.CompareTo(length1) > 0 && length2.CompareTo(length3) > 0)
            {
                Console.WriteLine("Second string is Greater: " + second);
                return second;
            }
            else
            {
                Console.Write("Greatest string is third: " + third);
                return third;
            }
        }
    }
}
