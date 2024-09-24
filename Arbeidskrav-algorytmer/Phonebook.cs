namespace Arbeidskrav_algorytmer

{
    using System;
    using System.Linq;

    public class Phonebook
    {
        private Contact[] contacts = new Contact[100];

        // Public property to expose the contacts array
        public Contact[] Contacts
        {
            get { return contacts; }
        }

        public Phonebook()
        {
            PopulateContacts();  // Populating with random contacts
        }

        // Populate contacts with 100 random entries
        public void PopulateContacts()
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                contacts[i] = new Contact(
                    "FirstName" + i,
                    "LastName" + i,
                    "123456789" + i,
                    new DateTime(1990, 1, 1).AddDays(i),
                    "Street" + i,
                    "City" + i
                );
            }
        }

        // Display a single contact in a formatted way
        public static string Display(Contact c)
        {
            return $"Name: {c.FirstName} {c.LastName}\n" +
                   $"Mobile: {c.MobileNumber}\n" +
                   $"Birthday: {c.Birthday.ToShortDateString()}\n" +
                   $"Address: {c.Street}, {c.City}\n";
        }

        // Search contacts by any field
        public Contact[] Search(string searchTerm)
        {
            return contacts.Where(c => 
                                    c.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                    c.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                    c.MobileNumber.Contains(searchTerm) ||
                                    c.Street.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                    c.City.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                           .ToArray();
        }

        // Sort contacts by the given criterion (name or birthday) and order (asc or desc)
        public Contact[] Sort(string criterion, string order)
        {
            IEnumerable<Contact> sortedContacts = contacts;

            switch (criterion.ToLower())
            {
                case "name":
                    sortedContacts = order == "asc" 
                        ? contacts.OrderBy(c => c.FirstName).ThenBy(c => c.LastName) 
                        : contacts.OrderByDescending(c => c.FirstName).ThenByDescending(c => c.LastName);
                    break;
                case "birthday":
                    sortedContacts = order == "asc" 
                        ? contacts.OrderBy(c => c.Birthday) 
                        : contacts.OrderByDescending(c => c.Birthday);
                    break;
                default:
                    Console.WriteLine("Unknown sorting criterion.");
                    break;
            }

            return sortedContacts.ToArray();
        }
    }
}