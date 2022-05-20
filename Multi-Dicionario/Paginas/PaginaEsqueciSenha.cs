using Multi_Dicionario.Banco_de_Dados;
using Multi_Dicionario.DAO;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace Multi_Dicionario.Paginas
{

    public partial class PaginaEsqueciSenha : Form
    {
        ConexaoBanco  conexao = new ConexaoBanco();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        
        
        public PaginaEsqueciSenha()
        {
            InitializeComponent();
            gbPerguntaResposta.Visible = false;
            gbAlterarSenha.Visible = false;
        }

        private void btnVerificaLogin_Click(object sender, System.EventArgs e)
        {
            string _login = tbVerificaLogin.Text;
            if (_login == "")
            {
                MessageBox.Show("Favor digite o login");
                tbVerificaLogin.Focus();
            }
            else if (usuarioDAO.verificaLogin(_login))
            {
                gbPerguntaResposta.Visible = true;
                DataTable perguntaSecreta = usuarioDAO.mostraPerguntaSecreta(_login);
                lbPergunta.Text = perguntaSecreta.Rows[0]["perguntaSecreta"].ToString();

            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }

        }

        private void btnVerificaResposta_Click(object sender, System.EventArgs e)
        {
            string _respostaSecreta = tbResposta.Text;
            if (_respostaSecreta == "")
            {
                MessageBox.Show("Favor digite a resposta secreta");
            }
            else if (usuarioDAO.verificaRespostaSecreta(_respostaSecreta))
            {
                gbAlterarSenha.Visible = true;
                
                

            }
            else
            {
                MessageBox.Show("Resposta secreta incorreta!");
            }
        }

        private void btAlterarSenha_Click(object sender, System.EventArgs e)
        {
            if (tbNovaSenha.Text == "")
            {
                MessageBox.Show("Favor, preencha sua nova senha!");
                tbNovaSenha.Focus();

            }
            else if (tbConfirmaSenha.Text == "")
            {
                MessageBox.Show("Favor, preencha o campo para confirmar a sua senha!");
                tbConfirmaSenha.Focus();
            }
            else if (tbNovaSenha.Text != tbConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não conferem");
                tbNovaSenha.Clear();
                tbConfirmaSenha.Clear();
                tbNovaSenha.Focus();

            }
            else
            {
                string _senha = tbNovaSenha.Text;
                string _login = tbVerificaLogin.Text;
                usuarioDAO.alterarSenha(_senha, _login);
                
                MessageBox.Show("Sua senha foi alterada com sucesso");
                Close();
                

            }
        }
        
    }
}
