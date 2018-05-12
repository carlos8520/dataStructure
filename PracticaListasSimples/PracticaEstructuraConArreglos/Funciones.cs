using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraConArreglos
{
    class Funciones
    {
        private Producto _inicio;

        public Producto inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }

        public Funciones()
        {
            inicio = null;
        }

        public void modInicio(Producto nuevo)
        {
            nuevo.Sig = _inicio;
            _inicio = nuevo;
        }

        public void agregarInicio(Producto nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
            }
            else
            {
                agregar(nuevo, _inicio);
            }
        }

        public void agregar(Producto nuevo, Producto quien)
        {
            if (quien.Sig == null)
            {
                quien.Sig = nuevo;
            }
            else
            {
                agregar(nuevo, quien.Sig);
            }
        }

        public string buscar(int id)
        {
            Producto p = _inicio;
            string r = " ";
            bool stop = false;
            while (stop != true)
            {
                if (p.id == id)
                {
                    r = p.ToString();
                    stop = true;
                }
                else
                {
                    p = p.Sig;
                }
            }

            return r;
        }

        public string listar()
        {
            Producto p = _inicio;
            string lista = "";

            while (p != null)
            {
                lista += p.ToString() + Environment.NewLine;
                p = p.Sig;
            }

            return lista;
        }

        public void eliminar(int id)
        {
            Producto temp;
            Producto p;
            bool stop = false;
            if (_inicio.id == id)
            {
                temp = _inicio;
                _inicio = _inicio.Sig;
                temp = null;
            }
            else
            {
                temp = _inicio.Sig;
                while (stop != true)
                {
                    if (temp.Sig.id == id)
                    {
                        p = temp.Sig;
                        temp.Sig = temp.Sig.Sig;
                        p = null;
                        stop = true;
                    }
                    else
                    {
                        temp = temp.Sig;
                    }
                }
            }
        }

        public void eliminarPrimero()
        {

            if (_inicio != null)
            {
                Producto p = _inicio;
                _inicio = _inicio.Sig;
                p = null;
            }

        }

        public void eliminarUltimo()
        {
            Producto p = _inicio;
            bool stop = false;

            while (stop != true)
            {
                if (p == null)
                {
                    stop = true;
                }
                else if (p.Sig == null)
                {
                    _inicio = null;
                    stop = true;
                }
                else if (p.Sig.Sig == null)
                {
                    p.Sig = null;
                    stop = true;
                }
                else
                {
                    p = p.Sig;
                }
            }
        }

        public void insertar(Producto n, int pos)
        {
            Producto p, t2;
            p = _inicio;
            if (pos == 1)
            {
                _inicio = n;
                _inicio.Sig = p;
            }
            else
            {
                for (int i = 1; i < pos - 1; i++)
                {
                    p = p.Sig;
                }
                t2 = p.Sig;
                p.Sig = n;
                p.Sig.Sig = t2;
            }
        }

        private string reporte(Producto lugar)
        {
            string temp = "";
            if (lugar.Sig != null)
            {
                temp = lugar.ToString() + Environment.NewLine;
                return reporte(lugar.Sig) + temp;
            }
            else
            {
                temp = lugar.ToString() + Environment.NewLine;
                return temp;
            }
        }

        public string listarInverso()
        {
            string r = "";
            if (_inicio != null)
            {
                r += reporte(_inicio);
            }
            return r;
        }
    }
}
