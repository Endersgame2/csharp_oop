using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
     class Treadmill:GymAsset
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public Treadmill(string TreadmillPart1,
            string TreadmillPart2,
            string TreadmillPart3,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            Part1 = TreadmillPart1;
            Part2 = TreadmillPart2;
            Part3 = TreadmillPart3;
        }
    }
}
