using Multi_Dicionario.DAO;
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
    public partial class PaginaMultiDicionario : Form
    {
        TradutorDAO tradutor = new TradutorDAO();
        IdiomaDAO idioma = new IdiomaDAO();
        public PaginaMultiDicionario()
        {
            InitializeComponent();
            exibirIdiomas();
            
        }

        private void exibirIdiomas()
        {
            cbxIdiomaOriginal.DataSource = idioma.exibirIdiomas();
            cbxIdiomaOriginal.DisplayMember = "nomeIdioma";
            cbxIdiomaOriginal.ValueMember = "idIdioma";
                
        }
        private void exibirIdiomasRestantes()
        {
            string nomeIdioma = Convert.ToString(cbxIdiomaOriginal.SelectedValue);
            //MessageBox.Show("Test"+nomeIdioma);
            cbxIdiomaTraduzir.DataSource = idioma.exibirIdiomasRestantes(nomeIdioma);
            cbxIdiomaTraduzir.DisplayMember = "nomeIdioma";
            cbxIdiomaTraduzir.ValueMember = "idIdioma";
                
        }

       

        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            string palavraOriginal = tbPalavra.Text;
            int idiomaOriginal = Convert.ToInt32(cbxIdiomaOriginal.SelectedValue);
            int idiomaDestino = Convert.ToInt32(cbxIdiomaTraduzir.SelectedValue);
            DataTable palavra = tradutor.traduzirPalavra(idiomaOriginal, palavraOriginal, idiomaDestino);
            lbResultadoPalavraTraduzida.Text = palavra.Rows[0]["Palavra_traduzida"].ToString();
            lbResultadoFraseExemplo.Text = palavra.Rows[0]["Frase"].ToString();

        }

        private void exibirPalavraTraduzida()
        {
            
        }

        private void cbxIdiomaOriginal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            exibirIdiomasRestantes();
        }

        private void PaginaMultiDicionario_Load(object sender, EventArgs e)
        {

        }
    }
}
