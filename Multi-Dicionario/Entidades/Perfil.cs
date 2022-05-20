using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dicionario.Entidades
{
    class Perfil
    {
        int idPerfil;
        string nomePerfil;

        public int IdPerfil
        {
            get
            {
                return idPerfil;
            }

            set
            {
                idPerfil = value;
            }
        }

        public string NomePerfil
        {
            get
            {
                return nomePerfil;
            }

            set
            {
                nomePerfil = value;
            }
        }
    }
}
