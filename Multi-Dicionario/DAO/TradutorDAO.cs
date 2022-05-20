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


    class TradutorDAO
    {
        #region Instância da Conexão

        ConexaoBanco conexao = new ConexaoBanco();
        private string sql;
        private MySqlCommand comando;
        private MySqlDataAdapter adpt;
        private DataTable dt;
        #endregion

        #region Método de traduzir

        public DataTable traduzirPalavra(int idiomaOriginal, string palavraOriginal, int idiomaDestino )
        {
          
            sql = "select p.nomePalavra as Palavra_traduzida, p.descricao as Frase from palavra p join idioma m on p.idioma_idIdioma = m.idIdioma join palavra f on f.palavraPadrao = p.palavraPadrao where f.idioma_idIdioma = @idiomaOriginal and f.nomePalavra = @palavraOriginal and p.idioma_idIdioma = @idiomaDestino ";





            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idiomaOriginal", idiomaOriginal);
                    comando.Parameters.AddWithValue("@palavraOriginal", palavraOriginal);
                    comando.Parameters.AddWithValue("@idiomaDestino", idiomaDestino);
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


        public DataTable mostraPalavraTraduzida(int idiomaOriginal, string palavraOriginal, int idiomaDestino)
        {
            
            sql = "select p.nomePalavra as Palavra_traduzida from palavra p join idioma m on p.idioma_idIdioma = m.idIdioma join palavra f on f.palavraPadrao = p.palavraPadrao join palavra ex on ex.descricao = p.descricao where f.idioma_idIdioma = @idiomaOriginal and f.nomePalavra = @nomePalavra and p.idioma_idIdioma = @idiomadestino ";





            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idiomaOriginal", idiomaOriginal);
                    comando.Parameters.AddWithValue("@palavraOriginal", palavraOriginal);
                    comando.Parameters.AddWithValue("@idiomaDestino", idiomaDestino);
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

        public DataTable mostrarFraseExemplo(int idiomaOriginal, string palavraOriginal, int idiomaDestino)
        {
            //sql = "select f.nomePalavra as Palavra_original, p.nomePalavra as Palavra_traduzida, m.nomeIdioma as Novo_idioma, ex.descricao as Frase from palavra p join idioma m on p.idioma_idIdioma = m.idIdioma join palavra f on f.palavraPadrao = p.palavraPadrao join palavra ex on ex.descricao = p.descricao where f.idioma_idIdioma = @f_idioma_idIdioma and f.nomePalavra = @f_nomePalavra and p.idioma_idIdioma = @p_idioma_idIdioma";
            sql = "select p.nomePalavra as Palavra_traduzida, p.descricao as Frase from palavra p join idioma m on p.idioma_idIdioma = m.idIdioma join palavra f on f.palavraPadrao = p.palavraPadrao join palavra ex on ex.descricao = p.descricao where f.idioma_idIdioma = @idiomaOriginal and f.nomePalavra = @nomePalavra and p.idioma_idIdioma = @idiomadestino ";





            if (conexao.conectar())
            {
                try
                {
                    comando = new MySqlCommand(sql, conexao.conexao);
                    comando.Parameters.AddWithValue("@idiomaOriginal", idiomaOriginal);
                    comando.Parameters.AddWithValue("@palavraOriginal", palavraOriginal);
                    comando.Parameters.AddWithValue("@idiomaDestino", idiomaDestino);
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


    }


}
