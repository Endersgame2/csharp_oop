using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Dumbell:GymAsset
    {
        public int Weight { get; set; }
        public string Unit = "kg";
        public string HandleColor { get; set; }

        public Dumbell(int userInputForWeight,
            string userInputForHandleColor,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base (nameOfAsset, baseValueOfAsset)
            
        {
            Weight = userInputForWeight;
            HandleColor = userInputForHandleColor;
        }
    }

}
