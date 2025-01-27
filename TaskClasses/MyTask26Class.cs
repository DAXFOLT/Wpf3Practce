using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask26Class
    {
        public MyTask26Class(double y, double x, double k)
        {
            _y = y;
            _x = x;
            _k = k;
        }

        public double _y { get; set; }
        public double _x { get; set; }
        public double _k { get; set; }

        public double U()
        {
            return (Math.Log(Math.Pow(_x, 3) + _y) - Math.Pow(_y, 4)) / (Math.Exp(_y) + 5.4 * Math.Pow(_k, 3));
        }
    }
}
