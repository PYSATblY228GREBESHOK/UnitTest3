using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities
{
    public static class MathHelper
    {
        // Метод для нахождения корней уравнения ax^2 + bx + c = 0
        public static (double?, double?) FindRoots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return (null, null); // Корней нет

            if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return (root, null); // Один корень
            }

            double sqrtD = Math.Sqrt(discriminant);
            double root1 = (-b + sqrtD) / (2 * a);
            double root2 = (-b - sqrtD) / (2 * a);
            return (root1, root2); // Два корня
        }

        // Метод для вычисления процента от числа
        public static double CalculatePercentage(double total, double percentage)
        {
            return (total * percentage) / 100;
        }
    }
}


