namespace Exemple.Inheritance.Animal
{
    public interface IAnimal
    {
        void Eat();
    }

    public interface IPet
    {
       void Play();
    }

    public interface ICat : IAnimal, IPet
    {
        void Meow();
    }

    public interface IBird : IAnimal
    {
        void Fly();
    }
}
