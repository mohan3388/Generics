using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class Refactor<T> where T : IComparable<T>
    {
        public T first, second, third;
        public Refactor(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public T FindMaxAll()
        {


            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.Write("\nFirst Number is Greater ");
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("\nSecond Number is Greater ");
                return second;
            }
            else
            {
                Console.Write("\nGreatest Number is third ");
                return third;
            }
        }
    }
    }
