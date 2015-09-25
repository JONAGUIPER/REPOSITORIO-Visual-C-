using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            string miNombre = string.Empty;
            
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                TxtNombre.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Ingrese su Nombre por Favor!!!");
            }
            else
            {
                miNombre = TxtNombre.Text;
                MessageBox.Show("Su Nombre es: " + miNombre);
            }

        }


    }
}
