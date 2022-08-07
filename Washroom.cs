using System;
namespace csharp_oop
{
    public class Washroom:GymAsset
    {
       public int NumberOfToilets { get; set; }
        public string ThemeOfWashrooms { get; set; }

        public Washroom(int numofToilets,
            string themeOfWashroom,
             string nameOfAsset,
            decimal baseValueOfAsset
        ) : base(nameOfAsset, baseValueOfAsset)
        {
            NumberOfToilets = numofToilets;
            ThemeOfWashrooms = themeOfWashroom;
        }

    }
}

