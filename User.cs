using System;
namespace csharp_oop
{
    public abstract class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string lastname)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastname;
        }

    }
}

