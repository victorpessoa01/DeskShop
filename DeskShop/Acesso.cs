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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
