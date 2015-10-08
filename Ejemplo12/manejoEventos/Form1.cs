using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejoEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RaiseEvent miObjetoDisparaEventos = new RaiseEvent();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //miObjetoDisparaEventos.miEvento += new EventHandler(Pepito);
            miObjetoDisparaEventos.miEvento += MiObjetoDisparaEventos_miEvento;
        }

        private void MiObjetoDisparaEventos_miEvento(object sender, EventArgs e)
        {
            MessageBox.Show("FORM: disparado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miObjetoDisparaEventos.Disparo();
        }
    }
}
