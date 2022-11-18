using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskShop
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();

            Acesso acesso = new Acesso();
            acesso.Close();
        }               
        
        private void bntLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar o Programa?","DeskShop",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Close();
            }
            }

        private void panelCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelCentro.Controls.Clear();
            panelCentro.Controls.Add(clientes);
            clientes.Show();
        }
    }
}
