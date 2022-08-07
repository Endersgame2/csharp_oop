using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class BenchPress : GymAsset
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }

        

        public BenchPress(string userInputForName1,
            string userInputForName2,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
                   
        {
            Name1 = userInputForName1;
            Name2 = userInputForName2;
        }

        
    }
}
