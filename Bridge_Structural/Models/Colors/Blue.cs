using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Structural.Models.Colors
{
    internal class Blue : IColor
    {
        public (int, int, int) GetRGB() => (0, 0, 255);
    }
}
