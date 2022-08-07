using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Staircase:GymAsset
    {
        public string Equipment1 { get; set; }
        public string Equipment2 { get; set; }

        public Staircase(string equipment1,
            string equipment2,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            Equipment1 = equipment1;
            Equipment2 = equipment2;
        }
    }
}
