﻿using System.Text.RegularExpressions;

namespace Programming.Model
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
    }
}