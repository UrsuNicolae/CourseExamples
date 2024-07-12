namespace Exemple.Inheritance.Animal
{
    public class Animal : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Cat : Animal, ICat
    {
        public void Meow()
        {
            Console.WriteLine("Cat is meowing");
        }

        public void Play()
        {
            Console.WriteLine("Cat is playing");
        }
    }

    public class Bird : Animal, IBird
    {
        public new void Eat()
        {
            Console.WriteLine("Bird is eating");
        }
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
