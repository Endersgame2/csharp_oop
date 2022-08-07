using System;

namespace csharp_oop
{
    public class Building : GymAsset
    {
        public string OuterColor { get; set; }
        public string InnerColor { get; set; }
        
        public SecurityDoor SecureEntrance { get; set; }
        public List<Washroom> Washrooms { get; set; }
        public List<Room> Rooms { get; set; }
        public Reception_Area Reception_Areas { get; set; }
        public List<LockerRoom> LockerRooms { get; set; }
        public LeisureArea LeisureAreas { get; set; }
        public List<Water> WaterFountains { get; set; }
        public Lights Light {get; set;}
        public Fans Fan {get; set; }

        public Building(
            string userInputForOuterColor,
            string userInputForInnerColor,
            string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            OuterColor = userInputForOuterColor;
            InnerColor = userInputForInnerColor;
       
            SecureEntrance = new SecurityDoor(2, "Standard", "Secure Entrance", 10000);
            

            // Washrooms

            Washrooms = new List<Washroom>();
            Washroom maleWashroom = new Washroom(3, "Red", "Male Washroom", 20000);
            Washroom femaleWashroom = new Washroom(3, "Pink", "Female Washroom", 20000);

            Washrooms.Add(maleWashroom);
            Washrooms.Add(femaleWashroom);

            // Rooms
            // needs to add eqipments to rooms


            Rooms = new List<Room>();
            Room basicRoom = new Room(1, "Yellow", "Basic Room", 240000);
            Room treadmillRoom = new Room(1, "Wood", "Treadmill Room", 60000);
            Room spaRoom = new Room(1, "Black", "Spa Room", 40000);

            Rooms.Add(basicRoom);
            Rooms.Add(treadmillRoom);
            Rooms.Add(spaRoom);

            //Reception Area

            Reception_Areas = new Reception_Area("Reception Desk", "Creative", "Reception Room", 324000);

            // Locker Room

            LockerRooms = new List<LockerRoom>();
            LockerRoom MaleLockerRoom = new LockerRoom(15, "Brown", "Dark Grey", "Male Locker Room", 23009);
            LockerRoom FemaleLockerRoom = new LockerRoom(15, "Brown", "White", "Female Locker Room", 23500);

            LockerRooms.Add(MaleLockerRoom);
            LockerRooms.Add(FemaleLockerRoom);

            // Leisure Area

            LeisureAreas = new LeisureArea("Couch", "White", "Leisure Area", 345600);

            // Water Fountains

            WaterFountains = new List<Water>();
            Water MaleWaterFountain = new Water(2, "Core", "Male Water Fountain", 4000);
            Water FemaleWaterFountain = new Water(2, "Fresh", "Female Water Fountain", 4000);

            WaterFountains.Add(MaleWaterFountain);
            WaterFountains.Add(FemaleWaterFountain);


            // Lights

            Light = new Lights(30, "Yellow and White", "Lights", 20);

            // Fans

            Fan = new Fans(10, "White", "Fans", 200);
        }
    }
}

