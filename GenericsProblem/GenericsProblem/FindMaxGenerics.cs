using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class FindMaxGenerics<T> where T : IComparable
    {
        public T first,second, third,fourth;
        public FindMaxGenerics(T first, T second, T third, T fourth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = fourth;
        }
        public T FindInMax()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 && first.CompareTo(fourth)>0)
            {
                Console.WriteLine("First Number is greater: " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 && second.CompareTo(fourth) > 0)
            {
                Console.WriteLine("Second Number is greater: " + second);
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 && third.CompareTo(fourth) > 0)
            {
                Console.WriteLine("Second Number is greater: " + third);
                return second;
            }
            else
            {
                Console.WriteLine("Third Number is greater: " + fourth);
                return fourth;
            }
           
        }
        public T MaxMethod()
        {
            T max = FindInMax();
            return max;
        }
    }
}
