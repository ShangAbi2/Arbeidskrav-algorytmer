
## Project Description
This is a console application allows users to store and manage contact information for up to 100 contacts. Each contact contains:
- First Name
- Last Name
- Mobile Number
- Birthday
- Address 

The application supports functions for displaying contact details, searching for contacts, and sorting contacts based on various criteria.

## Instructions
- Clone the project from GitHub.
- Open the project in JetBrains Rider.
- Ensure the project is set as a Console Application and set as the Startup Project.
- Build the solution and run the application.

## Features
1. **Display Contact**:
   Displays the details of a selected contact in a formatted "contact card" view.

2. **Search Contacts**:
   Allows users to search for contacts by any field (first name, last name, mobile number, street, city, etc.).

3. **Sort Contacts**:
   Provides functionality to sort contacts by name or birthday, in ascending or descending order.

## Code Structure
- `Contact.cs`: Defines the `Contact` class that stores contact details like name, phone number, birthday, and address.
- `Phonebook.cs`: Manages the contact list, including functionality for displaying, searching, and sorting contacts.
- `Program.cs`: Contains the entry point (`Main` method) for running the application.

## Search & Sort Implementation
- **Search**: The search method iterates through the contact array and matches the search term with the contact's first name, last name, mobile number, street, or city.
- **Sort**: The sort method uses LINQ to sort contacts based on the chosen criterion (name or birthday) and order (ascending or descending).

## Developer Information
- developer: Sigurd Høgberg Simensen
- github: https://github.com/ShangAbi2

## License
MIT License.