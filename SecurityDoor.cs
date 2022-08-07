using System;
namespace csharp_oop
{
    public class SecurityDoor:GymAsset
    {

        public int NumberOfDoors { get; set; }
        public string SecurityLevel { get; set; }


        public SecurityDoor(int DoorsQuantity,
            string LevelOfsecirity,
             string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            NumberOfDoors = DoorsQuantity;
            SecurityLevel = LevelOfsecirity;
        }
    }
}

