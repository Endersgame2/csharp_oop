using System;
namespace csharp_oop
{
    public class LeisureArea : GymAsset
    {
        public  string EquipmentsNeededInLeisureArea { get; set; }
        public string Color { get; set; }

        public LeisureArea(
            string equipmentsLeisureArea,
            string colorLeisureArea,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base (nameOfAsset, baseValueOfAsset)
        {
            EquipmentsNeededInLeisureArea = equipmentsLeisureArea;
            Color = colorLeisureArea;
        }
    }
}

