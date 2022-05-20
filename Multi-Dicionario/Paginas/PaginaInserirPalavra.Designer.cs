namespace Multi_Dicionario.Paginas
{
    partial class PaginaInserirPalavra
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
            this.tbPalavra = new System.Windows.Forms.MaskedTextBox();
            this.tbDescricao = new System.Windows.Forms.MaskedTextBox();
            this.cbxIdioma = new System.Windows.Forms.ComboBox();
            this.cbxPalavraPadrao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPalavraPadrao = new System.Windows.Forms.Label();
            this.dgPalavra = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPalavra)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPalavra
            // 
            this.tbPalavra.Location = new System.Drawing.Point(12, 109);
            this.tbPalavra.Name = "tbPalavra";
            this.tbPalavra.Size = new System.Drawing.Size(121, 20);
            this.tbPalavra.TabIndex = 0;
            this.tbPalavra.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbPalavra_MaskInputRejected);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(12, 154);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(172, 20);
            this.tbDescricao.TabIndex = 1;
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.Location = new System.Drawing.Point(12, 25);
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(121, 21);
            this.cbxIdioma.TabIndex = 2;
            this.cbxIdioma.SelectedIndexChanged += new System.EventHandler(this.cbxIdioma_SelectedValueChanged);
            // 
            // cbxPalavraPadrao
            // 
            this.cbxPalavraPadrao.FormattingEnabled = true;
            this.cbxPalavraPadrao.Location = new System.Drawing.Point(12, 69);
            this.cbxPalavraPadrao.Name = "cbxPalavraPadrao";
            this.cbxPalavraPadrao.Size = new System.Drawing.Size(121, 21);
            this.cbxPalavraPadrao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite a palavra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite a frase de exemplo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escolha o Idioma";
            // 
            // lbPalavraPadrao
            // 
            this.lbPalavraPadrao.AutoSize = true;
            this.lbPalavraPadrao.Location = new System.Drawing.Point(12, 53);
            this.lbPalavraPadrao.Name = "lbPalavraPadrao";
            this.lbPalavraPadrao.Size = new System.Drawing.Size(121, 13);
            this.lbPalavraPadrao.TabIndex = 7;
            this.lbPalavraPadrao.Text = "Defina a palavra padrão";
            // 
            // dgPalavra
            // 
            this.dgPalavra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPalavra.Location = new System.Drawing.Point(190, 43);
            this.dgPalavra.Name = "dgPalavra";
            this.dgPalavra.Size = new System.Drawing.Size(324, 163);
            this.dgPalavra.TabIndex = 8;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(22, 180);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // PaginaInserirPalavra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 296);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgPalavra);
            this.Controls.Add(this.lbPalavraPadrao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPalavraPadrao);
            this.Controls.Add(this.cbxIdioma);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbPalavra);
            this.Name = "PaginaInserirPalavra";
            this.Text = "Inserir Palavras";
            ((System.ComponentModel.ISupportInitialize)(this.dgPalavra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbPalavra;
        private System.Windows.Forms.MaskedTextBox tbDescricao;
        private System.Windows.Forms.ComboBox cbxIdioma;
        private System.Windows.Forms.ComboBox cbxPalavraPadrao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPalavraPadrao;
        private System.Windows.Forms.DataGridView dgPalavra;
        private System.Windows.Forms.Button btnInserir;
    }
}