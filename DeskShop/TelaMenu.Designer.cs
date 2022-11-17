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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.bntLogout = new System.Windows.Forms.Button();
            this.bntSistema = new System.Windows.Forms.Button();
            this.bntPedidos = new System.Windows.Forms.Button();
            this.bntProdutos = new System.Windows.Forms.Button();
            this.bntClientes = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLateral.Controls.Add(this.pictureBoxLogo);
            this.panelLateral.Controls.Add(this.bntLogout);
            this.panelLateral.Controls.Add(this.bntSistema);
            this.panelLateral.Controls.Add(this.bntPedidos);
            this.panelLateral.Controls.Add(this.bntProdutos);
            this.panelLateral.Controls.Add(this.bntClientes);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(132, 480);
            this.panelLateral.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(132, 79);
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // bntLogout
            // 
            this.bntLogout.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogout.Location = new System.Drawing.Point(0, 331);
            this.bntLogout.Name = "bntLogout";
            this.bntLogout.Size = new System.Drawing.Size(85, 27);
            this.bntLogout.TabIndex = 4;
            this.bntLogout.Text = "Log Out";
            this.bntLogout.UseVisualStyleBackColor = true;
            this.bntLogout.Click += new System.EventHandler(this.bntLogout_Click);
            // 
            // bntSistema
            // 
            this.bntSistema.Location = new System.Drawing.Point(0, 272);
            this.bntSistema.Name = "bntSistema";
            this.bntSistema.Size = new System.Drawing.Size(126, 27);
            this.bntSistema.TabIndex = 3;
            this.bntSistema.Text = "Sistema";
            this.bntSistema.UseVisualStyleBackColor = true;
            // 
            // bntPedidos
            // 
            this.bntPedidos.Location = new System.Drawing.Point(0, 214);
            this.bntPedidos.Name = "bntPedidos";
            this.bntPedidos.Size = new System.Drawing.Size(126, 27);
            this.bntPedidos.TabIndex = 2;
            this.bntPedidos.Text = "Pedidos";
            this.bntPedidos.UseVisualStyleBackColor = true;
            // 
            // bntProdutos
            // 
            this.bntProdutos.Location = new System.Drawing.Point(0, 159);
            this.bntProdutos.Name = "bntProdutos";
            this.bntProdutos.Size = new System.Drawing.Size(126, 27);
            this.bntProdutos.TabIndex = 1;
            this.bntProdutos.Text = "Produtos";
            this.bntProdutos.UseVisualStyleBackColor = true;
            // 
            // bntClientes
            // 
            this.bntClientes.Location = new System.Drawing.Point(0, 106);
            this.bntClientes.Name = "bntClientes";
            this.bntClientes.Size = new System.Drawing.Size(126, 27);
            this.bntClientes.TabIndex = 0;
            this.bntClientes.Text = "Clientes";
            this.bntClientes.UseVisualStyleBackColor = true;
            this.bntClientes.Click += new System.EventHandler(this.bntClientes_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.pictureBoxMin);
            this.panelTop.Controls.Add(this.pictureBoxMax);
            this.panelTop.Controls.Add(this.pictureBoxNormal);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(132, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(588, 27);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNormal.BackgroundImage")));
            this.pictureBoxNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxNormal.Location = new System.Drawing.Point(560, 0);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(28, 27);
            this.pictureBoxNormal.TabIndex = 1;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMin.BackgroundImage")));
            this.pictureBoxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMin.Location = new System.Drawing.Point(508, 0);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(26, 27);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMin.TabIndex = 2;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMax.BackgroundImage")));
            this.pictureBoxMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMax.Location = new System.Drawing.Point(534, 0);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(26, 27);
            this.pictureBoxMax.TabIndex = 0;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.Transparent;
            this.panelCentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCentro.BackgroundImage")));
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(132, 27);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(588, 453);
            this.panelCentro.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button bntLogout;
        private System.Windows.Forms.Button bntSistema;
        private System.Windows.Forms.Button bntPedidos;
        private System.Windows.Forms.Button bntProdutos;
        private System.Windows.Forms.Button bntClientes;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Panel panelCentro;
    }
}

