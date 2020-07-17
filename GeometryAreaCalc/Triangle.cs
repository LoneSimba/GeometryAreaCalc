using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryAreaCalc
{
    public class Triangle : Figure
    {
        private double[] ribs = new double[3];

        public Triangle(double[] ribs, double h = 0) : base(h)
        {
            Array.Sort(ribs, 0, 3);

            this.Ribs = ribs;
        }

        public double[] Ribs { get => ribs; set => ribs = value; }

        public override void GetArea()
        {
        }

        public void GetArea(string method)
        {
            switch(method) {
                case "sides":
                    this.GetAreaBySides();
                    break;
            }
        }

        private void GetAreaBySides()
        {
            double p = (this.Ribs[2]+ this.Ribs[1]+ this.Ribs[0])/2;
            double temp = Math.Sqrt(p * (p - this.Ribs[2]) * (p - this.Ribs[1]) * (p - this.Ribs[0]));
            this.Area = temp;
        }

        public bool IsRightAngled()
        {
            double a_sqr = Math.Pow(this.Ribs[2], 2);
            double sum_sqr = Math.Pow(this.Ribs[0], 2) + Math.Pow(this.Ribs[1], 2);

            if (Math.Round(sum_sqr) == Math.Round(a_sqr)) return true;
            else return false;
        }
    }
}
