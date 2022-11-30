using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chmury
{
    internal readonly struct CloudPrecipitationAndCategory
    {
        public readonly string category;
        public readonly float value;
        public CloudPrecipitationAndCategory(string c, float v)
        {
            category = c;
            value = v;
        }
    }
}
