namespace Exemple
{
    internal class Program
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

        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person("Nicu", 10);

            p.DisplayInfo();
            p2.DisplayInfo();
        }
    }
}
