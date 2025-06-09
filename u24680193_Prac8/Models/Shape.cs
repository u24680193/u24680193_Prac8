using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u24680193_Prac8.Models
{
    public abstract class Shape
    {
        public string Description { get; set; }

        [Required]
        public string Fill { get; set; }

        [Required]
        public string StrokeColour { get; set; }

        [Range(0, 3)]
        public double StrokeWidth { get; set; }

        public int SvgWidth { get; set; } = 450;
        public int SvgHeight { get; set; } = 450;

        public Shape() { }

        public Shape(string description, string fill, string strokeColour, double strokeWidth)
        {
            Description = description;
            Fill = fill;
            StrokeColour = strokeColour;
            StrokeWidth = strokeWidth;
        }

        public abstract double getArea();
        public abstract string getSVG();
    }

}