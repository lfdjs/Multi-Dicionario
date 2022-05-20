using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dicionario.Entidades
{
    class Idioma
    {
        int idIdioma;
        string nomeIdioma;

        public int IdIdioma
        {
            get
            {
                return idIdioma;
            }

            set
            {
                idIdioma = value;
            }
        }

        public string NomeIdioma
        {
            get
            {
                return nomeIdioma;
            }

            set
            {
                nomeIdioma = value;
            }
        }
    }
}
