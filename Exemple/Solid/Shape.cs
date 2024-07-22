using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Solid
{
    public class Shape
    {
        public enum ShapeType
        {
            Circle,
            Rectangle,
            Triangle
        }

        public ShapeType Type { get; set; }
        public double Radius { get; set; } // For Circle
        public double Width { get; set; }  // For Rectangle
        public double Height { get; set; } // For Rectangle and Triangle
        public double Base { get; set; }   // For Triangle

        public double CalculateArea()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return Math.PI * Radius * Radius;
                case ShapeType.Rectangle:
                    return Width * Height;
                case ShapeType.Triangle:
                    return 0.5 * Base * Height;
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }

}
