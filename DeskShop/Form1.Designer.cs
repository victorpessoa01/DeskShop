namespace DeskShop
{
    partial class Form1
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
            this.bntCarrinho = new System.Windows.Forms.Button();
            this.bntUpgrade = new System.Windows.Forms.Button();
            this.bntPerifericos = new System.Windows.Forms.Button();
            this.bntFontes = new System.Windows.Forms.Button();
            this.bntMonitores = new System.Windows.Forms.Button();
            this.bntGabinetes = new System.Windows.Forms.Button();
            this.bntGamer = new System.Windows.Forms.Button();
            this.bntInicio = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuCarrinhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntMax = new System.Windows.Forms.Button();
            this.bntNormal = new System.Windows.Forms.Button();
            this.bntMIn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            this.panelTopo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.Controls.Add(this.bntCarrinho);
            this.panelLateral.Controls.Add(this.bntUpgrade);
            this.panelLateral.Controls.Add(this.bntPerifericos);
            this.panelLateral.Controls.Add(this.bntFontes);
            this.panelLateral.Controls.Add(this.bntMonitores);
            this.panelLateral.Controls.Add(this.bntGabinetes);
            this.panelLateral.Controls.Add(this.bntGamer);
            this.panelLateral.Controls.Add(this.bntInicio);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 38);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 682);
            this.panelLateral.TabIndex = 2;
            // 
            // bntCarrinho
            // 
            this.bntCarrinho.Location = new System.Drawing.Point(3, 507);
            this.bntCarrinho.Name = "bntCarrinho";
            this.bntCarrinho.Size = new System.Drawing.Size(191, 34);
            this.bntCarrinho.TabIndex = 7;
            this.bntCarrinho.Text = "Memorias";
            this.bntCarrinho.UseVisualStyleBackColor = true;
            // 
            // bntUpgrade
            // 
            this.bntUpgrade.Location = new System.Drawing.Point(3, 442);
            this.bntUpgrade.Name = "bntUpgrade";
            this.bntUpgrade.Size = new System.Drawing.Size(191, 34);
            this.bntUpgrade.TabIndex = 6;
            this.bntUpgrade.Text = "Kit Upgrade";
            this.bntUpgrade.UseVisualStyleBackColor = true;
            // 
            // bntPerifericos
            // 
            this.bntPerifericos.Location = new System.Drawing.Point(3, 378);
            this.bntPerifericos.Name = "bntPerifericos";
            this.bntPerifericos.Size = new System.Drawing.Size(191, 34);
            this.bntPerifericos.TabIndex = 5;
            this.bntPerifericos.Text = "Perifericos";
            this.bntPerifericos.UseVisualStyleBackColor = true;
            // 
            // bntFontes
            // 
            this.bntFontes.Location = new System.Drawing.Point(3, 315);
            this.bntFontes.Name = "bntFontes";
            this.bntFontes.Size = new System.Drawing.Size(191, 34);
            this.bntFontes.TabIndex = 4;
            this.bntFontes.Text = "Fontes";
            this.bntFontes.UseVisualStyleBackColor = true;
            // 
            // bntMonitores
            // 
            this.bntMonitores.Location = new System.Drawing.Point(3, 256);
            this.bntMonitores.Name = "bntMonitores";
            this.bntMonitores.Size = new System.Drawing.Size(191, 34);
            this.bntMonitores.TabIndex = 3;
            this.bntMonitores.Text = "Monitores";
            this.bntMonitores.UseVisualStyleBackColor = true;
            // 
            // bntGabinetes
            // 
            this.bntGabinetes.Location = new System.Drawing.Point(3, 194);
            this.bntGabinetes.Name = "bntGabinetes";
            this.bntGabinetes.Size = new System.Drawing.Size(191, 34);
            this.bntGabinetes.TabIndex = 2;
            this.bntGabinetes.Text = "Gabinetes";
            this.bntGabinetes.UseVisualStyleBackColor = true;
            // 
            // bntGamer
            // 
            this.bntGamer.Location = new System.Drawing.Point(3, 133);
            this.bntGamer.Name = "bntGamer";
            this.bntGamer.Size = new System.Drawing.Size(191, 34);
            this.bntGamer.TabIndex = 1;
            this.bntGamer.Text = "PC Gamer";
            this.bntGamer.UseVisualStyleBackColor = true;
            this.bntGamer.Click += new System.EventHandler(this.bntGamer_Click);
            // 
            // bntInicio
            // 
            this.bntInicio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInicio.Location = new System.Drawing.Point(3, 72);
            this.bntInicio.Name = "bntInicio";
            this.bntInicio.Size = new System.Drawing.Size(191, 34);
            this.bntInicio.TabIndex = 0;
            this.bntInicio.Text = "Inicio";
            this.bntInicio.UseVisualStyleBackColor = true;
            // 
            // panelCentro
            // 
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(200, 38);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(880, 682);
            this.panelCentro.TabIndex = 3;
            // 
            // panelTopo
            // 
            this.panelTopo.Controls.Add(this.pictureBox1);
            this.panelTopo.Controls.Add(this.bntMax);
            this.panelTopo.Controls.Add(this.bntNormal);
            this.panelTopo.Controls.Add(this.bntMIn);
            this.panelTopo.Controls.Add(this.pictureBox3);
            this.panelTopo.Controls.Add(this.menuStrip1);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(1080, 38);
            this.panelTopo.TabIndex = 1;
            this.panelTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.favoritosToolStripMenuItem,
            this.meuCarrinhoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.endereçoToolStripMenuItem,
            this.carãoToolStripMenuItem});
            this.perfilToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.dadosToolStripMenuItem.Text = "Dados Pessoais";
            // 
            // endereçoToolStripMenuItem
            // 
            this.endereçoToolStripMenuItem.Name = "endereçoToolStripMenuItem";
            this.endereçoToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.endereçoToolStripMenuItem.Text = "Endereço";
            // 
            // carãoToolStripMenuItem
            // 
            this.carãoToolStripMenuItem.Name = "carãoToolStripMenuItem";
            this.carãoToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.carãoToolStripMenuItem.Text = "Cartão";
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            // 
            // meuCarrinhoToolStripMenuItem
            // 
            this.meuCarrinhoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meuCarrinhoToolStripMenuItem.Name = "meuCarrinhoToolStripMenuItem";
            this.meuCarrinhoToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
            this.meuCarrinhoToolStripMenuItem.Text = "Meu Carrinho";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(49, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(949, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bntMax
            // 
            this.bntMax.BackColor = System.Drawing.Color.Transparent;
            this.bntMax.BackgroundImage = global::DeskShop.Properties.Resources.Max;
            this.bntMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMax.Location = new System.Drawing.Point(962, 0);
            this.bntMax.Name = "bntMax";
            this.bntMax.Size = new System.Drawing.Size(35, 38);
            this.bntMax.TabIndex = 2;
            this.bntMax.UseVisualStyleBackColor = false;
            this.bntMax.Click += new System.EventHandler(this.bntMax_Click_2);
            // 
            // bntNormal
            // 
            this.bntNormal.BackColor = System.Drawing.Color.Transparent;
            this.bntNormal.BackgroundImage = global::DeskShop.Properties.Resources.MIn;
            this.bntNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNormal.Location = new System.Drawing.Point(997, 0);
            this.bntNormal.Name = "bntNormal";
            this.bntNormal.Size = new System.Drawing.Size(35, 38);
            this.bntNormal.TabIndex = 3;
            this.bntNormal.UseVisualStyleBackColor = false;
            this.bntNormal.Click += new System.EventHandler(this.bntMax_Click_1);
            // 
            // bntMIn
            // 
            this.bntMIn.BackColor = System.Drawing.Color.Transparent;
            this.bntMIn.BackgroundImage = global::DeskShop.Properties.Resources.Normal;
            this.bntMIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntMIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntMIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMIn.Location = new System.Drawing.Point(1032, 0);
            this.bntMIn.Name = "bntMIn";
            this.bntMIn.Size = new System.Drawing.Size(35, 38);
            this.bntMIn.TabIndex = 1;
            this.bntMIn.UseVisualStyleBackColor = false;
            this.bntMIn.Click += new System.EventHandler(this.bntMIn_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(1067, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 38);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelTopo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLateral.ResumeLayout(false);
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button bntCarrinho;
        private System.Windows.Forms.Button bntUpgrade;
        private System.Windows.Forms.Button bntPerifericos;
        private System.Windows.Forms.Button bntFontes;
        private System.Windows.Forms.Button bntMonitores;
        private System.Windows.Forms.Button bntGabinetes;
        private System.Windows.Forms.Button bntGamer;
        private System.Windows.Forms.Button bntInicio;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuCarrinhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntMax;
        private System.Windows.Forms.Button bntNormal;
        private System.Windows.Forms.Button bntMIn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

