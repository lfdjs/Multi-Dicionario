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
    public partial class PaginaLogin : Form
    {
        PaginaEsqueciSenha esqueciSenha = new PaginaEsqueciSenha();
        PaginaCadastro primeiroAcesso = new PaginaCadastro();
        PaginaPainelAdm painelAdm = new PaginaPainelAdm();
        PaginaUsuarioPadrao usuarioPadrao = new PaginaUsuarioPadrao();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string _login = tbLogin.Text;
            string _senha = tbSenha.Text;
            if (usuarioDAO.loginUsuario(_login, _senha))
            {
                if (usuarioDAO.VerificaPerfilPorLogin(_login))
                {
                    
                    painelAdm.ShowDialog();

                }
                else
                {
                    
                    usuarioPadrao.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Login ou senha Inválidos");
            }

        }

        private void lklbPrimeiroAcesso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            primeiroAcesso.ShowDialog();

        }

        private void lklbEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            esqueciSenha.ShowDialog();
            
        }
    }
}
