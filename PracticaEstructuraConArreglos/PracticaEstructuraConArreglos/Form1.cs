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
            Producto p = new Producto(Convert.ToInt32(txtBoxID.Text), txtBoxNombre.Text, 
                Convert.ToInt32(txtBoxCantidad.Text), Convert.ToDouble(txtBoxCosto.Text));
            func.agregar(p);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBoxInv.Text = func.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (func.buscar(Convert.ToInt32(txtBoxBuscar.Text)) != null)
            {
                txtBoxInv.Text = func.buscar(Convert.ToInt32(txtBoxBuscar.Text)).ToString();
            }
            else
            {
                txtBoxInv.Text = "Error 404 Not Found";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtBoxID.Text == "")
                MessageBox.Show("Escriba el Id del producto que desea eliminar");
            else
                if (func.buscar(Convert.ToInt16(txtBoxID.Text)) == null)
                MessageBox.Show("Este producto no existe");
            else
                func.eliminar(Convert.ToInt16(txtBoxID.Text));
            txtBoxInv.Text = func.listar();


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(Convert.ToInt32(txtBoxID.Text), txtBoxNombre.Text, 
                Convert.ToInt32(txtBoxCantidad.Text), Convert.ToDouble(txtBoxCosto.Text));
            func.insertar(p, Convert.ToInt32(txtBoxInsertar.Text));
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
