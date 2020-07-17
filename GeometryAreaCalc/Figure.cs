using System;

namespace GeometryAreaCalc
{
    public abstract class Figure
    {
        private double h;
        private double area;

        public double H { get => h; set => h = value; }
        public double Area { get => area; set => area = value; }

        public Figure(double h)
        {
            this.H = h;
        }

        public abstract void GetArea();
    }
}
