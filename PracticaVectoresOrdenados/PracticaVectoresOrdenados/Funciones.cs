using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaVectoresOrdenados
{
    class Funciones
    {
        private Producto[] _vec = new Producto[15];
        int registro = 0;

        public Producto[] producto
        {
            get { return _vec; }
            set { _vec = value; }
        }

        public void Registro(int lim)
        {
            producto = new Producto[lim];
            registro = 0;
        }

        public bool agregar(Producto p)
        {
            bool state = false;
            if (registro != 0)
            {
                for (int i = 0; i < registro; i++)
                {
                    if (p.id < producto[i].id)
                    {
                        insertar(p, i);
                        state = true;
                        break;
                    }
                    else if (i == (registro - 1))
                    {
                        producto[registro] = p;
                        state = true;
                    }
                }
            }
            else
            {
                producto[registro] = p;
                state = true;
            }
            registro++;
            return state;
        }

        public Producto buscar(int id)
        {
            int posMayor = registro - 1;
            int posMenor = 0;

            while (posMenor <= posMayor)
            {
                int posMedia = posMenor + (posMayor - posMenor) / 2;
                if (id < producto[posMedia].id)
                {
                    posMayor = posMedia - 1;
                }
                else if (id > producto[posMedia].id)
                {
                    posMenor = posMedia + 1;
                }
                else
                {
                    return producto[posMedia];
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

        public bool eliminar(int id)
        {
            bool state = false;
            for (int i = 0; i < registro; i++)
            {
                if (producto[i].id == id)
                {
                    recorrerPos(i);
                    id--;
                    state = true;
                    break;
                }
            }
            return state;
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

        public void recorrerPos(int pos)
        {
            for (int i = pos; i < registro - 1; i++)
            {
                producto[i] = producto[i + 1];
            }
        }
    }
}
