using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Dicionario.Paginas
{
    public partial class PaginaUsuarioPadrao : Form
    {
        PaginaMultiDicionario multiDicionario = new PaginaMultiDicionario();
        public PaginaUsuarioPadrao()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            multiDicionario.ShowDialog();
        }
    }
}
