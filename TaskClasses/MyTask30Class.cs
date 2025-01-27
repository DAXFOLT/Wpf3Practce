using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask30Class
    {
        public MyTask30Class(double x)
        {
            _x = x;
        }

        public double _x { get; set; }

        public double K()
        {
            return Math.Sqrt(Math.Pow(3 + _x, 6) - Math.Log(_x)) / (Math.Exp(0) + Math.Asin(6 * Math.Pow(_x, 2)));
        }
    }
}
