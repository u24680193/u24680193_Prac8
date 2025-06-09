using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace u24680193_Prac8.Models
{
    public class Triangle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle() { }

        public Triangle(string description, string fill, string strokeColour, double strokeWidth, int x, int y, int baseLength, int height)
            : base(description, fill, strokeColour, strokeWidth)
        {
            X = x;
            Y = y;
            Base = baseLength;
            Height = height;
        }

        public override double getArea()
        {
            return 0.5 * Base * Height;
        }

        public override string getSVG()
        {
            string points = $"{X},{Y + Height} {X + (Base / 2)},{Y} {X + Base},{Y + Height}";
            return $"<polygon points=\"{points}\" fill=\"{Fill}\" stroke=\"{StrokeColour}\" stroke-width=\"{StrokeWidth}\" />";
        }
    }
}