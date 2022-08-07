using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    internal class Television:GymAsset
    {
        public string Channel1 { get; set; }
        public string Channel2 { get; set; }
        public Television(string channelPart1,
            string channelPart2,
            string channelPart3,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            Channel1 = channelPart1;
            Channel2 = channelPart2;
            
        }
            
    }
}
