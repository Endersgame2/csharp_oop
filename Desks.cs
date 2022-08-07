using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Desks:GymAsset
    {
        public string Desk1 { get; set; }
        public string Desk2 { get; set; }
        
        public Desks(
            string deskKind1,
            string deskKind2,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            Desk1 = deskKind1;
            Desk2 = deskKind2;
          
        }
    }
}
