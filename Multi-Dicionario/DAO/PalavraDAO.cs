using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Multi_Dicionario.Banco_de_Dados;
using System.Data;

namespace Multi_Dicionario.DAO
{
    class PalavraDAO
    {

        #region Instância da Conexão

        ConexaoBanco conexao = new ConexaoBanco();
        private string sql;
        private MySqlCommand comando;
        private MySqlDataAdapter adpt;
        private DataTable dt;

        #endregion

        #region Métodos

        #region Método de exibir as Palavras
        public DataTable exibirPalavras()
        {

            sql = "SELECT nomePalavra FROM palavra ORDER BY nomePalavra ASC";
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
        public bool cadastrarPalavras(string nomeIdioma, string descricao, int palavraPadrao, int idioma_idIdioma)
        {
            if (conexao.conectar())
            {
                try
                {
                    sql = "INSERT INTO palavra (nomePalavra, descricao, palavraPadrao, idioma_idIdioma) VALUES (@nomePalavra, @descricao, @palavraPadrao, @idioma_idIdioma)";
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomePalavra", nomeIdioma);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@palavraPadrao", palavraPadrao);
                    comando.Parameters.AddWithValue("@idioma_idIdioma", idioma_idIdioma);
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

        public bool alterarPalavra(int idPalavra, string nomePalavra, string descricao, int palavraPadrao, int idioma_idIdioma)
        {
            sql = "UPDATE palavra SET @nomepalavra, @descricao, @palavraPadrao, @idioma_idIdioma WHERE idPalavra = @idPalavra";
            if (conexao.conectar())
            {
                try
                {

                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idPalavra", idPalavra);
                    comando.Parameters.AddWithValue("@nomePalavra", nomePalavra);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@palavraPadrao", palavraPadrao);
                    comando.Parameters.AddWithValue("@idioma_idIdioma", idioma_idIdioma);
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

        #region Método de excluir as Palavras

        public bool excluirPalavra(int idPalavra)
        {
            sql = "DELETE FROM palavra WHERE idpalavra = @idPalavra";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idPalavra", idPalavra);
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

        public DataTable exibirIdiomas()
        {

            sql = "SELECT nomeIdioma, idIdioma FROM idioma ORDER BY idIdioma";
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

        #region Método de filtrar a exibição das Palavras

        public DataTable exibirPalavraFiltro(string nomePalavraFiltro)
        {
            sql = "SELECT * FROM idioma LIKE @nomePalavraFiltro";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomePalavraFiltro", nomePalavraFiltro);
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

        public DataTable exibirPalavrasPortugues()
        {
            sql = "SELECT idPalavra, nomePalavra FROM palavra WHERE idioma_idIdioma = 1";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
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

        public DataTable exibirPalavrasUltimoId()
        {
            sql = "SELECT * FROM palavra order by idPalavra desc";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
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

    }
}
