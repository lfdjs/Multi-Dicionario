using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Multi_Dicionario.Banco_de_Dados
{
    class ConexaoBanco
    {
        string url = @"server=localhost;Database=multidicionario;Uid=lfdjs;pwd='lfdjs091091'";

        public MySqlConnection conexao = null;

        public bool conectar()
        {
            conexao = new MySqlConnection(url);

            try
            {
                conexao.Open();
                return true;
            }
            catch (MySqlException erro)
            {
                throw erro;
            }

           
        }

        public bool desconectar()
        {
            if (conexao.State != ConnectionState.Closed)
            {
                
                conexao.Close();
                conexao.Dispose();
                return true;

            }
            else
            {
                conexao.Dispose();
                return false;
            }

        }

        
    }
}
