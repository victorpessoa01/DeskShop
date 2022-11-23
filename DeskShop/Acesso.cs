using System;
using System.Windows.Forms;

namespace DeskShop
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();

            textBoxLogin.Clear();   
            textBoxSenha.Clear();
        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            TelaMenu tela = new TelaMenu();
            tela.Close();
            Close();
        }

        private void bntAcesso_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "@victor01" && textBoxSenha.Text =="senha01")
            {
                Acesso acesso = new Acesso();
                acesso.Close();
                TelaMenu tela=new TelaMenu();
                tela.ShowDialog();
                this.Close();
            }

            else if (textBoxLogin.Text=="" && textBoxSenha.Text == "")
            {
                MessageBox.Show("Insira seu dados para acessar o sistema");
            }

            else
            {
                MessageBox.Show("Login ou Senha Incorreto!");
            }
        }

        private void Acesso_Load(object sender, EventArgs e)
        {

        }
    }
}
