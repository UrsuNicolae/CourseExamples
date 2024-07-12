namespace Exemple.Inheritance.DiamondProblem
{
    public interface IDiamond
    {
        void DoWork();
    }

    public interface ILeft : IDiamond
    {
    }

    public interface IRight : IDiamond
    {
    }

    public class Diamond : ILeft, IRight
    {
        public void DoWork()
        {
            Console.WriteLine("Doing work");
        }
    }
}
