namespace Multi_Dicionario.Paginas
{
    partial class PaginaMultiDicionario
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
            this.cbxIdiomaOriginal = new System.Windows.Forms.ComboBox();
            this.tbPalavra = new System.Windows.Forms.MaskedTextBox();
            this.cbxIdiomaTraduzir = new System.Windows.Forms.ComboBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbResultadoPalavraTraduzida = new System.Windows.Forms.Label();
            this.lbResultadoFraseExemplo = new System.Windows.Forms.Label();
            this.gbResultadoTradução = new System.Windows.Forms.GroupBox();
            this.gbResultadoTradução.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxIdiomaOriginal
            // 
            this.cbxIdiomaOriginal.FormattingEnabled = true;
            this.cbxIdiomaOriginal.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbxIdiomaOriginal.Location = new System.Drawing.Point(73, 29);
            this.cbxIdiomaOriginal.Name = "cbxIdiomaOriginal";
            this.cbxIdiomaOriginal.Size = new System.Drawing.Size(200, 21);
            this.cbxIdiomaOriginal.TabIndex = 0;
            this.cbxIdiomaOriginal.SelectionChangeCommitted += new System.EventHandler(this.cbxIdiomaOriginal_SelectionChangeCommitted);
            // 
            // tbPalavra
            // 
            this.tbPalavra.Location = new System.Drawing.Point(73, 69);
            this.tbPalavra.Name = "tbPalavra";
            this.tbPalavra.Size = new System.Drawing.Size(200, 20);
            this.tbPalavra.TabIndex = 1;
            // 
            // cbxIdiomaTraduzir
            // 
            this.cbxIdiomaTraduzir.FormattingEnabled = true;
            this.cbxIdiomaTraduzir.Location = new System.Drawing.Point(73, 108);
            this.cbxIdiomaTraduzir.Name = "cbxIdiomaTraduzir";
            this.cbxIdiomaTraduzir.Size = new System.Drawing.Size(200, 21);
            this.cbxIdiomaTraduzir.TabIndex = 2;
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Location = new System.Drawing.Point(141, 135);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(75, 23);
            this.btnTraduzir.TabIndex = 3;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha o Idioma Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite a Palavra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escolha um idioma para traduzir a palavra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Palavra Traduzida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Frase de exemplo:";
            // 
            // lbResultadoPalavraTraduzida
            // 
            this.lbResultadoPalavraTraduzida.AutoSize = true;
            this.lbResultadoPalavraTraduzida.Location = new System.Drawing.Point(121, 40);
            this.lbResultadoPalavraTraduzida.Name = "lbResultadoPalavraTraduzida";
            this.lbResultadoPalavraTraduzida.Size = new System.Drawing.Size(10, 13);
            this.lbResultadoPalavraTraduzida.TabIndex = 6;
            this.lbResultadoPalavraTraduzida.Text = "-";
            // 
            // lbResultadoFraseExemplo
            // 
            this.lbResultadoFraseExemplo.AutoSize = true;
            this.lbResultadoFraseExemplo.Location = new System.Drawing.Point(121, 81);
            this.lbResultadoFraseExemplo.Name = "lbResultadoFraseExemplo";
            this.lbResultadoFraseExemplo.Size = new System.Drawing.Size(10, 13);
            this.lbResultadoFraseExemplo.TabIndex = 7;
            this.lbResultadoFraseExemplo.Text = "-";
            // 
            // gbResultadoTradução
            // 
            this.gbResultadoTradução.Controls.Add(this.lbResultadoFraseExemplo);
            this.gbResultadoTradução.Controls.Add(this.lbResultadoPalavraTraduzida);
            this.gbResultadoTradução.Controls.Add(this.label7);
            this.gbResultadoTradução.Controls.Add(this.label5);
            this.gbResultadoTradução.Location = new System.Drawing.Point(59, 164);
            this.gbResultadoTradução.Name = "gbResultadoTradução";
            this.gbResultadoTradução.Size = new System.Drawing.Size(243, 121);
            this.gbResultadoTradução.TabIndex = 7;
            this.gbResultadoTradução.TabStop = false;
            this.gbResultadoTradução.Text = "Resultados";
            // 
            // PaginaMultiDicionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 297);
            this.Controls.Add(this.gbResultadoTradução);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.cbxIdiomaTraduzir);
            this.Controls.Add(this.tbPalavra);
            this.Controls.Add(this.cbxIdiomaOriginal);
            this.Name = "PaginaMultiDicionario";
            this.Text = "Multi-Dicionário";
            this.Load += new System.EventHandler(this.PaginaMultiDicionario_Load);
            this.gbResultadoTradução.ResumeLayout(false);
            this.gbResultadoTradução.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox tbPalavra;
        private System.Windows.Forms.ComboBox cbxIdiomaTraduzir;
        private System.Windows.Forms.Button btnTraduzir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbResultadoPalavraTraduzida;
        private System.Windows.Forms.Label lbResultadoFraseExemplo;
        private System.Windows.Forms.GroupBox gbResultadoTradução;
        private System.Windows.Forms.ComboBox cbxIdiomaOriginal;
    }
}