using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;

namespace CodersGrowth.Forms1
{
    public partial class FormsCadastroUsuario : Form
    {
        private ServicoPersonagem _servicoPersonagem;
        private ServicoUsuario _servicoUsuario;
        private FormCadastroPersonagem _formCadastroPersonagem;
        public FormsCadastroUsuario(ServicoPersonagem servicoPersonagem, ServicoUsuario servicoUsuario)
        {
            _servicoUsuario = servicoUsuario;
            _servicoPersonagem = servicoPersonagem;
            InitializeComponent();
        }

        private void cadastrarNovoUsuario()
        {
            try
            {
                var adventureRank = ConverterParaInt(textBoxAR.Text);

                var usuarioNovo = new Usuario();
                usuarioNovo.NomeDeUsuario = textBoxNome.Text;
                usuarioNovo.AdventureRank = adventureRank;
                _servicoUsuario.Criar(usuarioNovo);
                var formCadastroPersonagem = new FormCadastroPersonagem(_servicoPersonagem, _servicoUsuario);
                formCadastroPersonagem.personagemNovo.NomeUsuario = usuarioNovo.NomeDeUsuario;

                MessageBox.Show("Usuário criado com sucesso!");

                this.Close();
                formCadastroPersonagem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao tentar criar, {ex.Message}",
                    "ERRO!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        private void aoClicarEmCadastrar(object sender, EventArgs e)
        {
            cadastrarNovoUsuario();
        }

        private void aoClicarEmCancelar(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show(
                "Deseja mesmo sair? Os dados preenchidos serão apagados",
                "Atenção!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );
            if (dialogo == DialogResult.OK)
            {
                this.Close();
                var formCadastroPersonagem = new FormCadastroPersonagem(_servicoPersonagem, _servicoUsuario);
                formCadastroPersonagem.Show();
            }
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private int ConverterParaInt(string text) => string.IsNullOrEmpty(text) ? (int)default : Convert.ToInt32(text);
    }
}
