namespace Multi_Dicionario.Paginas
{
    partial class PaginaPainelAdm
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
            this.btnGerenciaIdioma = new System.Windows.Forms.Button();
            this.btnGerenciaPalavra = new System.Windows.Forms.Button();
            this.btnMultiDicionario = new System.Windows.Forms.Button();
            this.lklbSobre = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGerenciaIdioma
            // 
            this.btnGerenciaIdioma.Location = new System.Drawing.Point(53, 49);
            this.btnGerenciaIdioma.Name = "btnGerenciaIdioma";
            this.btnGerenciaIdioma.Size = new System.Drawing.Size(119, 23);
            this.btnGerenciaIdioma.TabIndex = 0;
            this.btnGerenciaIdioma.Text = "Gerenciar Idiomas";
            this.btnGerenciaIdioma.UseVisualStyleBackColor = true;
            this.btnGerenciaIdioma.Click += new System.EventHandler(this.btnGerenciaIdioma_Click);
            // 
            // btnGerenciaPalavra
            // 
            this.btnGerenciaPalavra.Location = new System.Drawing.Point(53, 87);
            this.btnGerenciaPalavra.Name = "btnGerenciaPalavra";
            this.btnGerenciaPalavra.Size = new System.Drawing.Size(119, 23);
            this.btnGerenciaPalavra.TabIndex = 1;
            this.btnGerenciaPalavra.Text = "Gerenciar Palavras";
            this.btnGerenciaPalavra.UseVisualStyleBackColor = true;
            this.btnGerenciaPalavra.Click += new System.EventHandler(this.btnGerenciaPalavra_Click);
            // 
            // btnMultiDicionario
            // 
            this.btnMultiDicionario.Location = new System.Drawing.Point(53, 126);
            this.btnMultiDicionario.Name = "btnMultiDicionario";
            this.btnMultiDicionario.Size = new System.Drawing.Size(119, 23);
            this.btnMultiDicionario.TabIndex = 2;
            this.btnMultiDicionario.Text = "Multi-Dicionario";
            this.btnMultiDicionario.UseVisualStyleBackColor = true;
            this.btnMultiDicionario.Click += new System.EventHandler(this.btnMultiDicionario_Click);
            // 
            // lklbSobre
            // 
            this.lklbSobre.AutoSize = true;
            this.lklbSobre.Location = new System.Drawing.Point(81, 266);
            this.lklbSobre.Name = "lklbSobre";
            this.lklbSobre.Size = new System.Drawing.Size(91, 13);
            this.lklbSobre.TabIndex = 3;
            this.lklbSobre.TabStop = true;
            this.lklbSobre.Text = "Sobre o programa";
            this.lklbSobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbSobre_LinkClicked);
            // 
            // PaginaPainelAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 288);
            this.Controls.Add(this.lklbSobre);
            this.Controls.Add(this.btnMultiDicionario);
            this.Controls.Add(this.btnGerenciaPalavra);
            this.Controls.Add(this.btnGerenciaIdioma);
            this.Name = "PaginaPainelAdm";
            this.Text = "Painel Administrativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciaIdioma;
        private System.Windows.Forms.Button btnGerenciaPalavra;
        private System.Windows.Forms.Button btnMultiDicionario;
        private System.Windows.Forms.LinkLabel lklbSobre;
    }
}