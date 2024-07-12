using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Inheritance
{
    public class Punct
    {
        protected int x;
        protected int y;
        //Constructorul clasei de bază
        public Punct(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("Constructor din clasa derivata");
        }
        public void Scrie()
        {
            Console.Write("({0}, {1})", x, y);
        }
    }
    public class Linie : Punct
    {

        public int xEnd;
        public int yEnd;

        static Linie()
        {

           Console.WriteLine("Constructor static din clasa Linie");
        }
        public new void Scrie()
        {
            Console.Write("Segment: ");
            base.Scrie();//Apelul metodei din clasa de bază
            Console.WriteLine(" - ({0}, {1})", xEnd, yEnd);
        }
        //Constructorul clasei derivate
        public Linie(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            xEnd = x2; yEnd = y2;
            Console.WriteLine("Constructor din clasa Linie");
        }
    }

}
