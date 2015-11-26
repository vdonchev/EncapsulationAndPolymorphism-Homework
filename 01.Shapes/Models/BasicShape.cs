namespace _01.Shapes.Models
{
    using Interfaces;

    public abstract class BasicShape : IShape
    {
        protected BasicShape(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        protected double Width { get; }

        protected double Heigth { get; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}