﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataContex;

namespace ManejoBibliotecaClases
{
    public partial class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            InitializeComponent();
        }
        public FormNuevoCliente(TablaClientes Clientes)
        {
            InitializeComponent();
            TablaClientes clietitos = new TablaClientes();
            clietitos.insertOK += Clietitos_insertOK;
            
        }

        private void Clietitos_insertOK(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
