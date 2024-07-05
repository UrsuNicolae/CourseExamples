namespace Exemple.ClassAndObject
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "Nume invalid";
            Age = -1;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Numele persoanei este: {Name}, Varsta este: {Age}");
        }
    }
}
