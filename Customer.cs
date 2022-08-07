using System;
namespace csharp_oop
{
    public enum Sexes
    {
        Male,
        Female,
        Other
    }
    public enum Subscriptions
    {
        Yearly,
        Monthly,
        Biweekly
    }
    public enum PaymentType
    {
        Debit,
        Credit
    }
    


    public class Customer :User
    {
        public string Sex { get; set; }
        public string MembershipType { get; set; }
        public string Payment { get; set; }
        public DateTime? LastVisited { get; set; }

        public Customer(
            string customerSex,
            string subscription,
            bool isDebit,
            DateTime? lastVisted,
            string firstName,
            string lastName
        ) : base(firstName, lastName)
        {
            if (customerSex == "Male")
            {
                Sex = Sexes.Male.ToString();
            }
            else if (customerSex == "Female")
            {
                Sex = Sexes.Female.ToString();
            }
            else if (customerSex == "Other")
            {
                Sex = Sexes.Other.ToString();
            }
            else
            {
                throw new Exception("Invalid sex");
            }

            if (subscription == "Yearly")
            {
                MembershipType = Subscriptions.Yearly.ToString();
            }
            else if (subscription == "Monthly")
            {
                MembershipType = Subscriptions.Monthly.ToString();
            }
            else if (subscription == "Biweekly")
            {
                MembershipType = Subscriptions.Biweekly.ToString();
            }
            else
            {
                throw new Exception("Invalid Selection");
            }

            Payment = isDebit ? PaymentType.Debit.ToString() : PaymentType.Credit.ToString();

            LastVisited = lastVisted;
        }
    }
}

