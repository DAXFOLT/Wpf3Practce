using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask25Class
    {
        public MyTask25Class(double a, double y, double x)
        {
            _a = a;
            _y = y;
            _x = x;
        }

        public double _a { get; set; }
        public double _y { get; set; }
        public double _x { get; set; }

        public double J()
        {
            return (Math.Pow(1 / Math.Tan(Math.Pow(_a, 3)), 3) + Math.Pow(Math.Atan(_a), 2)) / Math.Sqrt(Math.Pow(_y, Math.Tan(_x)));
        }
    }
}
