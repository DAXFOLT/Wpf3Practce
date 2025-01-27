using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask18Class
    {
        public MyTask18Class(double y, double t)
        {
            _y = y;
            _t = t;
        }

        public double _y { get; set; }
        public double _t { get; set; }

        public double S()
        {
            return (4.351 * Math.Pow(_y, 3) + 2 * _t * Math.Log(_t)) / Math.Sqrt(Math.Cos(2 * _y) + 4.351);
        }
    }
}
