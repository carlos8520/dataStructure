using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaLiebreYTortuga
{
    class Turtle:Corredor
    {
        private string _name;
        public string name
        {
            get { return _name; }
        }
        public Turtle(string name)
        {
            _name = name;
        }
        public int pasos()
        {
            if (correr() == 1 || correr() == 2 || correr() == 3 ||
                correr() == 4 || correr() == 5)
                return 3;
            else if (correr() == 6 || correr() == 7)
                return -6;
            else
                return 1;
        }
    }
}
