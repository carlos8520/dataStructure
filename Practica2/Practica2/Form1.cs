using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            char b = 'B';
            char m = 'M';
            int tamanoReal = 0;
            int alto = 0;
            int ancho = 0;
            int bitsPerPixel = 0;
            BinaryReader bmpFile;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            Convert.ToString(openFileDialog1.ShowDialog());

            FileStream archivo = new FileStream(openFileDialog1.FileName, FileMode.Open);
            bmpFile = new BinaryReader(archivo);

            bmpFile.BaseStream.Seek(0, SeekOrigin.Begin);
            if(b == Convert.ToChar(bmpFile.ReadChar()) && m == Convert.ToChar(bmpFile.ReadChar()))
            {
                lblValidación.Text = "Este es un archivo de formato .bmp";
            }
            else
            {
                lblValidación.Text = "Este archivo no es de formato .bmp";
            }

            bmpFile.BaseStream.Seek(2, SeekOrigin.Begin);
            //Obtener el tamaño real del archivo
            tamanoReal = bmpFile.ReadInt32();
            txtBoxTamanoBytes.Text = Convert.ToString(tamanoReal);

            bmpFile.BaseStream.Seek(18, SeekOrigin.Begin);
            //Obtener el ancho de la imagen
            ancho = bmpFile.ReadInt32();
            txtBoxAncho.Text = Convert.ToString(ancho);
            //Obtener el alto de la imagen
            alto = bmpFile.ReadInt32();
            txtBoxAlto.Text = Convert.ToString(alto);
            //Obtener los bits por pixel
            bitsPerPixel = bmpFile.ReadInt16();
            txtBoxBitsPixel.Text = Convert.ToString(bitsPerPixel);

            bmpFile.Close();
        }
    }
}
