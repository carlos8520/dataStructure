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
            if (txtBoxID.Text == "" || txtBoxNombre.Text == ""
               || txtBoxCantidad.Text == "" || txtBoxCosto.Text == "")
            {
                MessageBox.Show("Verifique que los campos tengan la información requerida");
            }
            else
            {
                Producto p = new Producto(Convert.ToInt32(txtBoxID.Text), txtBoxNombre.Text,
                Convert.ToInt32(txtBoxCantidad.Text), Convert.ToDouble(txtBoxCosto.Text));

                if(func.agregar(p))
                {
                    txtBoxID.Clear(); txtBoxNombre.Clear(); txtBoxCantidad.Clear(); txtBoxCosto.Clear();
                }
                else
                {
                    MessageBox.Show("No se puedo agregar el producto");
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBoxInv.Text = func.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxID.Text == "")
            {
                MessageBox.Show("Ingrese el código del artículo");
            }
            else
            {
                if(func.buscar(Convert.ToInt32(txtBoxBuscar.Text)) != null)
                {
                    txtBoxInv.Clear();
                    txtBoxInv.Text = func.buscar(Convert.ToInt32(txtBoxID.Text)).ToString();
                }
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
    }
}
