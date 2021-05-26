using System;
using System.Collections.Generic;
using System.Text;

namespace L01Z01
{
    class Punkt
    {
        public double X = 0;
        public double Y = 0;

        public Punkt(double x,double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double dist(Punkt p)
        {
            return Math.Sqrt((this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y));
        }
        public double Odleglosc()
        {
            return Math.Sqrt(Math.Pow(X, 2) + (Math.Pow(Y, 2)));
        }
        public double OdlegloscPunktu(Punkt p)
        {
            return Math.Sqrt(Math.Pow(p.X - this.X, 2) + Math.Pow(p.Y - this.Y, 2));
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
