using System.Diagnostics.Metrics;

namespace Exemple.Polimorifism
{
    public abstract class Artist
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        protected Artist(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        public abstract void DisplayDetails();
    }

    public class SoloArtist : Artist
    {
        public string Instrument { get; set; }
        public SoloArtist(string name, string genre, string instrument) : base(name, genre)
        {
            Instrument = instrument;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Solo musician: {Name}, Genre: {Genre}, Instrument: {Instrument}");
        }
    }

    public class Band : Artist
    {
        public int NumberOfMembers { get; set; }
        public Band(string name, string genre, int numberOfMembers) : base(name, genre)
        {
            NumberOfMembers = numberOfMembers;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Band musician: {Name}, Genre: {Genre}, Members: {NumberOfMembers}");
        }
    }

    public class DJ : Artist
    {
        public string Style { get; set; }
        public DJ(string name, string genre, string style) : base(name, genre)
        {
            Style = style;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Band musician: {Name}, Genre: {Genre}, Syle: {Style}");
        }
    }

    public abstract class Eveniment
    {
        public string Location { get; set; }
        public DateTime DateTime { get; set; }

        public Eveniment(string location, DateTime dateTime)
        {
            Location = location;
            DateTime = dateTime;
        }

        public abstract void DisplayDetails();

    }

    public class PrivateEvent : Eveniment
    {
        public PrivateEvent(string location, DateTime dateTime, Artist mainArtist) : base(location, dateTime)
        {
            MainArtist = mainArtist;
        }

        public Artist MainArtist { get; private set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Private event hosted by {MainArtist.Name}");
            MainArtist.DisplayDetails();
        }
    }

    public class PublicEvent : Eveniment
    {

        public PublicEvent(string location, DateTime dateTime, Artist mainArtist, List<Artist> artists) : base(location, dateTime)
        {
            MainArtist = mainArtist;
            Artists = artists;
        }

        public Artist MainArtist { get; private set; }

        public List<Artist> Artists { get; private set; }


        public override void DisplayDetails()
        {
            Console.WriteLine($"Public event hosted by {MainArtist.Name}");
            MainArtist.DisplayDetails();
            Console.WriteLine("Other artists");
            foreach(var artist in Artists)
            {
                artist.DisplayDetails();
            }
        }
    }
}
