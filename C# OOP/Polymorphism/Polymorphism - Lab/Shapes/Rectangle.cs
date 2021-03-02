using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return (Width + Height) * 2;
        }

        public override string Draw()
        {
            return $"{base.Draw()} {GetType().Name}";
        }
    }
}
