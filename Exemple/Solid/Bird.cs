namespace Exemple.Solid
{
    interface IBird
    {
        void Move();
    }

    interface IFlyingBird : IBird
    {
        void Fly();
    }

    interface ISwimmingBird : IBird
    {
        void Swim();
    }


    // Subclasă pentru pinguin, care nu poate zbura
    class Penguin : ISwimmingBird
    {
        // Metoda Fly aruncă o excepție, deoarece pinguinii nu pot zbura
        public void Move()
        {
            Swim();
        }

        public void Swim()
        {
            Console.WriteLine("The bird is swimming.");
        }
    }

    class Cocostarc : IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }

        public void Move()
        {
            Fly();
        }
    }

    /*class BirdProgram
    {
        static void Main(string[] args)
        {
            IBird myBird = new Cocostarc();
            myBird.Move();

            // Substituție incorectă, deoarece Penguin nu respectă comportamentul așteptat al lui Bird
            IBird myPenguin = new Penguin();
            myPenguin.Move();
        }
    }*/

}
