﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProgramming.Model
{
    class Point2D
    {
        public double _x;
        public double _y;

        public double X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value,nameof(X));
                _x = value;
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                Validator.AssertOnPositiveValue(value,nameof(Y));
                _y = value;
            }
        }
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
