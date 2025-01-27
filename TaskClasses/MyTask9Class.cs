using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask9Class
    {
        public MyTask9Class(double y, double x, double d)
        {
            _y = y;
            _x = x;
            _d = d;
        }

        public double _y { get; set; }
        public double _x { get; set; }
        public double _d { get; set; }

        public double R()
        {
            return (Math.Pow(Math.Cos(_y), 3) + Math.Pow(2, _x) * _d) / (Math.Exp(_y) + Math.Log(Math.Pow(Math.Sin(_x), 2) + 7.4));
        }
    }
}
