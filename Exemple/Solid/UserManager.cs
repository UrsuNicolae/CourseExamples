namespace Exemple.Solid
{
    class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }

    interface IUserRepository
    {
        void Save(User user);
        void Delete(string userName);
        void Update(User user);
    }

    class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            // Cod pentru salvarea în baza de date
            Console.WriteLine($"User: {user.UserName} saved to database.");
        }

        // Metodă pentru ștergerea utilizatorului din baza de date
        public void Delete(string userName)
        {
            // Cod pentru ștergerea din baza de date
            Console.WriteLine($"User: {userName} deleted from database.");
        }

        // Metodă pentru actualizarea utilizatorului în baza de date
        public void Update(User user)
        {
            // Cod pentru actualizarea în baza de date
            Console.WriteLine($"User:  {user.UserName}  saved to database.e.");
        }
    }

    interface IUserManager
    {
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }

    // Clasă monolitică care încalcă principiile SOLID
    class UserManager : IUserManager
    {
        private readonly IUserRepository _repository;
        public UserManager(IUserRepository repository)
        {
            _repository = repository;
        }

        public void AddUser(User user)
        {
            // Cod pentru adăugarea unui utilizator
            Console.WriteLine($"Adding user: {user.UserName} with email: {user.Email}");

            // Cod specific pentru salvarea utilizatorului într-o bază de date
            _repository.Save(user);
        }

        // Metodă pentru ștergerea unui utilizator
        public void DeleteUser(User user)
        {
            // Cod pentru ștergerea unui utilizator
            Console.WriteLine($"Deleting user: {user.UserName}");

            // Cod specific pentru ștergerea utilizatorului din baza de date
            _repository.Delete(user.UserName);
        }

        // Metodă pentru actualizarea unui utilizator
        public void UpdateUser(User user)
        {
            // Cod pentru actualizarea unui utilizator
            Console.WriteLine($"Updating user: {user.UserName} with email: {user.Email}");
            user.Email = "Modifyied email";
            // Cod specific pentru actualizarea utilizatorului în baza de date
            _repository.Update(user);
        }
    }

    /*class UserManagerProgram
    {
        static void Main(string[] args)
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
    }*/

}
