using Bridge_Structural.Models.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Structural.Models.Figures
{
    internal interface IFigure
    {
        public IColor color { get; set; }

        public double Area { get; set; }
    }
}
