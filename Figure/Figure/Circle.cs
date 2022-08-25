﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    public class Circle:Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value > 0 ? value : -value;
            }
        }

        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
