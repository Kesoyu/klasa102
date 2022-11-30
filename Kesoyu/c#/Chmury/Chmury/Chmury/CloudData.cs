using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chmury
{
    internal readonly struct CloudData
    {
        
        public readonly int day;
        public readonly float temperature;
        public readonly int precipitation;
        public readonly string category;
        public readonly int size;
        public CloudData(int d, float t, int p, string c,int s) {
            day = d;
            temperature = t;
            precipitation = p;
            category = c;
            size = s;
        }
    }
}
