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
        }     
                
        private void bntGamer_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelCentro.Controls.Clear();
            panelCentro.Controls.Add(clientes);
            clientes.Show();
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBoxNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bntLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar o Programa?","DeskShop",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }

            else
            {
                Close();

                Acesso acesso = new Acesso();
                acesso.Show();
            }
        }
    }
}
