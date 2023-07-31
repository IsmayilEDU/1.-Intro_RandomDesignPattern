using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Structural.Models.Colors
{
    internal class Red : IColor
    {
        public (int, int, int) GetRGB() => (255, 0, 0);
    }
}
