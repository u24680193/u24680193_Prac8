using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace u24680193_Prac8.Models
{
   
        public class Ellipse : Shape
        {
        public int CX { get; set; }
        public int CY { get; set; }
        public int RadiusX { get; set; }
        public int RadiusY { get; set; }

        public Ellipse() { }

        public Ellipse(string description, string fill, string strokeColour, double strokeWidth, int cx, int cy, int radiusX, int radiusY)
            : base(description, fill, strokeColour, strokeWidth)
        {
            CX = cx;
            CY = cy;
            RadiusX = radiusX;
            RadiusY = radiusY;
        }

        public override double getArea()
        {
            return Math.PI * RadiusX * RadiusY;
        }

        public override string getSVG()
        {
            return $"<ellipse cx=\"{CX}\" cy=\"{CY}\" rx=\"{RadiusX}\" ry=\"{RadiusY}\" " +
                   $"fill=\"{Fill}\" stroke=\"{StrokeColour}\" stroke-width=\"{StrokeWidth}\" />";
        }
    }

}