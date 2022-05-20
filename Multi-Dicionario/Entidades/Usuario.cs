using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dicionario.Entidades
{
    class Usuario
    {
        int idUsuario;
        int perfil_idPerfil;
        string login;
        string senha;

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public int Perfil_idPerfil
        {
            get
            {
                return perfil_idPerfil;
            }

            set
            {
                perfil_idPerfil = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
    }
}
