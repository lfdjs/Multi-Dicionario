using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Dicionario.Paginas
{
    public partial class PaginaPainelAdm : Form
    {
        PaginaSobre sobre = new PaginaSobre();
        PaginaInserirPalavra inserirPalavra = new PaginaInserirPalavra();
        PaginaGerenciarIdioma gerenciaIdioma = new PaginaGerenciarIdioma();
        PaginaMultiDicionario multiDicionario = new PaginaMultiDicionario(); 
        public PaginaPainelAdm()
        {
            InitializeComponent();
        }

        private void lklbSobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sobre.ShowDialog();
        }

        private void btnGerenciaIdioma_Click(object sender, EventArgs e)
        {
            gerenciaIdioma.ShowDialog();
        }

        private void btnGerenciaPalavra_Click(object sender, EventArgs e)
        {
            inserirPalavra.ShowDialog();
        }

        private void btnMultiDicionario_Click(object sender, EventArgs e)
        {
            multiDicionario.ShowDialog();
        }
    }
}
