using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDados
{
    public partial class Form1 : Form
    {

        Dado dado;
        Dado dado2;
        int[] caras;
        int[] parte2;
        int[] sumas;
        int cara = 0;
        int parte = 0;
        int suma = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dado = new Dado();
            dado2 = new Dado();
            caras = new int[6];
            parte2 = new int[12];
            sumas = new int[12];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                cara = dado.lanzarDado();
                caras[cara - 1]++;
            }

            for(int i = 0; i < caras.Length; i++)
            {
                txtBox1.Text += "La cara " + (i + 1) + " cayó " + caras[i] + " veces" + Environment.NewLine;
            }
        }

        private void btnLanzar2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                cara = dado.lanzarDado();
                caras[cara - 1]++;
                parte = dado.lanzarDado() + dado.lanzarDado();
                parte2[parte - 2]++;
            }

            for (int i = 0; i < parte2.Length; i++)
            {
                txtBox1.Text += "La cara " + (i + 1) + " cayó " + parte2[i] + " veces" + Environment.NewLine;
            }
        }

        private void btn2Dados_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                cara = dado.lanzarDado();
                caras[cara - 1]++;
                suma = dado.lanzarDado() + dado2.lanzarDado();
                sumas[suma - 2]++;
            }

            for (int i = 0; i < sumas.Length - 1; i++)
            {
                txtBox1.Text += "La cara " + (i + 2) + " cayó " + sumas[i] + " veces" + Environment.NewLine;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox1.Text = " ";
            
            for(int i = 0; i < caras.Length; i++)
            {
                caras[i] = 0;
            }

            for(int i = 0; i < sumas.Length; i++)
            {
                sumas[i] = 0;
            }
        }
    }
}
