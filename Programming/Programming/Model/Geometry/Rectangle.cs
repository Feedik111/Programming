using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    
    public class Rectangle
    {
        private static int _allRectanglesCount;
        
        private int _height;
        
        private int _width;

        public Rectangle()
        {
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        public Rectangle(int height,
            int width,
            string color,
            Point2D center)
        
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        public Rectangle(Rectangle rectangle)
        {
            Id = rectangle.Id;
            Height = rectangle.Height;
            Width = rectangle.Width;
            Color = rectangle.Color;
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);
        }
        
        public Point2D Center { get; set; }

        public string Color { get; set; }

        public int Id { get; set; }
        
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }

        protected bool Equals(Rectangle other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Rectangle) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}