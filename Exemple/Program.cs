using Exemple.Polimorifism;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstArtist = new SoloArtist("Jon", "Pop", "Guitar");
            var secondArtist = new Band("Gandul Matei", "Pop", 5);
            var thirdArtist = new DJ("Hardwell", "Electro", "House");

            var event1 = new PrivateEvent("Chisinau", new DateTime(2025, 1, 1), firstArtist);
            var event2 = new PublicEvent("Chisinau", new DateTime(2025, 2, 2), secondArtist, new List<Artist> { thirdArtist });

            event1.DisplayDetails();
            event2.DisplayDetails();
        }
    }
}
