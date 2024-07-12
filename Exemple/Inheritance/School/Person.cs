namespace Exemple.Inheritance.School
{
    public class Person
    {
        internal string Name { get; set; }
        public int Age { get; set; }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return  "Name: " + Name + ", Age: " + Age;
        }
    }

    public class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
        }

        public new string ToString()
        {
            return base.ToString() + ", Grade: " + Grade;
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public new string ToString()
        {
            return base.ToString() + ", Subject: " + Subject;
        }
    }   
}
