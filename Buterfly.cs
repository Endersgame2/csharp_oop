using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Buterfly :GymAsset
    {
        public string Style1 { get; set; }
        public string Style2 { get; set; }

        public Buterfly(
            string styleKind1,
            string styleKind2,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            Style1 = styleKind1;
            Style2 = styleKind2;
        }
    }
}
