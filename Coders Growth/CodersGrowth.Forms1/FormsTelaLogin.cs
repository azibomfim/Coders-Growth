using CodersGrowth.Servicos.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodersGrowth.Forms1
{
    public partial class FormsTelaLogin : Form
    {
        private readonly ServicoPersonagem _servicoPersonagem;
        private readonly ServicoUsuario _servicoUsuario;

        public FormsTelaLogin(ServicoUsuario servicoUsuario)
        {
            InitializeComponent();

            _servicoUsuario = servicoUsuario;
        }
        private void FormsTelaLogin_Load(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            ServicoPersonagem servicoPersonagem = _servicoPersonagem;
            new FormListaPersonagem(_servicoPersonagem);
        }
    }
}
