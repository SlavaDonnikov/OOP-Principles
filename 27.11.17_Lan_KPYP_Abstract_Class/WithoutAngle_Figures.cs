using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._17_Lan_KPYP_Abstract_Class
{
    public class Circle : WithoutAngleFigure
    {
        public double R { get; set; }

        public Circle(double r)
        { R = r; }

        public override double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override void Print()
        {
            figurePrintStateHandler?.Invoke($"Circle square: {Square()}");
        }
    }

    public class Globe : WithoutAngleFigure
    {
        public double R { get; set; }

        public Globe(double r)
        { R = r; }

        public override double Square()
        {
            return 4 * Math.PI * Math.Pow(R, 2);
        }

        public override void Print()
        {
            figurePrintStateHandler?.Invoke($"Globe area square: {Square()}");
        }
    }
}
