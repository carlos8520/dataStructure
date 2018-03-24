using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaErastones
{
    public partial class Form1 : Form
    {
        //Inicialización del objeto
        Coladera col;

        public Form1()
        {
            InitializeComponent();
            //Asignación de valor al objeto
            col = new Coladera(1000);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            txtBoxAnswer.Clear();
            mostrarValores();
        }

        private void mostrarValores()
        {
            //Esta función se encarga de mandar llamar los métodos de la clase del objeto
            // Y de mostrar los valores obtenidos en el objeto TextBox
            col.llenar();
            col.buscarPrimos();
            for (int i = 0; i < col.limite; i++)
            {
                int n = col.mostrar(i);
                if (n != 0)
                    txtBoxAnswer.Text += n + ", ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //:D
        }
    }
}
