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
            _servicoPersonagem = servicoPersonagem;

            InitializeComponent();
            dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(null);
        }

        private void FormListaPersonagem_Load(object sender, EventArgs e)
        {
            comboBoxArma.Items.Add(ArmaEnum.Arco);
            comboBoxArma.Items.Add(ArmaEnum.Catalisador);
            comboBoxArma.Items.Add(ArmaEnum.Espada);
            comboBoxArma.Items.Add(ArmaEnum.Espadao);
            comboBoxArma.Items.Add(ArmaEnum.Lanca);

            comboBoxElemento.Items.Add(ElementoEnum.Anemo);
            comboBoxElemento.Items.Add(ElementoEnum.Cryo);
            comboBoxElemento.Items.Add(ElementoEnum.Dendro);
            comboBoxElemento.Items.Add(ElementoEnum.Electro);
            comboBoxElemento.Items.Add(ElementoEnum.Geo);
            comboBoxElemento.Items.Add(ElementoEnum.Hydro);
            comboBoxElemento.Items.Add(ElementoEnum.Pyro);

            comboBoxNome.DataSource = Enum.GetValues(typeof(NomeEnum));
        }

        private FiltroPersonagem? obterFiltroPersonagem()
        {
            var filtroPersonagem = new FiltroPersonagem();

            if (comboBoxArma.SelectedItem != null)
                filtroPersonagem.Arma = (ArmaEnum)comboBoxArma.SelectedItem;

            if (comboBoxElemento.SelectedItem != null)
                filtroPersonagem.Elemento = (ElementoEnum)comboBoxElemento.SelectedItem;

            if (comboBoxNome.SelectedItem != null)
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


