using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class PunchingBag:GymAsset
    {
      
        public string Stuff1 { get; set; }  
        public string Stuff2 { get; set; }
        public PunchingBag(string stuffPart1,
           string stuffPart2,
             string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            Stuff1 = stuffPart1;
            Stuff2 = stuffPart2;


        }
    }

}
