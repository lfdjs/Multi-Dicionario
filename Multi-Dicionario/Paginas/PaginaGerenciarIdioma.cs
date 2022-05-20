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
    public partial class PaginaGerenciarIdioma : Form
    {
        IdiomaDAO idioma = new IdiomaDAO();
        public PaginaGerenciarIdioma()
        {
            InitializeComponent();
            exibirIdiomas();
        }

        private void exibirIdiomas()
        {
            dgIdioma.DataSource = idioma.exibirIdiomas();
        }

        private void btExcluirIdioma_Click(object sender, EventArgs e)
        {
            if (tbNomeIdioma.Text == "")
            {
                MessageBox.Show("Favor, clique no idioma que deseja excluir");
            }
            else
            {
                try
                {
                    var confirma = MessageBox.Show("Você tem certeza? Esta ação não poderá ser desfeita", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                    if (confirma == DialogResult.Yes)
                    {
                      int _ididioma = int.Parse(tbNomeIdioma.Text);
                        idioma.excluirIdioma(_ididioma);
                        MessageBox.Show("O Idioma "+_ididioma+" foi excluido com sucesso");
                    }
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
            }
        }

        private void mostraLinha()
        {
            int posicaoLinha = dgIdioma.CurrentRow.Index;
            //MessageBox.Show("Linha: " + posicaoLinha);
            tbNomeIdioma.Text = dgIdioma[0, posicaoLinha].Value.ToString();
            
        }

        private void dgIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostraLinha();
        }

        private void btInserirIdioma_Click(object sender, EventArgs e)
        {
            if (tbNomeIdioma.Text == "")
            {
                MessageBox.Show("Favor Insira o nome do idioma");
            }
            else
            {
                try
                {
                    string _nomeIdioma = tbNomeIdioma.Text;
                    idioma.cadastraridiomas(_nomeIdioma);
                    MessageBox.Show("O idioma "+_nomeIdioma+" foi cadastrado com sucesso!");
                    exibirIdiomas();
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
            }
        }
    }
}
