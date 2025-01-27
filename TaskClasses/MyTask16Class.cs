using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask16Class
    {
        public MyTask16Class(double t, double x, double y)
        {
            _t = t;
            _x = x;
            _y = y;
        }

        public double _t { get; set; }
        public double _x { get; set; }
        public double _y { get; set; }
        public double P()
        {
            return (Math.Pow(Math.Sin(_x), 3) + Math.Log(2 * _y + 3 * _x)) / (Math.Pow(_t, Math.E) + Math.Sqrt(_x));
        }
    }
}
