using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Solid
{
    using System;

    // Superclasă pentru păsări
    class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }

    // Subclasă pentru pinguin, care nu poate zbura
    class Penguin : Bird
    {
        // Metoda Fly aruncă o excepție, deoarece pinguinii nu pot zbura
        public override void Fly()
        {
            throw new NotImplementedException("Penguins cannot fly.");
        }

        public void Swim()
        {
            Console.WriteLine("The penguin is swimming.");
        }
    }

    class BirdProgram
    {
        static void Main1(string[] args)
        {
            Bird myBird = new Bird();
            myBird.Fly();

            // Substituție incorectă, deoarece Penguin nu respectă comportamentul așteptat al lui Bird
            Bird myPenguin = new Penguin();
            try
            {
                myPenguin.Fly(); // Va arunca o excepție
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Accesarea metodei specifice subclasei
            Penguin penguin = new Penguin();
            penguin.Swim();
        }
    }

}
