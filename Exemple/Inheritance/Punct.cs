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

        public Punct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Scrie()
        {
            Console.WriteLine("Punct: {0}, {1}", x, y);
        }
    }

    class Linie : Punct
    {
        public int xEnd;
        public int yEnd;
        public new void Scrie()
        {
            Console.WriteLine("Segement: ({0}, {1}) - ({2}, {3})", x, y, xEnd, yEnd);
        }
        //Constructorul clasei derivate
        public Linie(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            x = x1; y = y1;
            xEnd = x2; yEnd = y2;
        }
    }
}
