namespace _01.Shapes.Models
{
    using System;
    using Interfaces;

    public class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        private double Radius { get; }

        public double CalculateArea() => Math.Pow(Math.PI * this.Radius, 2);

        public double CalculatePerimeter() => 2 * Math.PI * this.Radius;
    }
}