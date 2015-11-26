namespace _01.Shapes.Models
{
    using System;

    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double heigth)
            : base(width, heigth)
        {
        }

        public override double CalculateArea() => this.Width * this.Heigth / 2;

        public override double CalculatePerimeter() => this.CalculateRhombusSide() * 4;

        private double CalculateRhombusSide() =>
            Math.Sqrt((this.Width * this.Width) + (this.Heigth * this.Heigth)) / 2;
    }
}