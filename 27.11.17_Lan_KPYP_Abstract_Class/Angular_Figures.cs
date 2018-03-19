using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._17_Lan_KPYP_Abstract_Class
{
    public class Rectangle : AngularFigure
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double a, double b)
        { Length = a; Width = b; }

        public override int AngleNumber { get; set; } = 4;
        
        public override double Square()
        {
            return Length * Width;
        }

        public override void Print()
        {
            figurePrintStateHandler?.Invoke($"Rectangle square: {Square()}");            
        }
    }

    public class RectTriangle : AngularFigure
    {
        public double Katet_1 { get; set; }
        public double Katet_2 { get; set; }
        
        public RectTriangle(double katet1, double katet2)
        { Katet_1 = katet1; Katet_2 = katet2; }

        public override int AngleNumber { get; set; } = 3;

        public override double Square()
        {
            return 0.5 * Katet_1 * Katet_2;
        }

        public override void Print()
        {
            figurePrintStateHandler?.Invoke($"RectTriangle square: {Square()}");
        }
    }

    public class Trapezium : AngularFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double H { get; set; }

        public Trapezium(double a, double b, double h)
        { A = a; B = b; H = h; }

        public override int AngleNumber { get; set; } = 3;

        public override double Square()
        {
            return ((A + B)/2) * H;
        }

        public override void Print()
        {
            figurePrintStateHandler?.Invoke($"Trapezium square: {Square()}");
        }
    }

    public class Tetrahedron : AngularFigure
    {
        public double Rib { get; set; }
        public double H { get; set; }

        public Tetrahedron(double rib, double h)
        { Rib = rib; H = h; }

        public override int AngleNumber { get; set; } = 4;

        public override double Square()
        {
            return Math.Pow(Rib, 2) * Math.Pow(3, (double)1 / 2);
        }

        public override void Print()
        {
            figurePrintStateHandler?.Invoke($"Тетраэдр - многогранник, состоящий из 4 треугольных граней.\n" +
                $"Тетраэдр представляет собой треугольную пирамиду.\n" +
                $"В правильном тетраэдре все 4 грани являются равносторонними треугольниками.\n" +
                $"Tetrahedron area square: {Square()}");
        }
    }

    public class Parallelepiped : AngularFigure
    {
        public double Rib_A { get; set; }
        public double Rib_B { get; set; }
        public double Rib_C { get; set; }

        public Parallelepiped(double a, double b, double c)
        { Rib_A = a; Rib_B = b; Rib_C = c; }

        public override int AngleNumber { get; set; } = 4;

        public override double Square()
        {
            return 2 * ( (Rib_A * Rib_B) + (Rib_B * Rib_C) + (Rib_A * Rib_C) );
        }

        public override void Print()
        {
            figurePrintStateHandler?.Invoke($"Parallelepiped area square: {Square()}");
        }
    }
}
