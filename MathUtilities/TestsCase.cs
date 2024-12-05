using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities
{
    public class TestCase
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double? ExpectedRoot1 { get; set; }
        public double? ExpectedRoot2 { get; set; }

        public TestCase(double a, double b, double c, double? expectedRoot1, double? expectedRoot2)
        {
            A = a;
            B = b;
            C = c;
            ExpectedRoot1 = expectedRoot1;
            ExpectedRoot2 = expectedRoot2;
        }
    }

}
