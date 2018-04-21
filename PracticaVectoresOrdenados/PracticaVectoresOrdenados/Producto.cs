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
        private double _costo;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public double costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public Producto(int id, string nombre, int cantidad, double costo)
        {
            this._id = id;
            this._nombre = nombre;
            this._cantidad = cantidad;
            this._costo = costo;
        }

        public override string ToString()
        {
            return "El id del producto es: " + _id + ", el nombre es:  " + _nombre +
                ", la cantidad de stock del producto es: " + _cantidad + " y su costo por unidad: $" + _costo;
        }
    }
}
