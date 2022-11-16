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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?","DeskShop",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }       

        private void bntMIn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bntMax_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bntMax_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bntGamer_Click(object sender, EventArgs e)
        {
            PCGamer pcg = new PCGamer();
            pcg.TopLevel = false;
            pcg.Dock = DockStyle.Fill;
            panelCentro.Controls.Clear();
            panelCentro.Controls.Add(pcg);
            pcg.Show();
        }
    }
}
