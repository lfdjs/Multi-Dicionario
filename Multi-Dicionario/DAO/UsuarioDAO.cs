using Multi_Dicionario.Banco_de_Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dicionario.DAO
{
    class UsuarioDAO
    {

        #region Instância da Conexão

        ConexaoBanco conexao = new ConexaoBanco();
        private string sql;
        private MySqlCommand comando;
        private MySqlDataReader read;
        private MySqlDataAdapter adpt;
        private DataTable dt;
        bool acessar;

        #endregion

        #region Métodos

        #region Método de exibir os usuários

        public DataTable exibirUsuarios()
        {

            sql = "SELECT login FROM usuario ORDER BY login ASC";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    return dt;
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.desconectar();
                }

            }
            else
            {
                return null;
            }

        }


        #endregion

        #region Método de cadastrar os usuarios
        public bool cadastrarUsuariosPadrao(string login, string senha, string perguntaSecreta, string respostaSecreta)
        {
            sql = "INSERT INTO usuario (perfil_idPerfil, login, senha, perguntaSecreta, respostaSecreta ) VALUES (2, @login, @senha, @perguntaSecreta, @respostaSecreta)";
            if (conexao.conectar())
            {
                try
                {

                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@login", login);
                    comando.Parameters.AddWithValue("@senha", senha);
                    comando.Parameters.AddWithValue("@perguntaSecreta", perguntaSecreta);
                    comando.Parameters.AddWithValue("@respostaSecreta", respostaSecreta);
                    comando.ExecuteNonQuery();
                    return true;

                }
                catch (MySqlException erro)
                {
                    throw erro;
                }

                finally
                {
                    conexao.desconectar();
                }
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region  Método de login

        public bool loginUsuario(string login, string senha)
        {
            sql = "SELECT login, senha, perfil_idPerfil from usuario WHERE login = @login AND senha = @senha";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@login", login);
                    comando.Parameters.AddWithValue("@senha", senha);
                    
                    read = comando.ExecuteReader();
                    acessar = read.HasRows;

                    return acessar;
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
            else
            {
                return false;
            }
        }



        #endregion

        #region Método de exibir as perguntas secretas

        

        #endregion

        #region Método de filtrar a exibição dos usuários

        public DataTable exibirPalavraFiltro(string nomeUsuarioFiltro)
        {
            sql = "SELECT * FROM idioma LIKE @nomeUsuarioFiltro";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomeUsuarioFiltro", nomeUsuarioFiltro);
                    adpt = new MySqlDataAdapter(comando);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    return dt;
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {

                }

            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Método de verificar Login

        public bool verificaLogin(string login)
        {
            sql = "SELECT login from usuario WHERE login = @login";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@login", login);
                    read = comando.ExecuteReader();
                    acessar = read.HasRows;

                    return acessar;
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Verificar perfil pelo login

        public bool VerificaPerfilPorLogin(string login)
        {
            sql = "SELECT perfil_idPerfil from usuario WHERE login = @login AND perfil_idPerfil = 1" ;
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@login", login);
                    read = comando.ExecuteReader();
                    acessar = read.HasRows;

                    return acessar;
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
            else
            {
                return false;
            }
        }



        #endregion

        #region Mostrar pergunta secreta

        public DataTable mostraPerguntaSecreta(string login)
        {
            sql = "SELECT perguntaSecreta from usuario WHERE login = @login";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@login", login);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    return dt;

                    
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Verificar resposta secreta

        public bool verificaRespostaSecreta(string respostaSecreta)
        {
            sql = "SELECT respostaSecreta from usuario WHERE respostaSecreta = @respostaSecreta";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@respostaSecreta", respostaSecreta);
                    read = comando.ExecuteReader();
                    acessar = read.HasRows;

                    return acessar;
                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.desconectar();
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Altera Senha

        public bool alterarSenha(string senha, string login)
        {
            sql = "UPDATE usuario SET senha=@senha WHERE login= @login";
            if (conexao.conectar())
            {
                try
                {

                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@senha", senha);
                    comando.Parameters.AddWithValue("@login", login);
                    comando.ExecuteNonQuery();
                    return true;

                }
                catch (MySqlException erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.desconectar();
                }

            }
            else
            {
                return false;
            }

        }

        #endregion

        #endregion




    }
}
