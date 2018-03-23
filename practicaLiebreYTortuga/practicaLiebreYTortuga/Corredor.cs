using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaLiebreYTortuga
{
    abstract class Corredor
    {
        static protected Random rnd;

        public Corredor()
        {
            rnd = new Random();
        }

        public int correr()
        {
            return rnd.Next(1, 11);
        }
    }
}
