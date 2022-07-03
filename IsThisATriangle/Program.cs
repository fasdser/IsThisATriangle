using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisATriangle
{
    internal class Program
    {
        //  Implement a function that accepts 3 integer values a, b, c.
        //  The function should return true if a triangle can be built with the sides of given length and false in any other case.
        //  (In this case, all triangles must have surface greater than 0 to be accepted).
        //  Реализовать функцию, которая принимает 3 целочисленных значения a, b, c.
        //  Функция должна возвращать true, если можно построить треугольник со сторонами заданной длины, и false в любом другом случае.
        //  (В этом случае все треугольники должны иметь поверхность больше 0, чтобы быть принятыми).
        static void Main(string[] args)
        {

        }
    }

    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {

            if (a <= 0 || b <= 0 || c <= 0) return false;
            else if (a + b <= c || b + c <= a || a + c <= b) return false;
            else return true;


        }
    }
}
