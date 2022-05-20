namespace Multi_Dicionario.Paginas
{
    partial class PaginaLogin
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.MaskedTextBox();
            this.tbSenha = new System.Windows.Forms.MaskedTextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.lklbPrimeiroAcesso = new System.Windows.Forms.LinkLabel();
            this.lklbEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(295, 36);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(295, 99);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Location = new System.Drawing.Point(265, 52);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbSenha
            // 
            this.tbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenha.Location = new System.Drawing.Point(265, 115);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = 'k';
            this.tbSenha.Size = new System.Drawing.Size(100, 20);
            this.tbSenha.TabIndex = 3;
            // 
            // btnAcessar
            // 
            this.btnAcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcessar.Location = new System.Drawing.Point(277, 151);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(75, 23);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // lklbPrimeiroAcesso
            // 
            this.lklbPrimeiroAcesso.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lklbPrimeiroAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lklbPrimeiroAcesso.AutoSize = true;
            this.lklbPrimeiroAcesso.Location = new System.Drawing.Point(163, 191);
            this.lklbPrimeiroAcesso.Name = "lklbPrimeiroAcesso";
            this.lklbPrimeiroAcesso.Size = new System.Drawing.Size(146, 13);
            this.lklbPrimeiroAcesso.TabIndex = 5;
            this.lklbPrimeiroAcesso.TabStop = true;
            this.lklbPrimeiroAcesso.Text = "Primeiro Acesso? Clique aqui.";
            this.lklbPrimeiroAcesso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbPrimeiroAcesso_LinkClicked);
            // 
            // lklbEsqueciSenha
            // 
            this.lklbEsqueciSenha.AutoSize = true;
            this.lklbEsqueciSenha.Location = new System.Drawing.Point(315, 191);
            this.lklbEsqueciSenha.Name = "lklbEsqueciSenha";
            this.lklbEsqueciSenha.Size = new System.Drawing.Size(111, 13);
            this.lklbEsqueciSenha.TabIndex = 6;
            this.lklbEsqueciSenha.TabStop = true;
            this.lklbEsqueciSenha.Text = "Esqueci Minha Senha";
            this.lklbEsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbEsqueciSenha_LinkClicked);
            // 
            // PaginaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.lklbEsqueciSenha);
            this.Controls.Add(this.lklbPrimeiroAcesso);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaginaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-Dicionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.MaskedTextBox tbLogin;
        private System.Windows.Forms.MaskedTextBox tbSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.LinkLabel lklbPrimeiroAcesso;
        private System.Windows.Forms.LinkLabel lklbEsqueciSenha;
    }
}