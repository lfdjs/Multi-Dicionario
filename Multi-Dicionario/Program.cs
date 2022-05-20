using Multi_Dicionario.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Dicionario
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PaginaLogin());
            //Application.Run(new PaginaEsqueciSenha());
            Application.Run(new PaginaMultiDicionario());
            //Application.Run(new PaginaSobre());
            //Application.Run(new PaginaPainelAdm());
            //Application.Run(new PaginaUsuarioPadrao());
            
            //Application.Run(new PaginaCadastro());
            //Application.Run(new PaginaInserirPalavra());
            //Application.Run(new PaginaInserirIdioma());
        }
    }
}
