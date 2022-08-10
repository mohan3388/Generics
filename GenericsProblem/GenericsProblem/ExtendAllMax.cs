using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class ExtendAllMax
    {
        public int FindMax(int first, int second, int third, int fourth)
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 && first.CompareTo(fourth) > 0)
            {
                Console.WriteLine("First Number is Greater " + first);
                return first;

            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 && second.CompareTo(fourth) > 0)
            {
                Console.WriteLine("Second Number is Greater " + second);
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 && third.CompareTo(fourth) > 0)
            {
                Console.WriteLine("third Number is greater: " + third);
                return second;
            }
            else
            {
                Console.WriteLine("fourth Number is greater: " + fourth);
                return fourth;
            }
        }

        public float MaxInFloat(float first, float second, float third, float fourth)
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 && first.CompareTo(fourth) > 0)
            {
                Console.WriteLine("First Number is Greater " + first);
                return first;

            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 && second.CompareTo(fourth) > 0)
            {
                Console.WriteLine("Second Number is Greater " + second);
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 && third.CompareTo(fourth) > 0)
            {
                Console.WriteLine("third Number is greater: " + third);
                return second;
            }
            else
            {
                Console.WriteLine("fourth Number is greater: " + fourth);
                return fourth;
            }
        }

        public string MaxInString(string first, string second, string third, string fourth)
        {
            int length1 = first.Length;
            int length2 = second.Length;
            int length3 = third.Length;
            int length4 = fourth.Length;
            if (length1.CompareTo(length2) > 0 && length1.CompareTo(length3) > 0 && length1.CompareTo(length4) > 0)
            {
                Console.WriteLine("First String is Greater: " + first);
                return first;
            }
            if (length2.CompareTo(length1) > 0 && length2.CompareTo(length3) > 0 && length2.CompareTo(length4) > 0)
            {
                Console.WriteLine("Second string is Greater: " + second);
                return second;
            }
            if (length3.CompareTo(length1) > 0 && length3.CompareTo(length2) > 0 && length3.CompareTo(length4) > 0)
            {
                Console.WriteLine("third string is Greater: " + third);
                return third;
            }
            else
            {
                Console.Write("Greatest string is fourth: " + fourth);
                return fourth;
            }
        }
    }
}
