using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask5Class
    {
        public MyTask5Class(double z, double x, double y, double c)
        {
            _z = z;
            _x = x;
            _y = y;
            _c = c;
        }

        public double _z { get; set; }
        public double _x { get; set; }
        public double _y { get; set; }
        public double _c { get; set; }

        public double G()
        {
            return (Math.Tan(Math.Pow(_x, 4) - 6) - Math.Pow(Math.Cos(_z + _x * _y), 3)) / Math.Pow(Math.Cos(Math.Pow(_x, 3) + Math.Pow(_c, 2)), 4);
        }
    }
}
