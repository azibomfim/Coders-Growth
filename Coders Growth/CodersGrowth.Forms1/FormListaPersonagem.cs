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

        public FormListaPersonagem(ServicoPersonagem servicoPersonagem)
        {
            FiltroPersonagem filtroInicial = null;
            _servicoPersonagem = servicoPersonagem;
            InitializeComponent();
            dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(filtroInicial);
        }

        private void FormListaPersonagem_Load(object sender, EventArgs e)
        {
            comboBoxArma.DataSource = Enum.GetValues(typeof(ArmaEnum));

            comboBoxElemento.DataSource = Enum.GetValues(typeof(ElementoEnum));

            comboBoxNome.DataSource = Enum.GetValues(typeof(NomeEnum));
        }

        private FiltroPersonagem? obterFiltroPersonagem()
        {
            var filtroPersonagem = new FiltroPersonagem();
            const int zero = 0;


            if (comboBoxArma.SelectedItem != null && comboBoxArma.SelectedIndex != zero)
                filtroPersonagem.Arma = (ArmaEnum)comboBoxArma.SelectedItem;

            if (comboBoxElemento.SelectedItem != null && comboBoxElemento.SelectedIndex != zero)
                filtroPersonagem.Elemento = (ElementoEnum)comboBoxElemento.SelectedItem;

            if (comboBoxNome.SelectedItem != null && comboBoxNome.SelectedIndex != zero)
                filtroPersonagem.NomePersonagem = (NomeEnum?)comboBoxNome.SelectedValue;

            if (checkBoxBool.Checked)
                filtroPersonagem.CriadoPorUsuario = true;

            if (dateTimePickerFiltro.Checked) 
                filtroPersonagem.DataDeAquisicao = (DateTime)dateTimePickerFiltro.Value;
            return filtroPersonagem;
        }

        private void aoClicarEmFiltrar(object sender, EventArgs e)
        {
            var filtrosAtivados = obterFiltroPersonagem();
            dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(filtrosAtivados);
        }

        private void textboxTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


