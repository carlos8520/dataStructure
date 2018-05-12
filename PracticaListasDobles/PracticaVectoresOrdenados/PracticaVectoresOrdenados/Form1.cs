using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaVectoresOrdenados
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
            int lim;
            if (txtBoxID.Text == "" || txtBoxCosto.Text == "" ||
                txtBoxNombre.Text == "" || txtBoxCantidad.Text == "")
            {
                MessageBox.Show("Datos requeridos para continuar");
            }
            else
            {
                lim = Convert.ToInt32(txtBoxID.Text);
                p = new Producto(lim, txtBoxNombre.Text, Convert.ToInt32(txtBoxCantidad.Text),
                    Convert.ToInt32(txtBoxCosto.Text));

                func.agregar(p);
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
            if (txtBoxID.Text == "")
                MessageBox.Show("Por favor ingrese el código del producto");
            else
            {
                int id = Convert.ToInt32(txtBoxID.Text);
                txtBoxID.Clear();
                txtBoxInv.Clear();
                txtBoxInv.Text = func.buscar(id);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtBoxID.Text == "")
                MessageBox.Show("Por favor ingrese el código del producto");
            else
            {
                if (func.eliminar(Convert.ToInt32(txtBoxID.Text)))
                {
                    MessageBox.Show("El producto ha sido eliminado");
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser eliminado");
                }
            }
        }

        private void btnListarUlt_Click(object sender, EventArgs e)
        {
            txtBoxInv.Clear();
            txtBoxInv.Text = func.listarInverso();
        }

        private void btnDelPrimero_Click(object sender, EventArgs e)
        {
            if (func.eliminarPrimero() == false)
            {
                MessageBox.Show("No hay productos en la lista");
            }
            else
            {
                txtBoxInv.Text = func.listar();
            }
        }

        private void btnDelUltimo_Click(object sender, EventArgs e)
        {
            func.eliminarUltimo();
            txtBoxInv.Text = func.listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           
        }       
    }
}
