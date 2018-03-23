using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaLiebreYTortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //oa :D
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtBoxRace.Clear();
            Turtle turtle = new Turtle("Turtle");
            Liebre liebre = new Liebre("Rabbit");

            race(turtle, liebre);
        }

        private void race(Turtle turtle, Liebre liebre)
        {
            int holderTurtle = 0;
            int holderLiebre = 0;

            while(holderTurtle < 80 && holderLiebre < 80)
            {
                holderTurtle += turtle.pasos();
                holderLiebre += liebre.pasos();

                txtBoxRace.Text += turtle.name + " ha dado: " + holderTurtle + " pasos" +
                    Environment.NewLine + liebre.name + " ha dado: " + holderLiebre + " pasos" +
                    Environment.NewLine + "----------------------------------------" +
                    Environment.NewLine;
            }
            ganador(holderTurtle, holderLiebre, turtle, liebre);
        }

        private void ganador(int holderT, int holderL, Turtle turtle, Liebre liebre)
        {
            if (holderT > holderL)
                txtBoxRace.Text += "GANADOR: " + turtle.name.ToUpper();
            else if (holderL < holderT)
                txtBoxRace.Text += "GANADOR: " + liebre.name.ToUpper();
            else
                txtBoxRace.Text += "EMPATE";
        }
    }
}
