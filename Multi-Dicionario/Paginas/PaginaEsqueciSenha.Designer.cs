namespace Multi_Dicionario.Paginas
{
    partial class PaginaEsqueciSenha
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
            this.btnVerificaLogin = new System.Windows.Forms.Button();
            this.gbPerguntaResposta = new System.Windows.Forms.GroupBox();
            this.btnVerificaResposta = new System.Windows.Forms.Button();
            this.tbResposta = new System.Windows.Forms.MaskedTextBox();
            this.lbResposta = new System.Windows.Forms.Label();
            this.lbPergunta = new System.Windows.Forms.Label();
            this.tbVerificaLogin = new System.Windows.Forms.MaskedTextBox();
            this.lbDigiteLogin = new System.Windows.Forms.Label();
            this.gbAlterarSenha = new System.Windows.Forms.GroupBox();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.lbConfirmaSenha = new System.Windows.Forms.Label();
            this.tbConfirmaSenha = new System.Windows.Forms.MaskedTextBox();
            this.lbNovaSenha = new System.Windows.Forms.Label();
            this.tbNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.gbPerguntaResposta.SuspendLayout();
            this.gbAlterarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificaLogin
            // 
            this.btnVerificaLogin.Location = new System.Drawing.Point(166, 79);
            this.btnVerificaLogin.Name = "btnVerificaLogin";
            this.btnVerificaLogin.Size = new System.Drawing.Size(75, 23);
            this.btnVerificaLogin.TabIndex = 0;
            this.btnVerificaLogin.Text = "Verificar";
            this.btnVerificaLogin.UseVisualStyleBackColor = true;
            this.btnVerificaLogin.Click += new System.EventHandler(this.btnVerificaLogin_Click);
            // 
            // gbPerguntaResposta
            // 
            this.gbPerguntaResposta.Controls.Add(this.btnVerificaResposta);
            this.gbPerguntaResposta.Controls.Add(this.tbResposta);
            this.gbPerguntaResposta.Controls.Add(this.lbResposta);
            this.gbPerguntaResposta.Controls.Add(this.lbPergunta);
            this.gbPerguntaResposta.Location = new System.Drawing.Point(12, 108);
            this.gbPerguntaResposta.Name = "gbPerguntaResposta";
            this.gbPerguntaResposta.Size = new System.Drawing.Size(389, 141);
            this.gbPerguntaResposta.TabIndex = 1;
            this.gbPerguntaResposta.TabStop = false;
            this.gbPerguntaResposta.Text = "Digite a resposta de sua pergunta secreta";
            // 
            // btnVerificaResposta
            // 
            this.btnVerificaResposta.Location = new System.Drawing.Point(248, 35);
            this.btnVerificaResposta.Name = "btnVerificaResposta";
            this.btnVerificaResposta.Size = new System.Drawing.Size(120, 70);
            this.btnVerificaResposta.TabIndex = 3;
            this.btnVerificaResposta.Text = "Verificar Resposta";
            this.btnVerificaResposta.UseVisualStyleBackColor = true;
            this.btnVerificaResposta.Click += new System.EventHandler(this.btnVerificaResposta_Click);
            // 
            // tbResposta
            // 
            this.tbResposta.Location = new System.Drawing.Point(129, 85);
            this.tbResposta.Name = "tbResposta";
            this.tbResposta.Size = new System.Drawing.Size(100, 20);
            this.tbResposta.TabIndex = 2;
            // 
            // lbResposta
            // 
            this.lbResposta.AutoSize = true;
            this.lbResposta.Location = new System.Drawing.Point(68, 88);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(55, 13);
            this.lbResposta.TabIndex = 1;
            this.lbResposta.Text = "Resposta:";
            // 
            // lbPergunta
            // 
            this.lbPergunta.AutoSize = true;
            this.lbPergunta.Location = new System.Drawing.Point(68, 35);
            this.lbPergunta.Name = "lbPergunta";
            this.lbPergunta.Size = new System.Drawing.Size(10, 13);
            this.lbPergunta.TabIndex = 0;
            this.lbPergunta.Text = "-";
            // 
            // tbVerificaLogin
            // 
            this.tbVerificaLogin.Location = new System.Drawing.Point(154, 53);
            this.tbVerificaLogin.Name = "tbVerificaLogin";
            this.tbVerificaLogin.Size = new System.Drawing.Size(100, 20);
            this.tbVerificaLogin.TabIndex = 2;
            // 
            // lbDigiteLogin
            // 
            this.lbDigiteLogin.AutoSize = true;
            this.lbDigiteLogin.Location = new System.Drawing.Point(97, 22);
            this.lbDigiteLogin.Name = "lbDigiteLogin";
            this.lbDigiteLogin.Size = new System.Drawing.Size(224, 13);
            this.lbDigiteLogin.TabIndex = 3;
            this.lbDigiteLogin.Text = "Digite o login para verificar a pergunta secreta";
            // 
            // gbAlterarSenha
            // 
            this.gbAlterarSenha.Controls.Add(this.btAlterarSenha);
            this.gbAlterarSenha.Controls.Add(this.lbConfirmaSenha);
            this.gbAlterarSenha.Controls.Add(this.tbConfirmaSenha);
            this.gbAlterarSenha.Controls.Add(this.lbNovaSenha);
            this.gbAlterarSenha.Controls.Add(this.tbNovaSenha);
            this.gbAlterarSenha.Location = new System.Drawing.Point(12, 274);
            this.gbAlterarSenha.Name = "gbAlterarSenha";
            this.gbAlterarSenha.Size = new System.Drawing.Size(389, 178);
            this.gbAlterarSenha.TabIndex = 4;
            this.gbAlterarSenha.TabStop = false;
            this.gbAlterarSenha.Text = "Feito, agora altere sua senha";
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.Location = new System.Drawing.Point(248, 63);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(120, 74);
            this.btAlterarSenha.TabIndex = 4;
            this.btAlterarSenha.Text = "Alterar Senha";
            this.btAlterarSenha.UseVisualStyleBackColor = true;
            this.btAlterarSenha.Click += new System.EventHandler(this.btAlterarSenha_Click);
            // 
            // lbConfirmaSenha
            // 
            this.lbConfirmaSenha.AutoSize = true;
            this.lbConfirmaSenha.Location = new System.Drawing.Point(31, 101);
            this.lbConfirmaSenha.Name = "lbConfirmaSenha";
            this.lbConfirmaSenha.Size = new System.Drawing.Size(116, 13);
            this.lbConfirmaSenha.TabIndex = 3;
            this.lbConfirmaSenha.Text = "Confirme a nova senha";
            // 
            // tbConfirmaSenha
            // 
            this.tbConfirmaSenha.Location = new System.Drawing.Point(34, 117);
            this.tbConfirmaSenha.Name = "tbConfirmaSenha";
            this.tbConfirmaSenha.PasswordChar = '*';
            this.tbConfirmaSenha.Size = new System.Drawing.Size(113, 20);
            this.tbConfirmaSenha.TabIndex = 2;
            // 
            // lbNovaSenha
            // 
            this.lbNovaSenha.AutoSize = true;
            this.lbNovaSenha.Location = new System.Drawing.Point(31, 47);
            this.lbNovaSenha.Name = "lbNovaSenha";
            this.lbNovaSenha.Size = new System.Drawing.Size(102, 13);
            this.lbNovaSenha.TabIndex = 1;
            this.lbNovaSenha.Text = "Digite a nova senha";
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Location = new System.Drawing.Point(34, 63);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.PasswordChar = '*';
            this.tbNovaSenha.Size = new System.Drawing.Size(113, 20);
            this.tbNovaSenha.TabIndex = 0;
            // 
            // PaginaEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 464);
            this.Controls.Add(this.gbAlterarSenha);
            this.Controls.Add(this.lbDigiteLogin);
            this.Controls.Add(this.tbVerificaLogin);
            this.Controls.Add(this.gbPerguntaResposta);
            this.Controls.Add(this.btnVerificaLogin);
            this.Name = "PaginaEsqueciSenha";
            this.Text = "Redefinir Senha";
            this.gbPerguntaResposta.ResumeLayout(false);
            this.gbPerguntaResposta.PerformLayout();
            this.gbAlterarSenha.ResumeLayout(false);
            this.gbAlterarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificaLogin;
        private System.Windows.Forms.GroupBox gbPerguntaResposta;
        private System.Windows.Forms.Button btnVerificaResposta;
        private System.Windows.Forms.MaskedTextBox tbResposta;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Label lbPergunta;
        private System.Windows.Forms.MaskedTextBox tbVerificaLogin;
        private System.Windows.Forms.Label lbDigiteLogin;
        private System.Windows.Forms.GroupBox gbAlterarSenha;
        private System.Windows.Forms.Button btAlterarSenha;
        private System.Windows.Forms.Label lbConfirmaSenha;
        private System.Windows.Forms.MaskedTextBox tbConfirmaSenha;
        private System.Windows.Forms.Label lbNovaSenha;
        private System.Windows.Forms.MaskedTextBox tbNovaSenha;
    }
}