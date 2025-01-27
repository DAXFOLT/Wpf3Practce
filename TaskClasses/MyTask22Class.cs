using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace WpfApp6
{
    public class MyTask22Class
    {
        public MyTask22Class(double y, double x)
        {
            _y = y;
            _x = x;
        }

        public double _y { get; set; }
        public double _x { get; set; }

        public double F()
        {
            return Math.Cos(Math.Pow(_x, 2) + 2) + (3.5 * Math.Pow(_x, 2) + 1) / Math.Pow(Math.Cos(_y), 2);
        }
    }
}
