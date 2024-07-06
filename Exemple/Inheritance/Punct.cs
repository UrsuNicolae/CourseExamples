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
        public void Scrie()
        {
            Console.WriteLine("Punct: {0}, {1}", x, y);
        }
    }

    public class Linie : Punct
    {
        public int xEnd;
        public int yEnd;
        public new void Scrie()
        {
            x = 2; y = 2;//acces la membrii din clasa de baza
            Console.WriteLine("Segement: ({0}, {1}) - ({2}, {3})", x, y, xEnd, yEnd);
        }
    }

}
