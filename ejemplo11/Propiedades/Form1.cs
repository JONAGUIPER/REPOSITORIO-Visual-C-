﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            alumnos2 = new List<Alumno>()
            {
                new Alumno() {NombreAlumno="Martin" },
                new Alumno() {NombreAlumno="Idola" },
                new Alumno() {NombreAlumno="Ana" },
                new Alumno() {NombreAlumno="Patxi" },
                new Alumno() {NombreAlumno="periko" }
            };
        }

        List<Alumno> Alumnos = new List<Alumno>();
        List<Alumno> alumnos2;

        

        private void btnAnadirAlumno_Click(object sender, EventArgs e)
        {

            Alumno nuevoAlumno;
            if (!String.IsNullOrWhiteSpace(txtNombreAlumno.Text))
            {
                nuevoAlumno = new Alumno(txtNombreAlumno.Text);
                txtNombreAlumno.Text = String.Empty;
            }
            else
            {
                nuevoAlumno = new Alumno();
            }
            Alumnos.Add(nuevoAlumno);
            txtIdAlumno.Text = nuevoAlumno.IdAlumno.ToString();
            //txtNombreAlumno.Text = nuevoAlumno.NombreAlumno;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int actualConvertido = Convert.ToInt32(txtIdAlumno.Text) - 1;
            if ((Alumnos.Count > 0) && Convert.ToInt32(txtIdAlumno.Text) > 1)
            {
                txtIdAlumno.Text = (Convert.ToInt32(txtIdAlumno.Text) - 1).ToString();
                txtNombreAlumno.Text = Alumnos[actualConvertido - 1].NombreAlumno;
                //puede servir tambien
                //txtIdAlumno.Text= Alumnos.Find(a => a.IdAlumno == actualConvertido + 1).IdAlumno.ToString();
                //txtNombreAlumno.Text = Alumnos.Find(a => a.IdAlumno == actualConvertido + 1).NombreAlumno;
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int actualConvertido = Convert.ToInt32(txtIdAlumno.Text) - 1;
            if ((Alumnos.Count > 0) && Convert.ToInt32(txtIdAlumno.Text) < Alumnos.Count)
            {
                txtIdAlumno.Text = (Convert.ToInt32(txtIdAlumno.Text) + 1).ToString();
                txtNombreAlumno.Text = Alumnos[actualConvertido + 1].NombreAlumno;
            }
            else if (Convert.ToInt32(txtIdAlumno.Text) == Alumnos.Count)
            {
                txtIdAlumno.Text = (Convert.ToInt32(txtIdAlumno.Text) + 1).ToString();
                txtNombreAlumno.Text = String.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIdAlumno.Text = "1";
            Alumno alumnoUno = new Alumno()
            {
                NombreAlumno = "mike"
            };


            Indexador indexador = new Indexador();
            var alumnoMartin = indexador["Martin"];
            indexador.alumnos2.Add(new Alumno("Jon Ander"));
            indexador["periko"] = alumnoMartin;
            indexador["Jon Ander"].NombreAlumno = "perikito";
        }
    }
}
