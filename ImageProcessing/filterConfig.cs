using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class FilterConfig
    {
        public string LabelText { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int DefaultValue { get; set; }
        public int LargeChange { get; set; }
        public int SmallChange { get; set; }

        public bool Visible { get; set; }
    }
}
