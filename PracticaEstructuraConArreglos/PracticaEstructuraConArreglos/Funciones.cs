using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraConArreglos
{
    class Funciones
    {
        private Producto[] _vec = new Producto[15];
        int registro = 0;

        public void agregar(Producto p)
        {
            _vec[registro] = p;
            registro++;
        }

        public Producto buscar(int id)
        {
            for (int i = 0; i < registro; i++)
            {
                if (_vec[i].id == id)
                {
                    return _vec[i];
                }
            }
            return null;
        }

        public void insertar(Producto p, int pos)
        {
            int n = _vec.Length;
            for (int i = pos; i < _vec.Length - 1; i++)
            {
                _vec[n] = _vec[n + 1];
                n--;
            }
            _vec[pos] = p;
            registro++;
        }

        public void eliminar(int id)
        {

            for (int i = 0; i < registro; i++)
            {
                if (_vec[i].id == id)
                    for (int j = i; j < registro; j++)
                        _vec[i] = _vec[i + 1];

            }
            _vec[registro - 1] = null;

            registro--;
        }

        public string listar()
        {
            string cadena = "";
            for (int i = 0; i < registro; i++)
            {
                cadena += _vec[i].ToString() + Environment.NewLine;
            }
            return cadena;
        }
    }
}
