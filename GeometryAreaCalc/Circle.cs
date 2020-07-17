using System;

namespace GeometryAreaCalc
{
    public class Circle : Figure
    {
        public Circle(double h) : base(h)
        {
        }

        public override void GetArea()
        {
            this.Area = Math.PI * Math.Pow(this.H, 2.0);
        }
    }
}
