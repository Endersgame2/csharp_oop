using System;
namespace csharp_oop
{
    public enum Shifts
    {
        Day,
        Night
    }

    public class Employee : User
    {

        public string Position { get; set; }
        public string Shift { get; set; }

        public Employee(
            string position,
            bool isDayShift,
            string firstName,
            string lastName
        ) : base(firstName, lastName)
        {
            Position = position;
            Shift = isDayShift ? Shifts.Day.ToString() : Shifts.Night.ToString();
        }

        public void StartGym()
        {
            if (Position == "Manager" || Position == "Assistant Manager")
            {
                Console.WriteLine("Gym is now open.");
            }
            else
            {
                Console.WriteLine("Please call the manager to start the gym.");
            }
        }
    }
}

