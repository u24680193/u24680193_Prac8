using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u24680193_Prac8.Models;

namespace u24680193_Prac8.Controllers
{
    public class HomeController : Controller
    {
        private static List<Shape> shapeList = new List<Shape>();

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(FormCollection form)
        {
            int type = int.Parse(form["type"]);
            string desc = form["desc"];
            string fill = form["fill"];
            string stroke = form["outline"];
            double strokeWidth = double.Parse(form["stroke"]);
            int x = int.Parse(form["xCoord"]);
            int y = int.Parse(form["yCoord"]);

            Shape shape = null;

            switch (type)
            {
                case 1: // Triangle
                    int baseLength = Convert.ToInt32(form["width"]);   
                    int triHeight = Convert.ToInt32(form["height"]);
                    shape = new Triangle(desc, fill, stroke, strokeWidth, x, y, baseLength, triHeight);
                    break;

                case 2: // Ellipse
                    int radiusX = Convert.ToInt32(form["width"]);
                    int radiusY = Convert.ToInt32(form["height"]);
                    shape = new Ellipse(desc, fill, stroke, strokeWidth, x, y, radiusX, radiusY);
                    break;
            }

            if (shape != null)
            {
                shapeList.Add(shape);
            }

            ViewBag.Shapes = shapeList;
            return View("Display");
        }

        public ActionResult Display()
        {
            ViewBag.Shapes = shapeList;
            return View();
        }
    }
}