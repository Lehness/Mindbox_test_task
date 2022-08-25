using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    public class Triangle:Figure
    {
        private double side1, side2, side3;

        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value > 0 ? value : -value;
            }
        }

        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value > 0 ? value : -value;
            }
        }

        public double Side3
        {
            get
            {
                return side3;
            }
            set
            {
                side3 = value > 0 ? value : -value;
            }
        }

        public Triangle(double _side1, double _side2, double _side3)
        {
            Side1 = _side1;
            Side2 = _side2;
            Side3 = _side3;
            if ((Side1 >= Side2 + Side3) || (Side2 >= Side1 + Side3) || (Side3 >= Side2 + Side1))
            {
                throw new Exception("Не выполнено неравенство треугольника");
            }
        }

        public override double Area()
        {
            double SemiPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(SemiPerimeter*(SemiPerimeter-Side1)*(SemiPerimeter-Side2)*(SemiPerimeter-Side3));
        }

        public bool IsRight()
        {
            if ((Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2))
                || (Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2))
                || (Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2)))
                return true;
            else return false;
        }

    }
}
