using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask21Class
    {
        public MyTask21Class(double x, double z, double a)
        {
            _x = x;
            _z = z;
            _a = a;
        }

        public double _x { get; set; }
        public double _z { get; set; }
        public double _a { get; set; }

        public double N()
        {
            return Math.Pow(_z + Math.Sqrt(_z * _x), 1.5) / (Math.Exp(_x) + Math.Pow(_a, 5) * Math.Atan(_x));
        }
    }
}
