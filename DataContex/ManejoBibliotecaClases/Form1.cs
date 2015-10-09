using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TablaClientes Clientes = new TablaClientes();
        TablaPedidos Pedidos = new TablaPedidos();
        private void Form1_Load(object sender, EventArgs e)
        {


            Clientes.clientes.Add(new Cliente { Id = 1, NombreCompania = "MEDIAMARK", PersonaContacto = "Jose Perez", TlfContacto = "+34005555", ListaPedidos = new List<Pedido>() });
            Clientes.clientes.Add(new Cliente { Id = 2, NombreCompania = "Presto", PersonaContacto = "Juan Perez", TlfContacto = "+34000000", ListaPedidos = new List<Pedido>() });
           

            Pedidos.pedidos.Add(new Pedido { Id = 1, FechaPedido = DateTime.Today, IdCliente = 1 });
            Pedidos.pedidos.Add(new Pedido { Id = 2, FechaPedido = DateTime.Today, IdCliente = 1 });
            Pedidos.pedidos.Add(new Pedido { Id = 3, FechaPedido = DateTime.Today, IdCliente = 1 });
            Pedidos.pedidos.Add(new Pedido { Id = 4, FechaPedido = DateTime.Today, IdCliente = 2 });
            Pedidos.pedidos.Add(new Pedido { Id = 5, FechaPedido = DateTime.Today, IdCliente = 1 });
            Pedidos.pedidos.Add(new Pedido { Id = 6, FechaPedido = DateTime.Today, IdCliente = 2 });
            Pedidos.pedidos.Add(new Pedido { Id = 7, FechaPedido = DateTime.Today, IdCliente = 2 });
            /*La ejecucion de las instrucciones  LinQ son diferidas
            es decir se ejecutan en el bucle foreach que les llame
            var hace inferencia de tipos
            es decir asigna a la variable el tipo de la variable que se le asigna*/
            var PedidosCliente1 = (from ped in Pedidos.pedidos
                                   where ped.IdCliente == 1
                                   select ped);
            var PedidosCliente2 = (from ped in Pedidos.pedidos
                                   where ped.IdCliente == 2
                                   select ped);
            foreach (var item in PedidosCliente1)
            {
                //MessageBox.Show(item.ToString());
                Clientes.clientes[0].ListaPedidos.Add(item);
            }
            foreach (var item in PedidosCliente2)
            {
                Clientes.clientes[1].ListaPedidos.Add(item);
            }
            for (int i = 0; i < Clientes.clientes.Count; i++)
            {
                cmbClientes.Items.Add(Clientes.clientes[i].PersonaContacto);
            }

            //cmbPedidos.DataSource = Pedidos.pedidos;

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPedidos.Items.Clear();
            foreach (var item in Clientes.clientes[cmbClientes.SelectedIndex].ListaPedidos)
            {
                cmbPedidos.Items.Add(item.Id);
            }
            //sirve de esta manera tambien:
            //dtGridPedidos.DataSource = Clientes.clientes[cmbClientes.SelectedIndex].ListaPedidos;
            var idCliente = (from c in Clientes.clientes
                             where c.PersonaContacto == cmbClientes.SelectedItem.ToString()
                             select c.Id).First();
            var pedidos = (from p in Pedidos.pedidos
                           where p.IdCliente == idCliente
                           select p).ToList();
            dtGridPedidos.DataSource = pedidos;
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCaracteristicasPedido.Text = "ID: " + Pedidos.pedidos[Convert.ToInt32(cmbPedidos.Text) - 1].Id + "\r\n" +
                "ID CLIENTE: " + Pedidos.pedidos[Convert.ToInt32(cmbPedidos.Text) - 1].IdCliente + "\r\n" +
                "FECHA DE PEDIDO: " + "\r\n" + Pedidos.pedidos[Convert.ToInt32(cmbPedidos.Text) - 1].FechaPedido.ToString();
        }
    }
}
