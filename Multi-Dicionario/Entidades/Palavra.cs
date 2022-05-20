using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dicionario.Entidades
{
    class Palavra
    {
        int idPalavra;
        string nomePalavra;
        string descricao;
        int palavraPadrao;
        int idioma_idIdioma;

        public int IdPalavra
        {
            get
            {
                return idPalavra;
            }

            set
            {
                idPalavra = value;
            }
        }

        public string NomePalavra
        {
            get
            {
                return nomePalavra;
            }

            set
            {
                nomePalavra = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public int PalavraPadrao
        {
            get
            {
                return palavraPadrao;
            }

            set
            {
                palavraPadrao = value;
            }
        }

        public int Idioma_idIdioma
        {
            get
            {
                return idioma_idIdioma;
            }

            set
            {
                idioma_idIdioma = value;
            }
        }
    }
}
