using Multi_Dicionario.Banco_de_Dados;
using MySql.Data.MySqlClient;
using System.Data;

namespace Multi_Dicionario.DAO
{
    class IdiomaDAO
    {
        #region Instância da Conexão

        ConexaoBanco conexao = new ConexaoBanco();
        private string sql;
        private MySqlCommand comando;
        private MySqlDataAdapter adpt;
        private DataTable dt;

        #endregion

        #region Métodos

        #region Método de exibir os idiomas

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


        #endregion

        #region Exibir idiomas restantes

        public DataTable exibirIdiomasRestantes(string nomeIdioma)
        {

            sql = "SELECT nomeIdioma, idIdioma FROM idioma WHERE idIdioma <> @idIdioma";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(comando);
                    comando.Parameters.AddWithValue("@idIdioma", nomeIdioma);
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
        
        #region Método de cadastrar os idiomas
        public bool cadastraridiomas(string nomeIdioma)
        {
            if (conexao.conectar())
            {
                try
                {
                    sql = "INSERT INTO idioma (nomeIdioma) VALUES (@nomeIdioma)";
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomeIdioma", nomeIdioma);
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

        #region Método de Alterar Idiomas

        public bool alterarIdioma(int idIdioma, string nomeIdioma)
        {
            sql = "UPDATE idioma SET @nomeIdioma WHERE idIdioma = @idIdioma";
            if (conexao.conectar())
            {
                try
                {

                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idIdioma", idIdioma);
                    comando.Parameters.AddWithValue("@nomeIdioma", nomeIdioma);
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

        #region Método de excluir os idiomas

        public bool excluirIdioma(int idIdioma)
        {
            sql = "DELETE FROM idioma WHERE idIdioma = @idIdioma";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idIdioma", idIdioma);
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

        #region Método de filtrar a exibição dos idiomas

        public DataTable exibirIdiomaFiltro(string nomeIdiomaFiltro)
        {
            sql = "SELECT * FROM idioma LIKE @nomeIdiomaFiltro";
            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@nomeIdiomaFiltro", nomeIdiomaFiltro);
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
