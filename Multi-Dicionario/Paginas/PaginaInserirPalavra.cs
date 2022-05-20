using Multi_Dicionario.DAO;
using MySql.Data.MySqlClient;
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
    public partial class PaginaInserirPalavra : Form
    {
        PalavraDAO palavra = new PalavraDAO();
        public PaginaInserirPalavra()
        {
            InitializeComponent();
            exibirIdiomas();
            exibirPalavras();
            
            exibirPalavrasPortugues();
        }

        private void exibirIdiomas()
        {
            cbxIdioma.DataSource = palavra.exibirIdiomas();
            cbxIdioma.DisplayMember = "nomeIdioma";
            cbxIdioma.ValueMember = "idIdioma";

        }

        private void tbPalavra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void exibirPalavras()
        {
            dgPalavra.DataSource = palavra.exibirPalavras();
        }

        private void esconderPalavraPadrao()
        {
            string _idiomaIdidioma = Convert.ToString(cbxIdioma.SelectedValue);

            if (_idiomaIdidioma == "1")
            {
                lbPalavraPadrao.Visible = false;
                cbxPalavraPadrao.Visible = false;
            }
            else
            {
                lbPalavraPadrao.Visible = true;
                cbxPalavraPadrao.Visible = true;
            }


        }

        private void cbxIdioma_SelectedValueChanged(object sender, EventArgs e)
        {
            esconderPalavraPadrao();
        }

        private void exibirPalavrasPortugues()
        {
            cbxPalavraPadrao.DataSource = palavra.exibirPalavrasPortugues();
            cbxPalavraPadrao.DisplayMember = "nomePalavra";
            cbxPalavraPadrao.ValueMember = "idPalavra";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string _nomePalavra = tbPalavra.Text;
            string _descricao = tbDescricao.Text;
            
            int _idiomaIdidioma = Convert.ToInt32(cbxIdioma.SelectedValue);
           
            
            try

            {
                if (_idiomaIdidioma == 1)
                {
                    
                    
                    DataTable id = palavra.exibirPalavrasUltimoId();
                    string ultimoId = id.Rows[0]["idPalavra"].ToString();
                    int ultimoMaisum = Convert.ToInt32(ultimoId) + 1;
                    int _palavraPadrao = ultimoMaisum;
                    palavra.cadastrarPalavras(_nomePalavra, _descricao, _palavraPadrao, _idiomaIdidioma);

                }
            else
            {
                   int _palavraPadrao = Convert.ToInt32(cbxPalavraPadrao.SelectedValue);
                    palavra.cadastrarPalavras(_nomePalavra, _descricao, _palavraPadrao, _idiomaIdidioma);
                }

                    
                MessageBox.Show("Acertô Mizeravi");
                
            }
            catch (MySqlException)
            {
                MessageBox.Show("Errow");
            }
            
            

        }
    }
}
