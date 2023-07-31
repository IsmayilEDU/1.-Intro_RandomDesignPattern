using Bridge_Structural.Models.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Structural.Models.Figures
{
    internal class Rectangle : IFigure
    {
        public IColor color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
