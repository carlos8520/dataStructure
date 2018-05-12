using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaVectoresOrdenados
{
    class Producto
    {
        private int _id;
        private string _nombre;
        private int _cantidad;
        private int _costo;
        private Producto _atras;
        private Producto _siguiente;

        public int id
        {
            get { return _id; }
        }

        public string nombre
        {
            get { return _nombre; }
        }

        public int cantidad
        {
            get { return _cantidad; }
        }

        public int costo
        {
            get { return _costo; }
        }

        public Producto atras
        {
            get { return _atras; }
            set { _atras = value; }
        }

        public Producto siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Producto(int id, string nombre, int cantidad, int costo)
        {
            _id = id;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
            _siguiente = null;
            _atras = null;
        }

        public override string ToString()
        {
            return "El id del producto es: " + _id + ", el nombre es:  " + _nombre +
                ", la cantidad de stock del producto es: " + _cantidad + " y su costo por unidad: $" + _costo;
        }
    }
}
