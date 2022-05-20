namespace Multi_Dicionario.Paginas
{
    partial class PaginaGerenciarIdioma
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
            this.tbNomeIdioma = new System.Windows.Forms.MaskedTextBox();
            this.btInserirIdioma = new System.Windows.Forms.Button();
            this.btAlterarIdioma = new System.Windows.Forms.Button();
            this.btExcluirIdioma = new System.Windows.Forms.Button();
            this.lbDigiteIdioma = new System.Windows.Forms.Label();
            this.dgIdioma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeIdioma
            // 
            this.tbNomeIdioma.Location = new System.Drawing.Point(26, 99);
            this.tbNomeIdioma.Name = "tbNomeIdioma";
            this.tbNomeIdioma.Size = new System.Drawing.Size(100, 20);
            this.tbNomeIdioma.TabIndex = 0;
            // 
            // btInserirIdioma
            // 
            this.btInserirIdioma.Location = new System.Drawing.Point(26, 139);
            this.btInserirIdioma.Name = "btInserirIdioma";
            this.btInserirIdioma.Size = new System.Drawing.Size(100, 23);
            this.btInserirIdioma.TabIndex = 1;
            this.btInserirIdioma.Text = "Inserir";
            this.btInserirIdioma.UseVisualStyleBackColor = true;
            this.btInserirIdioma.Click += new System.EventHandler(this.btInserirIdioma_Click);
            // 
            // btAlterarIdioma
            // 
            this.btAlterarIdioma.Location = new System.Drawing.Point(26, 168);
            this.btAlterarIdioma.Name = "btAlterarIdioma";
            this.btAlterarIdioma.Size = new System.Drawing.Size(100, 23);
            this.btAlterarIdioma.TabIndex = 2;
            this.btAlterarIdioma.Text = "Alterar";
            this.btAlterarIdioma.UseVisualStyleBackColor = true;
            // 
            // btExcluirIdioma
            // 
            this.btExcluirIdioma.Location = new System.Drawing.Point(26, 197);
            this.btExcluirIdioma.Name = "btExcluirIdioma";
            this.btExcluirIdioma.Size = new System.Drawing.Size(100, 23);
            this.btExcluirIdioma.TabIndex = 3;
            this.btExcluirIdioma.Text = "Excluir";
            this.btExcluirIdioma.UseVisualStyleBackColor = true;
            this.btExcluirIdioma.Click += new System.EventHandler(this.btExcluirIdioma_Click);
            // 
            // lbDigiteIdioma
            // 
            this.lbDigiteIdioma.AutoSize = true;
            this.lbDigiteIdioma.Location = new System.Drawing.Point(23, 83);
            this.lbDigiteIdioma.Name = "lbDigiteIdioma";
            this.lbDigiteIdioma.Size = new System.Drawing.Size(77, 13);
            this.lbDigiteIdioma.TabIndex = 4;
            this.lbDigiteIdioma.Text = "Digite o Idioma";
            // 
            // dgIdioma
            // 
            this.dgIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIdioma.Location = new System.Drawing.Point(168, 61);
            this.dgIdioma.Name = "dgIdioma";
            this.dgIdioma.Size = new System.Drawing.Size(240, 191);
            this.dgIdioma.TabIndex = 5;
            this.dgIdioma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIdioma_CellContentClick);
            // 
            // PaginaGerenciarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 311);
            this.Controls.Add(this.dgIdioma);
            this.Controls.Add(this.lbDigiteIdioma);
            this.Controls.Add(this.btExcluirIdioma);
            this.Controls.Add(this.btAlterarIdioma);
            this.Controls.Add(this.btInserirIdioma);
            this.Controls.Add(this.tbNomeIdioma);
            this.Name = "PaginaGerenciarIdioma";
            this.Text = "Gerenciar Idiomas";
            ((System.ComponentModel.ISupportInitialize)(this.dgIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbNomeIdioma;
        private System.Windows.Forms.Button btInserirIdioma;
        private System.Windows.Forms.Button btAlterarIdioma;
        private System.Windows.Forms.Button btExcluirIdioma;
        private System.Windows.Forms.Label lbDigiteIdioma;
        private System.Windows.Forms.DataGridView dgIdioma;
    }
}