namespace Arbeidskrav_algorytmer

{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Contact(string firstName, string lastName, string mobileNumber, DateTime birthday, string street, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Birthday = birthday;
            Street = street;
            City = city;
        }
    }
}