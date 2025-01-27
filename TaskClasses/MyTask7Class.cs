using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask7Class
    {
        public MyTask7Class(double y, double x, double a)
        {
            _y = y;
            _x = x;
            _a = a;
        }

        public double _y { get; set; }
        public double _x { get; set; }
        public double _a { get; set; }

        public double D()
        {
            return (Math.Cos(Math.Pow(_x, 3) + 7) - Math.Sin(_y - _a)) / (Math.Log(Math.Pow(_x, 4)) + 2 * Math.Pow(Math.Sin(_x), 5));
        }
    }
}
