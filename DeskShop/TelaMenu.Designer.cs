namespace DeskShop
{
    partial class TelaMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.bntLogout = new System.Windows.Forms.Button();
            this.panelSistema = new System.Windows.Forms.Panel();
            this.bntSistema = new System.Windows.Forms.Button();
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.bntPedidos = new System.Windows.Forms.Button();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.bntProdutos = new System.Windows.Forms.Button();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.bntClientes = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMax = new System.Windows.Forms.Panel();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.panelNormal = new System.Windows.Forms.Panel();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.panelMin = new System.Windows.Forms.Panel();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelSistema.SuspendLayout();
            this.panelPedidos.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            this.panelNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            this.panelMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Transparent;
            this.panelLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLateral.BackgroundImage")));
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Controls.Add(this.panelLogout);
            this.panelLateral.Controls.Add(this.panelSistema);
            this.panelLateral.Controls.Add(this.panelPedidos);
            this.panelLateral.Controls.Add(this.panelProdutos);
            this.panelLateral.Controls.Add(this.panelCliente);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(132, 480);
            this.panelLateral.TabIndex = 0;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.bntLogout);
            this.panelLogout.Location = new System.Drawing.Point(29, 391);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(75, 27);
            this.panelLogout.TabIndex = 3;
            // 
            // bntLogout
            // 
            this.bntLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntLogout.BackgroundImage")));
            this.bntLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntLogout.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogout.ForeColor = System.Drawing.Color.White;
            this.bntLogout.Location = new System.Drawing.Point(0, 0);
            this.bntLogout.Name = "bntLogout";
            this.bntLogout.Size = new System.Drawing.Size(75, 27);
            this.bntLogout.TabIndex = 4;
            this.bntLogout.Text = "Log Out";
            this.bntLogout.UseVisualStyleBackColor = true;
            this.bntLogout.Click += new System.EventHandler(this.bntLogout_Click);
            // 
            // panelSistema
            // 
            this.panelSistema.Controls.Add(this.bntSistema);
            this.panelSistema.Location = new System.Drawing.Point(0, 203);
            this.panelSistema.Name = "panelSistema";
            this.panelSistema.Size = new System.Drawing.Size(132, 27);
            this.panelSistema.TabIndex = 2;
            // 
            // bntSistema
            // 
            this.bntSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntSistema.Location = new System.Drawing.Point(0, 0);
            this.bntSistema.Name = "bntSistema";
            this.bntSistema.Size = new System.Drawing.Size(132, 27);
            this.bntSistema.TabIndex = 3;
            this.bntSistema.Text = "Sistema";
            this.bntSistema.UseVisualStyleBackColor = true;
            // 
            // panelPedidos
            // 
            this.panelPedidos.Controls.Add(this.bntPedidos);
            this.panelPedidos.Location = new System.Drawing.Point(0, 159);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(132, 27);
            this.panelPedidos.TabIndex = 2;
            // 
            // bntPedidos
            // 
            this.bntPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntPedidos.Location = new System.Drawing.Point(0, 0);
            this.bntPedidos.Name = "bntPedidos";
            this.bntPedidos.Size = new System.Drawing.Size(132, 27);
            this.bntPedidos.TabIndex = 2;
            this.bntPedidos.Text = "Pedidos";
            this.bntPedidos.UseVisualStyleBackColor = true;
            // 
            // panelProdutos
            // 
            this.panelProdutos.Controls.Add(this.bntProdutos);
            this.panelProdutos.Location = new System.Drawing.Point(0, 114);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(132, 27);
            this.panelProdutos.TabIndex = 1;
            // 
            // bntProdutos
            // 
            this.bntProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntProdutos.Location = new System.Drawing.Point(0, 0);
            this.bntProdutos.Name = "bntProdutos";
            this.bntProdutos.Size = new System.Drawing.Size(132, 27);
            this.bntProdutos.TabIndex = 1;
            this.bntProdutos.Text = "Produtos";
            this.bntProdutos.UseVisualStyleBackColor = true;
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.bntClientes);
            this.panelCliente.Location = new System.Drawing.Point(0, 70);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(132, 27);
            this.panelCliente.TabIndex = 0;
            // 
            // bntClientes
            // 
            this.bntClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntClientes.Location = new System.Drawing.Point(0, 0);
            this.bntClientes.Name = "bntClientes";
            this.bntClientes.Size = new System.Drawing.Size(132, 27);
            this.bntClientes.TabIndex = 0;
            this.bntClientes.Text = "Clientes";
            this.bntClientes.UseVisualStyleBackColor = true;
            this.bntClientes.Click += new System.EventHandler(this.bntClientes_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.Controls.Add(this.panelMax);
            this.panelTop.Controls.Add(this.panelNormal);
            this.panelTop.Controls.Add(this.panelMin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(132, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(588, 27);
            this.panelTop.TabIndex = 0;
            // 
            // panelMax
            // 
            this.panelMax.Controls.Add(this.pictureBoxMax);
            this.panelMax.Location = new System.Drawing.Point(495, 3);
            this.panelMax.Name = "panelMax";
            this.panelMax.Size = new System.Drawing.Size(23, 21);
            this.panelMax.TabIndex = 5;
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMax.BackgroundImage")));
            this.pictureBoxMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMax.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxMax.TabIndex = 2;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click_1);
            // 
            // panelNormal
            // 
            this.panelNormal.Controls.Add(this.pictureBoxNormal);
            this.panelNormal.Location = new System.Drawing.Point(524, 3);
            this.panelNormal.Name = "panelNormal";
            this.panelNormal.Size = new System.Drawing.Size(23, 21);
            this.panelNormal.TabIndex = 4;
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNormal.BackgroundImage")));
            this.pictureBoxNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxNormal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxNormal.TabIndex = 1;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click_1);
            // 
            // panelMin
            // 
            this.panelMin.Controls.Add(this.pictureBoxMin);
            this.panelMin.Location = new System.Drawing.Point(553, 3);
            this.panelMin.Name = "panelMin";
            this.panelMin.Size = new System.Drawing.Size(23, 21);
            this.panelMin.TabIndex = 3;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMin.BackgroundImage")));
            this.pictureBoxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMin.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxMin.TabIndex = 0;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click_1);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.Transparent;
            this.panelCentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCentro.BackgroundImage")));
            this.panelCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(132, 27);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(588, 453);
            this.panelCentro.TabIndex = 1;
            this.panelCentro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentro_Paint_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(132, 73);
            this.panelLogo.TabIndex = 0;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLateral);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLateral.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelSistema.ResumeLayout(false);
            this.panelPedidos.ResumeLayout(false);
            this.panelProdutos.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelMax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            this.panelNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            this.panelMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button bntLogout;
        private System.Windows.Forms.Button bntSistema;
        private System.Windows.Forms.Button bntPedidos;
        private System.Windows.Forms.Button bntProdutos;
        private System.Windows.Forms.Button bntClientes;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.Panel panelSistema;
        private System.Windows.Forms.Panel panelPedidos;
        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Panel panelMax;
        private System.Windows.Forms.Panel panelNormal;
        private System.Windows.Forms.Panel panelMin;
        private System.Windows.Forms.Panel panelLogo;
    }
}

