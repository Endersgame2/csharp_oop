using System;
namespace csharp_oop
{
    public class Reception_Area:GymAsset
    {
        public string ReceptionEquipments { get; set; }
        public string ReceptionTheme { get; set; }

        public Reception_Area(string equipmentsReception,
            string ThemeReception,
             string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            ReceptionEquipments = equipmentsReception;
            ReceptionTheme = ThemeReception;
        }


    }
}

