namespace DeskShop
{
    partial class Acesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acesso));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.pictureBoxSenha = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.bntAcesso = new System.Windows.Forms.Button();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(201, 181);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(200, 21);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(199, 224);
            this.textBoxSenha.Multiline = true;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(202, 21);
            this.textBoxSenha.TabIndex = 1;
            // 
            // pictureBoxSenha
            // 
            this.pictureBoxSenha.BackColor = System.Drawing.Color.White;
            this.pictureBoxSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSenha.BackgroundImage")));
            this.pictureBoxSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSenha.Location = new System.Drawing.Point(180, 224);
            this.pictureBoxSenha.Name = "pictureBoxSenha";
            this.pictureBoxSenha.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxSenha.TabIndex = 2;
            this.pictureBoxSenha.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.BackgroundImage")));
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogin.Location = new System.Drawing.Point(180, 181);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxLogin.TabIndex = 3;
            this.pictureBoxLogin.TabStop = false;
            // 
            // bntAcesso
            // 
            this.bntAcesso.BackColor = System.Drawing.Color.White;
            this.bntAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntAcesso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAcesso.Location = new System.Drawing.Point(243, 284);
            this.bntAcesso.Name = "bntAcesso";
            this.bntAcesso.Size = new System.Drawing.Size(93, 27);
            this.bntAcesso.TabIndex = 4;
            this.bntAcesso.Text = "Logar";
            this.bntAcesso.UseVisualStyleBackColor = false;
            this.bntAcesso.Click += new System.EventHandler(this.bntAcesso_Click);
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSair.BackgroundImage")));
            this.pictureBoxSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSair.Location = new System.Drawing.Point(538, 12);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxSair.TabIndex = 5;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.pictureBoxSair_Click);
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 364);
            this.Controls.Add(this.pictureBoxSair);
            this.Controls.Add(this.bntAcesso);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.pictureBoxSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.Load += new System.EventHandler(this.Acesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.PictureBox pictureBoxSenha;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button bntAcesso;
        private System.Windows.Forms.PictureBox pictureBoxSair;
    }
}