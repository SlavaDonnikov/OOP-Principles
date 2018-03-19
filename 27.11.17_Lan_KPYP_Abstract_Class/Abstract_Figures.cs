using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._17_Lan_KPYP_Abstract_Class
{
    public abstract class Abstract_Figures : IFigure_Print
    {
        public delegate void FigurePrintStateHandler(string message);
        public FigurePrintStateHandler figurePrintStateHandler;

        public void RegisterHandler(FigurePrintStateHandler _del)
        {
            figurePrintStateHandler += _del;
        }
        public void UnRegisterHandler(FigurePrintStateHandler _del)
        {
            figurePrintStateHandler -= _del;
        }

        public abstract double Square();
        public abstract void Print();
    }

    public abstract class AngularFigure : Abstract_Figures
    {
        public abstract int AngleNumber { get; set; }
    }

    public abstract class WithoutAngleFigure : Abstract_Figures
    {
        public bool IsHaveAngles { get; } = false;        
    }
}
