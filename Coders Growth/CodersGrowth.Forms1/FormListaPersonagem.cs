using CodersGrowth.Servicos.Servicos;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Filtros;

namespace CodersGrowth.Forms1
{
    public partial class FormListaPersonagem : Form
    {
        private readonly ServicoPersonagem _servicoPersonagem;
        private FiltroPersonagem? filtroPersonagem = new FiltroPersonagem();
        private Personagem personagem;
        private ServicoUsuario _servicoUsuario;

        public FormListaPersonagem(ServicoPersonagem servicoPersonagem, ServicoUsuario servicoUsuario)
        {
            FiltroPersonagem filtroInicial = null;
            _servicoPersonagem = servicoPersonagem;
            _servicoUsuario = servicoUsuario;
            InitializeComponent();
            dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(filtroInicial);
        }

        private void aoCarregarTela(object sender, EventArgs e)
        {
            carregarEnumsNaComboBox();
        }

        private void carregarEnumsNaComboBox()
        {
            comboBoxArma.DataSource = Enum.GetValues(typeof(ArmaEnum));
            comboBoxElemento.DataSource = Enum.GetValues(typeof(ElementoEnum));
            comboBoxNome.DataSource = Enum.GetValues(typeof(NomeEnum));
        }

        private FiltroPersonagem? obterFiltroPersonagem()
        {
            var filtroPersonagem = new FiltroPersonagem();
            const int idUsuario = 0;

            if (comboBoxArma.SelectedItem != null && comboBoxArma.SelectedIndex != idUsuario)
                filtroPersonagem.Arma = (ArmaEnum)comboBoxArma.SelectedItem;

            if (comboBoxElemento.SelectedItem != null && comboBoxElemento.SelectedIndex != idUsuario)
                filtroPersonagem.Elemento = (ElementoEnum)comboBoxElemento.SelectedItem;

            if (comboBoxNome.SelectedItem != null && comboBoxNome.SelectedIndex != idUsuario)
                filtroPersonagem.NomePersonagem = (NomeEnum?)comboBoxNome.SelectedValue;

            if (checkBoxBool.Checked)
                filtroPersonagem.CriadoPorUsuario = true;

            if (dateTimePickerFiltro.Checked)
                filtroPersonagem.DataDeAquisicao = (DateTime)dateTimePickerFiltro.Value;

            if (textBoxFiltroUsuario.Text != "Nome de usuário" && textBoxFiltroUsuario.Text != null)
                filtroPersonagem.NomeUsuario = textBoxFiltroUsuario.Text;

            return filtroPersonagem;
        }

        private void aoClicarEmFiltrar(object sender, EventArgs e)
        {
            var filtrosAtivados = obterFiltroPersonagem();
            dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(filtrosAtivados);
        }

        private void aoClicarEmCriar(object sender, EventArgs e)
        {
            var formCadastroPersonagem = new FormCadastroPersonagem(_servicoPersonagem, _servicoUsuario);
            formCadastroPersonagem.Show();
            this.Hide();
        }

        private void aoClicarEmLimpar(object sender, EventArgs e)
        {
            FiltroPersonagem filtroInicial = null;
            dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(filtroInicial);
        }
    }
}


