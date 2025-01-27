using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    public class MyTask1Class
    {
        public MyTask1Class(double x, double a, double c)
        {
            _x = x;
            _a = a;
            _c = c;
        }

        public double _x { get; set; }
        public double _a { get; set; }
        public double _c { get; set; }

        public double L()
        {
            return (Math.Sqrt(Math.Exp(_x) - Math.Pow(Math.Cos(Math.Pow(_x, 2) * Math.Pow(_a, 5)), 4)) + Math.Pow(Math.Atan(_a - Math.Pow(_x, 5)), 4)) / (Math.E * Math.Sqrt(Math.Abs(_a + _x * Math.Pow(_c, 4))));
        }
    }
}
