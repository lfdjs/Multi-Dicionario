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
    public partial class PaginaCadastro : Form
    {
        #region Instância de classes externas

        UsuarioDAO usuariodao = new UsuarioDAO();
        

        #endregion

        #region Declaração de variáveis

        string _login, _senha, _confirmaSenha, _perguntaSecreta, _respostaSecreta;

        

        #endregion

        #region Inicialização dos Componentes
        public PaginaCadastro()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos





        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                MessageBox.Show("Voce esqueceu de preencher o login, favor preencha o campo!");
                tbLogin.Focus();
            }
            else if (tbSenha.Text == "")
            {
                MessageBox.Show("Você esqueceu de preencher o campo de senha, favor preencha o campo!");
                tbSenha.Focus();
            }
            else if (tbConfirmaSenha.Text == "")
            {
                MessageBox.Show("Você esqueceu de preencher o campo de confirmar a senha, favor preencha o campo!");
                tbConfirmaSenha.Focus();
            }
            else if (tbRespostaSecreta.Text == "")
            {
                MessageBox.Show("Você esqueceu de preencher a resposta da sua pergunta secreta, favor preencha o campo!");
                tbRespostaSecreta.Focus();
            }
            else if (tbSenha.Text != tbConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não conferem, favor digite novamente a senha");
                tbSenha.Clear();
                tbConfirmaSenha.Clear();
                tbSenha.Focus();
            }
            else
            {
                try
                {
                    _login = tbLogin.Text;
                    _senha = tbSenha.Text;
                    _confirmaSenha = tbConfirmaSenha.Text;
                    _perguntaSecreta = cbxPerguntaSecreta.Text;
                    _respostaSecreta = tbRespostaSecreta.Text;

                    if (tbSenha.Text != tbConfirmaSenha.Text)
                    {
                        MessageBox.Show("As senhas não conferem, favor digite novamente!");
                        tbSenha.Clear();
                        tbConfirmaSenha.Clear();
                        tbSenha.Focus();
                    }
                    else
                    {
                        usuariodao.cadastrarUsuariosPadrao(_login, _senha, _perguntaSecreta, _respostaSecreta);
                        MessageBox.Show("Cadastro realizado com sucesso, voce ja pode efetuar o login "+tbLogin.Text);
                        Close();
                        


                    }
                }
                catch(MySqlException erro)
                {
                    throw erro;

                }
            }
        }


    }
}
