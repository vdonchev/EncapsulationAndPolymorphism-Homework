namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;

    public static class ProgramMain
    {
        public static void Main()
        {
            var shapes = new List<IShape>()
            {
                new Rectangle(25.6, 46.3),
                new Circle(.33),
                new Rectangle(1, 2),
                new Circle(5.6),
                new Rhombus(16.66, 78),
                new Circle(25.6),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name,-10} [Area: {shape.CalculateArea():F2} | Perimiter: {shape.CalculatePerimeter():F2}]");
            }
        }
    }
}
