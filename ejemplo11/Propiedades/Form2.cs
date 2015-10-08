using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propiedades
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Indexador alumnos = new Indexador();
        Label lblDatosAlumno = new Label();
        private void Form2_Load(object sender, EventArgs e)
        {
            btnSumar.ForeColor = Color.Black;


            lblDatosAlumno.AutoSize = true;
            //lblDatosAlumno.Enabled = true;
            lblDatosAlumno.Parent = this;
            lblDatosAlumno.Left = 25;
            lblDatosAlumno.Top = 25;
            
            lblDatosAlumno.Font = new Font(this.Font.FontFamily, 15F,FontStyle.Bold);
            lblDatosAlumno.Text = "Aun no tengo datos";
            lblDatosAlumno.Click += LblDatosAlumno_Click;//suscribir evento
            //lblDatosAlumno.Click -= LblDatosAlumno_Click;//desuscribir evento

            for (int i = 0; i < alumnos.Count; i++)
            {
                lstIds.Items.Add(alumnos[i].IdAlumno + "\t" + alumnos[i].NombreAlumno);
            }

        }

        private void LblDatosAlumno_Click(object sender, EventArgs e)
        {
            //mostrar en el label ID: nº, Nombre: nombre
            try
            {
                lblDatosAlumno.Text = "ID: " +
                                alumnos[lblDatosAlumno.Text].IdAlumno +
                                ", NOMBRE: " + alumnos[lblDatosAlumno.Text].NombreAlumno;
            }
            catch (Exception)
            {
                lblDatosAlumno.Text = "ID: " +
                               alumnos[lstIds.SelectedIndex].IdAlumno +
                               ", NOMBRE: " + alumnos[lstIds.SelectedIndex].NombreAlumno;
            }

        }

        private void lstIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDatosAlumno.Text = alumnos[lstIds.SelectedIndex].NombreAlumno;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lblDatosAlumno.Text = (new Alumno() { NombreAlumno = "Jon A" })+ (new Alumno() { NombreAlumno = "Maihum" });
        }
    }
}
