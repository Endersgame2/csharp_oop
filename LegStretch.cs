using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    class LegStretch:GymAsset
    {
        public int Power1 { get; set; }
        public int Power2 { get; set; }

        public LegStretch(
            int intensity1,
            int intensity2,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base (nameOfAsset, baseValueOfAsset)
        {
            Power1 = intensity1;
            Power2 = intensity2;
        }
    }
}
