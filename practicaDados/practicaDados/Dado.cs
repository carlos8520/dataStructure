using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDados
{
    class Dado
    {
        int _cara = 0;
        //int _cara2 = 0; 
        static Random rnd1;
        //Random rnd2;

        public Dado()
        {
            rnd1 = new Random();
            //rnd2 = new Random();
        }

        public int lanzarDado()
        {
            _cara = rnd1.Next(1, 7);
            return _cara;
        }
        
        /*public int lanzarDadoToPro()
        {
            _cara = rnd2.Next(1, 7);
            return _cara;
        }*/
    }
}

