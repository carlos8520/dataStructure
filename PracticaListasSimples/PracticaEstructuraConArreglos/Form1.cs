using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEstructuraConArreglos
{
    public partial class Form1 : Form
    {
        Funciones func; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            func = new Funciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p;
            if (txtBoxID.Text == "" || txtBoxCosto.Text == "" ||
                txtBoxNombre.Text == "" || txtBoxCantidad.Text == "")
            {
                MessageBox.Show("Hay espacios en blanco, favor de verificar");
            }
            else
            {
                p = new Producto(Convert.ToInt32(txtBoxID.Text), txtBoxNombre.Text,
                    Convert.ToInt32(txtBoxCantidad.Text), Convert.ToInt32(txtBoxCosto.Text));

                func.agregarInicio(p);
                txtBoxID.Clear();
                txtBoxCosto.Clear();
                txtBoxNombre.Clear();
                txtBoxCantidad.Clear();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBoxInv.Clear();
            txtBoxInv.Text = func.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBoxInv.Clear();
            int id;
            if (txtBoxBuscar.Text == "")
            {
                MessageBox.Show("Por favor ingrese el código del producto");
            }
            else
            {
                id = Convert.ToInt32(txtBoxBuscar.Text);
                txtBoxInv.Text = func.buscar(id);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtBoxEliminar.Text == "")
                MessageBox.Show("Escriba el Id del producto que desea eliminar");
            else
                if (func.buscar(Convert.ToInt16(txtBoxEliminar.Text)) == null)
                MessageBox.Show("Este producto no existe");
            else
                func.eliminar(Convert.ToInt16(txtBoxEliminar.Text));
            txtBoxInv.Text = func.listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto p;
            if (txtBoxInsertar.Text == "")
            {
                MessageBox.Show("Ingrese el número de posición en la que quiere ingresar" +
                    "el producto");
            }
            else
            {
                int pos = Convert.ToInt32(txtBoxInsertar.Text);

                p = new Producto(Convert.ToInt32(txtBoxID.Text), txtBoxNombre.Text,
                    Convert.ToInt32(txtBoxCantidad.Text), Convert.ToInt32(txtBoxCosto.Text));

                func.insertar(p, pos);
                txtBoxID.Clear();
                txtBoxCosto.Clear();
                txtBoxNombre.Clear();
                txtBoxCantidad.Clear();
                txtBoxBuscar.Clear();
            }
        }

        private void btnAgregarPrimero_Click(object sender, EventArgs e)
        {
            Producto p;
            if (txtBoxID.Text == "" || txtBoxCosto.Text == "" ||
                txtBoxNombre.Text == "" || txtBoxCantidad.Text == "")
            {
                MessageBox.Show("Hay espacios en blanco, favor de verificar");
            }
            else
            {
                p = new Producto(Convert.ToInt32(txtBoxID.Text), txtBoxNombre.Text,
                    Convert.ToInt32(txtBoxCantidad.Text), Convert.ToInt32(txtBoxCosto.Text));

                func.modInicio(p);
                txtBoxID.Clear();
                txtBoxCosto.Clear();
                txtBoxNombre.Clear();
                txtBoxCantidad.Clear();
            }
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtBoxInv.Clear();
            txtBoxInv.Text = func.listar();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            func.eliminarPrimero();
            txtBoxInv.Text = func.listar();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            func.eliminarUltimo();
            txtBoxInv.Text = func.listar();
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInvertirLista_Click(object sender, EventArgs e)
        {
            txtBoxInv.Clear();
            func.listarInverso();
        }
    }
}
