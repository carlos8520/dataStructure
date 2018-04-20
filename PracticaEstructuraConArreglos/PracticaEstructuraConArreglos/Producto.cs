using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraConArreglos
{
    class Producto
    {
        private int _id;
        private string _nombre;
        private int _cantidad;
        private double _costo;

        public int id {
            get {
                return _id;
            }
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
