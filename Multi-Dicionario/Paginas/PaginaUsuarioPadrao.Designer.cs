namespace Multi_Dicionario.Paginas
{
    partial class PaginaUsuarioPadrao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaUsuarioPadrao));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btAcessar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTextoIntroducao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(227, 221);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sobre o programa";
            // 
            // btAcessar
            // 
            this.btAcessar.Location = new System.Drawing.Point(98, 163);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(135, 23);
            this.btAcessar.TabIndex = 1;
            this.btAcessar.Text = "Acessar Multi-Dicionário";
            this.btAcessar.UseVisualStyleBackColor = true;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTextoIntroducao);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btAcessar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seja bem vindo ao Multi-Dicionário";
            // 
            // lbTextoIntroducao
            // 
            this.lbTextoIntroducao.AutoSize = true;
            this.lbTextoIntroducao.Location = new System.Drawing.Point(47, 28);
            this.lbTextoIntroducao.Name = "lbTextoIntroducao";
            this.lbTextoIntroducao.Size = new System.Drawing.Size(236, 104);
            this.lbTextoIntroducao.TabIndex = 0;
            this.lbTextoIntroducao.Text = resources.GetString("lbTextoIntroducao.Text");
            this.lbTextoIntroducao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaginaUsuarioPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaginaUsuarioPadrao";
            this.Text = "PaginaUsuarioPadrao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTextoIntroducao;
    }
}