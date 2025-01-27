using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask29Class
    {
        public MyTask29Class(double y, double d, double x)
        {
            _y = y;
            _d = d;
            _x = x;
        }

        public double _y { get; set; }
        public double _d { get; set; }
        public double _x { get; set; }

        public double R()
        {
            return (Math.Pow(Math.Cos(_y), 2) + 2.4 * _d) / (Math.Exp(_y) + Math.Log(Math.Pow(Math.Sin(_x), 2) + 6));
        }
    }
}
