using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Rectangle
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public double Perimetr()
        {
            return (Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y1 - Y1, 2)) + Math.Sqrt(Math.Pow(X1 - X1, 2) + Math.Pow(Y2 - Y1, 2))) * 2;
        }
        public double Square()
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y1 - Y1, 2)) * Math.Sqrt(Math.Pow(X1 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
    }
}
