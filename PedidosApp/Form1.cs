using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);

                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);

                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()} \nCosto: ${pedido.ObtenerCosto():0.00}";

                dtgProductos.Rows.Clear();
                foreach (var item in RegistroPedidos.Instancia.Pedidos)
                {
                    dtgProductos.Rows.Add(item.Cliente, item.Producto, item.Urgente, item.Peso, item.Distancia, item.ObtenerCosto());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = comboBox1.SelectedItem.ToString();

                // Filtrar los pedidos según la categoría seleccionada
                var pedidosFiltrados = RegistroPedidos.Instancia.Pedidos
                    .Where(p => p.Producto.Equals(filtro, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Limpiar el DataGridView antes de mostrar los resultados filtrados
                dtgProductos.Rows.Clear();

                // Agregar los pedidos filtrados al DataGridView
                foreach (var pedido in pedidosFiltrados)
                {
                    dtgProductos.Rows.Add(pedido.Cliente, pedido.Producto, pedido.Urgente, pedido.Peso, pedido.Distancia, pedido.ObtenerCosto());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }
    }
}
