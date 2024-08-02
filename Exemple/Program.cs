using Exemple.Solid;

namespace Exemple
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var user = new User
            {
                UserName = "JohnDoe",
                Email = "Email test"
            };
            IUserRepository rep = new UserRepository();
            var userManager = new UserManager(rep);

            userManager.AddUser(user);
            userManager.UpdateUser(user);
            userManager.DeleteUser(user);
        }
    }
}
