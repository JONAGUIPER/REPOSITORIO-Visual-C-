using EjemploClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploUsoClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Jon Ander";
            persona1.Apellido = "Aguinaco";
            persona1.DNI = "06640044J";
            DateTime cumple = persona1.Cumpleanos();

            Persona persona2 = new Persona()
            {
                Nombre = "Maihum",
                Apellido = "Melendez",
                DNI = "06640045Z"
            };



        }
    }
}
