using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public enum Mode
    {
        Grayscale,
        Gamma,
        Invert,
        Brightness,
        Contrast,
        Color,
        Smooth,
        Gauss,
        Sharpen,
        MeanRemoval,
        Emboss,
        HorzVertz,
        AllDirection,
        Lossy,
        HorizontalOnly,
        VerticalOnly
    }
}
