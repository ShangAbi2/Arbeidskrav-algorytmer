namespace Arbeidskrav_algorytmer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Startpunkt for programmet
            Phonebook phonebook = new Phonebook();

            // Eksempel: Vise en kontakt
            Console.WriteLine("Displaying first contact:");
            Contact contact = phonebook.Contacts[0];  // Bruker den offentlige egenskapen Contacts
            Console.WriteLine(Phonebook.Display(contact));

            // Eksempel: Søke etter kontakter
            Console.WriteLine("Search Results for 'FirstName1':");
            Contact[] searchResults = phonebook.Search("FirstName1");
            foreach (var c in searchResults)
            {
                Console.WriteLine(Phonebook.Display(c));
            }

            // Eksempel: Sortere kontakter
            Console.WriteLine("Sorted Contacts by Name (ascending):");
            Contact[] sortedContacts = phonebook.Sort("name", "asc");
            foreach (var c in sortedContacts)
            {
                Console.WriteLine(Phonebook.Display(c));
            }
        }
    }
}
