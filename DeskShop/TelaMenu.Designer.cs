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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.bntLogout = new System.Windows.Forms.Button();
            this.bntSistema = new System.Windows.Forms.Button();
            this.bntPedidos = new System.Windows.Forms.Button();
            this.bntProdutos = new System.Windows.Forms.Button();
            this.bntClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(632, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 34);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxMin);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(79, 34);
            this.panel3.TabIndex = 2;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMin.Location = new System.Drawing.Point(53, 5);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxMin.TabIndex = 2;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxNormal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(26, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 34);
            this.panel4.TabIndex = 3;
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNormal.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(28, 23);
            this.pictureBoxNormal.TabIndex = 1;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBoxMax);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 34);
            this.panel5.TabIndex = 3;
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMax.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxMax.TabIndex = 0;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(79, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 34);
            this.panel2.TabIndex = 2;
            // 
            // panelCentro
            // 
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCentro.Location = new System.Drawing.Point(132, 34);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(588, 446);
            this.panelCentro.TabIndex = 2;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLateral);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button bntLogout;
        private System.Windows.Forms.Button bntSistema;
        private System.Windows.Forms.Button bntPedidos;
        private System.Windows.Forms.Button bntProdutos;
        private System.Windows.Forms.Button bntClientes;
    }
}

