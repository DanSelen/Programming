using ProjectProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        private Point2D _center;
        private double _outradius;
        private double _intoradius;

        private double Area
        {
            get
            {
                return Math.PI * (Math.Pow(Outradius, 2) - Math.Pow(Intoradius, 2));
            }
        }

        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double Outradius
        {
            get { return _outradius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                if (value <= _intoradius)
                {
                    throw new ArgumentException("Внешний радиус не может быть меньше внутреннего");
                }
                _outradius = value;
            }
        }

        public double Intoradius
        {
            get { return _intoradius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                if (value >= _outradius)
                {
                    throw new ArgumentException("Внутренний радиус не может быть больше внешнего");
                }
                _intoradius = value;
            }
        }
    }
}