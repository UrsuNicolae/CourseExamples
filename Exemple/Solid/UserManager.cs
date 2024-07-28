namespace Exemple.Solid
{
    using System;

    // Clasă monolitică care încalcă principiile SOLID
    class UserManager
    {
        // Proprietăți pentru gestionarea utilizatorilor
        public string UserName { get; set; }
        public string Email { get; set; }

        // Metodă pentru adăugarea unui utilizator
        public void AddUser()
        {
            // Cod pentru adăugarea unui utilizator
            Console.WriteLine($"Adding user: {UserName} with email: {Email}");

            // Cod specific pentru salvarea utilizatorului într-o bază de date
            SaveToDatabase(UserName, Email);
        }

        // Metodă pentru ștergerea unui utilizator
        public void DeleteUser()
        {
            // Cod pentru ștergerea unui utilizator
            Console.WriteLine($"Deleting user: {UserName}");

            // Cod specific pentru ștergerea utilizatorului din baza de date
            DeleteFromDatabase(UserName);
        }

        // Metodă pentru actualizarea unui utilizator
        public void UpdateUser()
        {
            // Cod pentru actualizarea unui utilizator
            Console.WriteLine($"Updating user: {UserName} with email: {Email}");

            // Cod specific pentru actualizarea utilizatorului în baza de date
            UpdateInDatabase(UserName, Email);
        }

        // Metodă pentru salvarea utilizatorului în baza de date
        private void SaveToDatabase(string userName, string email)
        {
            // Cod pentru salvarea în baza de date
            Console.WriteLine("User saved to database.");
        }

        // Metodă pentru ștergerea utilizatorului din baza de date
        private void DeleteFromDatabase(string userName)
        {
            // Cod pentru ștergerea din baza de date
            Console.WriteLine("User deleted from database.");
        }

        // Metodă pentru actualizarea utilizatorului în baza de date
        private void UpdateInDatabase(string userName, string email)
        {
            // Cod pentru actualizarea în baza de date
            Console.WriteLine("User updated in database.");
        }
    }

    class UserManagerProgram
    {
        static void Main1(string[] args)
        {
            // Crearea și gestionarea unui utilizator
            UserManager userManager = new UserManager
            {
                UserName = "JaneDoe",
                Email = "jane.doe@example.com"
            };

            userManager.AddUser();
            userManager.UpdateUser();
            userManager.DeleteUser();
        }
    }

}
