using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaVectoresOrdenados
{
    class Funciones
    {

        private int _limite;
        private Producto _inicio;

        public Producto inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }

        public Funciones()
        {
            _limite = 0;
            _inicio = null;
        }

        public void agregar(Producto nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                _limite++;
            }
            else
                agregar(nuevo, _inicio);
        }

        public void agregar(Producto nuevo, Producto quien)
        {
            if (_limite < 15)
            {
                if (quien.id > nuevo.id)
                {
                    if (quien.atras == null)
                    {
                        Producto producto = quien;
                        _inicio = nuevo;
                        _inicio.siguiente = p;
                        p.atras = _inicio;
                        _limite++;
                    }
                    else
                    {
                        quien.atras.siguiente = nuevo;
                        nuevo.atras = quien.atras;
                        nuevo.siguiente = quien;
                        quien.atras = nuevo;
                        _limite++;
                    }

                }
                else if (quien.siguiente == null && quien.id < nuevo.id)
                {
                    quien.siguiente = nuevo;
                    nuevo.atras = quien;
                }
                else
                {
                    agregar(nuevo, quien.siguiente);
                }
            }
        }

        public string listar()
        {
            string r = "";
            Producto p = _inicio;

            while (p != null)
            {
                r += p.ToString() + Environment.NewLine;
                p = p.siguiente;
            }
            return r;
        }

        public string buscar(int id)
        {
            string r = "";
            bool stop = true;
            Producto p = _inicio;

            while (stop)
            {
                if (p == null)
                {
                    r = "El producto no existe";
                    stop = false;
                }
                else if (p.id == id)
                {
                    r = p.ToString();
                    stop = false;
                }
                else
                {
                    p = p.siguiente;
                }
            }
            return r;
        }

        public bool eliminar(int id)
        {
            bool test = false;
            Producto p = _inicio;
            while (p != null)
            {
                if (p.id == id)
                {
                    p.atras.siguiente = p.siguiente;
                    p.siguiente.atras = p.atras;
                    p = null;
                    test = true;
                }
                else
                {
                    p = p.siguiente;
                }
            }
            return test;
        }

        public bool eliminarPrimero()
        {
            Producto p = _inicio;

            if (p == null)
                return false;
            else
            {
                _inicio = p.siguiente;
                p = null;
                return true;
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
                else if (p.siguiente == null)
                {
                    _inicio = null;
                    stop = true;
                }
                else if (p.siguiente.siguiente == null)
                {
                    p.siguiente = null;
                    stop = true;
                }
                else
                {
                    p = p.siguiente;
                }
            }
        }

        private string reporte(Producto lugar)
        {
            string report = "";
            if (lugar.siguiente != null)
            {
                report = lugar.ToString() + Environment.NewLine;
                return reporte(lugar.siguiente) + report;
            }
            else
            {
                report = lugar.ToString() + Environment.NewLine;
                return report;
            }
        }

        public string listarInverso()
        {
            string lista = "";
            if (inicio != null)
            {
                lista += reporte(inicio);
            }
            return lista;
        }
    }
}
