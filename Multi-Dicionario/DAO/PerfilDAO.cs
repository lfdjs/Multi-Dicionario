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
    class PerfilDAO
    {

        #region Instância da Conexão

        ConexaoBanco conexao = new ConexaoBanco();
        private string sql;
        private MySqlCommand comando;
        private MySqlDataAdapter adpt;
        private DataTable dt;

        #endregion

        #region Métodos

        #region Método de exibir os Perfis

        public DataTable exibirPerfis()
        {

            sql = "SELECT nomeperfil FROM perfil ORDER BY nomePerfil ASC";
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

        #region Método de cadastrar as palavras
        public bool cadastrarPalavras(string nomePerfil)
        {
            if (conexao.conectar())
            {
                try
                {
                    sql = "INSERT INTO perfil (nomePerfil) VALUES (@nomePerfil)";
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomePerfil", nomePerfil);
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

        #region Método de Alterar Palavras

        public bool alterarPerfil(int idPerfil, string nomePerfil)
        {
            sql = "UPDATE perfil SET @nomePerfil WHERE idPerfil = @idPerfil";
            if (conexao.conectar())
            {
                try
                {

                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idPerfil", idPerfil);
                    comando.Parameters.AddWithValue("@nomePalavra", nomePerfil);
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

        #region Método de excluir o perfil

        public bool excluirPerfil(int idPerfil)
        {
            sql = "DELETE FROM perfil WHERE idPerfil = @idPerfil";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idPerfil", idPerfil);
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

        #region Método de filtrar a exibição do Perfil

        public DataTable exibirPerfilFiltro(string nomePerfilFiltro)
        {
            sql = "SELECT * FROM perfil LIKE @nomePerfilFiltro";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomePerfilFiltro", nomePerfilFiltro);
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

        #endregion

    }
}
