using System;
namespace csharp_oop
{
    public class Lights:GymAsset
    {
        public int LightsRequired { get; set; }
        public string LightsColor { get; set; }

        public Lights(int NumberOfLights,
            string NewLighhtsColor,
             string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            LightsRequired = NumberOfLights;
            LightsColor = NewLighhtsColor;

        }
    }
}

