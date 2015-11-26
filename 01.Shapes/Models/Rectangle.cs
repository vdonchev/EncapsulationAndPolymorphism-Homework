namespace _01.Shapes.Models
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double heigth) 
            : base(width, heigth)
        {
        }

        public override double CalculateArea() => this.Width * this.Heigth;

        public override double CalculatePerimeter() => (this.Width + this.Heigth) * 2;
    }
}