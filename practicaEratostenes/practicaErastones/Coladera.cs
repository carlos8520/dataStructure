using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaErastones
{
    class Coladera
    {
        private int _lim;
        private int[] _vector;

        //encapsulado
        public int limite
        {
            get { return _lim; }
        }

        public int[] vec
        {
            get { return _vector; }
        }

        //builder
        public Coladera(int limite)
        {
            _lim = limite;
            _vector = new int[_lim];
        }

        //funciones
        public void llenar()
        {
            //esta función se encarga de llenar el vector de los valores, 
            //desde 0 hasta el valor del límite. 
            for(int i = 0; i < _lim; i++)
                _vector[i] = i + 1;
        }

        public void buscarPrimos()
        {
            //esta función se encarga de encontrar los valores que son primos en el vector
            int a = 0;
            int b = 2;
            for (int i = 0; i < _lim; i++)
            {
                if(Math.Pow(_vector[i], 2) < _lim)
                    a = _vector[i];
            }
            _vector[0] = 0;
            while(b <= a)
            {
                for(int i = b - 1; i > 1; i--)
                {
                    if (b % i == 0)
                        b++;
                }

                for(int i = 1; i < _lim; i++)
                {
                    if(_vector[i] != 0 && _vector[i] % b == 0 
                        && _vector[i] > b)
                        _vector[i] = 0;
                }
                b++;
            }
        }

        public int mostrar(int pos)
        {
            //esta función regresa los valores
            return _vector[pos];
        }
    }
}
