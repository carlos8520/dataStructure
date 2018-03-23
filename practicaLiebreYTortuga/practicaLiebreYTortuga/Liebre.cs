using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaLiebreYTortuga
{
    class Liebre:Corredor
    {
        private string _name;
        public string name
        {
            get { return _name; }
        }

        public Liebre(string name)
        {
            _name = name;
        }
        public int pasos()
        {
            if (correr() == 1 || correr() == 2)
                return 0;
            else if (correr() == 3 || correr() == 4)
                return 9;
            else if (correr() == 5)
                return -12;
            else if (correr() == 6 || correr() == 7 || correr() == 8)
                return 1;
            else
                return -2;

        }
    }
}
