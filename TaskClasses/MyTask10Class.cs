using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask10Class
    {
        public MyTask10Class(double y, double x)
        {
            _y = y;
            _x = x;
        }

        public double _y { get; set; }
        public double _x { get; set; }

        public double U()
        {
            return (Math.Exp(Math.Pow(_x, 3)) + Math.Pow(Math.Cos(_x - 4), 2)) / (Math.Atan(_x) + 5.2 * _y);
        }
    }
}
