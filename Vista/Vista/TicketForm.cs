using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        TickectDB tickectDB = new TickectDB();
        decimal subTotal = 0;
        decimal descuento = 0;
        decimal impuesto = 0;
        decimal total = 0;
        private void ClienteTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadTextBox1.Text);
            }

        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox1.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }


        private void CalcularButton1_Click(object sender, EventArgs e)
        {
            PrecioTextBox1.Text = subTotal.ToString();
            DescuentoTextBox1.Text = descuento.ToString();
            impuesto = subTotal * 0.15M;
            total = subTotal + impuesto - descuento;
            TotalTextBox1.Text = total.ToString();
        }

        private void GuardarButton1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Fecha = FechaDateTimePicker1.Value;
            ticket.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            ticket.IdentidadCliente = miCliente.Identidad;
            ticket.Precio = subTotal;
            ticket.Impuesto = impuesto;
            ticket.Descuento = descuento;
            ticket.Total = total;

            bool inserto = tickectDB.Guardar(ticket);

            if (inserto)
            {
                MessageBox.Show("Factura registrada");
            }
            else
                MessageBox.Show("No se pudo registrar");
        }
    }
}
