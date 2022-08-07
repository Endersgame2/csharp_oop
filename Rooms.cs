using System;
namespace csharp_oop
{
    public class Rooms:GymAsset
    {
        public int NumberOfRooms { get; set; }
        public string ColorOfRooms { get; set; }


        public Rooms(int RoomsQuantity,
            string RoomsColor,
             string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            RoomsQuantity = NumberOfRooms;
            ColorOfRooms = RoomsColor;
        }
    }
}

