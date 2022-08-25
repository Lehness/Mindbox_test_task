using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigure;

namespace FigureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                dynamic figure = new Triangle(3, 4, 5);
                Console.WriteLine("Площадь треугольника = " + figure.Area());
                Console.WriteLine("Прямоугольный " + figure.IsRight());

                figure = new Circle(5);
                Console.WriteLine("Площадь круга = " + figure.Area());

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                throw;
            }
        }
    }
}
