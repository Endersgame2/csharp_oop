using System;
namespace csharp_oop
{
    public class Water:GymAsset
    {
        public int NumberOfWaterOutlets { get; set; }
        public string waterSource { get; set; }

        public Water(int WaterOutlets,
            string sourceWater,
             string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            NumberOfWaterOutlets = WaterOutlets;
            waterSource = sourceWater;
        }
    }
}

