namespace Exemple.Polimorifism
{
    public class Produs
    {
        public virtual void AfisareDetalii()
        {
            Console.WriteLine("Detalii produs");
        }
    }

    public class Carte : Produs
    {
        public new void AfisareDetalii()
        {
            Console.WriteLine("Cartea este interesanta");
        }
    }

    public class Electrocasnic : Produs
    {
        public new void AfisareDetalii()
        {
            Console.WriteLine("Electrocasnicul este bun");
        }

    }
}
