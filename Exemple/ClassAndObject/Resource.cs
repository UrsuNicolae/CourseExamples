namespace Exemple.ClassAndObject
{
    public class Resource
    {
        private string filePath;
        private bool resourceUsed;

        public Resource(string filePath)
        {
            this.filePath = filePath;
            Console.WriteLine($"Resursa a fost utilizata: {resourceUsed}");
        }

        ~Resource()
        {
            Console.WriteLine("Destructorul a fost chemat!");
        }

        public void UseResource()
        {
            if( resourceUsed )
            {
                Console.WriteLine("Resursa a fost utilizata deja!");
            }
            else
            {
                resourceUsed = true;
                Console.WriteLine("Utilizam resursa!");
            }
        }
    }
}
