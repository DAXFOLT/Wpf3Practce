using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask28Class
    {
        public MyTask28Class(double y, double z, double c, double x)
        {
            _y = y;
            _z = z;
            _c = c;
            _x = x;
        }

        public double _y { get; set; }
        public double _z { get; set; }
        public double _c { get; set; }
        public double _x { get; set; }

        public double G()
        {
            return (Math.Tan(Math.Pow(_x, 4) - 6) - Math.Pow(Math.Cos(_z + Math.Pow(_x, 3) * _y), 3 * _x)) / Math.Pow(Math.Cos(Math.Pow(_x, 3) * Math.Pow(_c, 2)), 2);
        }
    }
}
