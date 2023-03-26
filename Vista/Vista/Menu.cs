using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton1_Click(object sender, EventArgs e)
        {
            UsuariosForm userForm = new UsuariosForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void ClientesToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FacturaToolStripButton2_Click(object sender, EventArgs e)
        {
            FacturasForm facturaForm = new FacturasForm();
            facturaForm.MdiParent = this;
            facturaForm.Show();
        }
    }
}
