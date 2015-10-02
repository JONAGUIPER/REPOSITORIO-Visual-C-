using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string RUTA = @"C:\Users\Desarrollo web\Desktop\JON A. AGUINACO";
        //const string RUTA = @"C:\Users\Desarrollo web\Documents";
        private void Form1_Load(object sender, EventArgs e)
        {

            //string RUTA = new DirectoryInfo(RUTA).Name;
            if (Directory.Exists(RUTA))
            {
                string[] directorios = Directory.GetDirectories(RUTA);
                foreach (var item in directorios)
                {
                    cbDirectorios.Items.Add(new DirectoryInfo(item).Name);
                }
            }
        }

        private void cbDirectorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDirectorios2.Items.Clear();
            cbDirectorios2.Text = "";
            lblDirectorios2.Text = cbDirectorios.Text;

            string path2 = cbDirectorios.SelectedItem.ToString();
            string path = RUTA + @"/" + path2;
            //PARA OBTENER EL ULTIMO ACCESO AL DIRECTORIO
            lblAcceso.Text = "Último acceso: " + Convert.ToString(Directory.GetLastAccessTime(path));
            if (Directory.Exists(path))
            {
                try //para manejar la excepcion por restricciones de usuario
                {
                    string[] directorios = Directory.GetFileSystemEntries(path);
                    if (directorios.Length == 0)
                    {
                        MessageBox.Show("El directorio se encuentra vacio");
                    }
                    else
                    {
                        foreach (var item in directorios)
                        {
                            cbDirectorios2.Items.Add(new DirectoryInfo(item).Name);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string ubicacion = RUTA + @"\" + cbDirectorios.Text + @"\" + cbDirectorios2.Text;
            if (File.Exists(ubicacion))
            {
                txtEditor.Text = File.ReadAllText(ubicacion);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ubicacion = RUTA + @"\" + cbDirectorios.Text + @"\" + cbDirectorios2.Text;
            if (MessageBox.Show("Desea guardar el Archivo?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText(ubicacion, txtEditor.Text);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ubicacion = RUTA + @"\" + cbDirectorios.Text + @"\" + cbDirectorios2.Text;
            File.AppendAllText(ubicacion, "\r\n" + txtInsertar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDirectorios2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPath.Text = "Se encuentra en: " + Path.GetFullPath(cbDirectorios2.Text);
        }

        private void btnFormAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog miFormularioAbrir = new OpenFileDialog();
            miFormularioAbrir.Title = "Indique el Archivo a Abrir";
            miFormularioAbrir.Filter = "Word (*.doc)|*.doc|Texto (*.txt)|*.txt|Todos los archivos(*.*)|*.*;";

            miFormularioAbrir.ShowDialog();
            string archivo = miFormularioAbrir.FileName;
            if (archivo != string.Empty)
            {
                txtEditor.Text = File.ReadAllText(archivo);
                lblPath.Text = archivo;
            }

        }
    }
}
