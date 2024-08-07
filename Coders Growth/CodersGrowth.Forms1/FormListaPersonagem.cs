using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;
using LinqToDB.Common;

namespace CodersGrowth.Forms1
{
    public partial class FormListaPersonagem : Form
    {
        private readonly ServicoPersonagem _servicoPersonagem;
        private FiltroPersonagem? filtroPersonagem = new FiltroPersonagem();
        private ServicoUsuario _servicoUsuario;
        public Personagem _personagemEditavel;
        private FiltroPersonagem filtroInicial = null;

        public FormListaPersonagem(ServicoPersonagem servicoPersonagem, ServicoUsuario servicoUsuario)
        {
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
            const int enumNeutro = 0;
            const string textoInicial = "Nome de usu�rio";

            if (comboBoxArma.SelectedItem != null && comboBoxArma.SelectedIndex != enumNeutro)
                filtroPersonagem.Arma = (ArmaEnum)comboBoxArma.SelectedItem;

            if (comboBoxElemento.SelectedItem != null && comboBoxElemento.SelectedIndex != enumNeutro)
                filtroPersonagem.Elemento = (ElementoEnum)comboBoxElemento.SelectedItem;

            if (comboBoxNome.SelectedItem != null && comboBoxNome.SelectedIndex != enumNeutro)
                filtroPersonagem.NomePersonagem = (NomeEnum?)comboBoxNome.SelectedValue;

            if (checkBoxBool.Checked)
                filtroPersonagem.CriadoPorUsuario = true;

            if (dateTimePickerFiltro.Checked)
                filtroPersonagem.DataDeAquisicao = (DateTime)dateTimePickerFiltro.Value.Date;

            if (textBoxFiltroUsuario.Text != textoInicial && textBoxFiltroUsuario.Text != null)
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
            dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(filtroInicial);
        }

        private void aoClicarEmRemoverPersonagem(object sender, EventArgs e)
        {
            try
            {
                var resultado = dataGridViewPersonagem.SelectedRows.IsNullOrEmpty()
                    ? MessageBox.Show(
                        $"Nenhum Personagem selecionado!",
                        "ERRO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                    : MessageBox.Show(
                        $"Deseja mesmo deletar o Personagem selecionado?",
                        "Confirma��o",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (resultado is DialogResult.Yes)
                {
                    var personagem = obterPersonagemSelecionado();
                    _servicoPersonagem.Remover(personagem.Id);
                    dataGridViewPersonagem.DataSource = _servicoPersonagem.ObterTodos(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o Personagem!!");
            }
        }

        private Personagem obterPersonagemSelecionado()
        {
            var index = dataGridViewPersonagem.CurrentRow.Index;

            DataGridViewRow linha = dataGridViewPersonagem.Rows[index];
            int idPersonagem = (int)linha.Cells[idColumn.Index].Value;
            return _servicoPersonagem.ObterPorId(idPersonagem);
        }

        private void aoClicarEmEditar(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPersonagem.SelectedRows.IsNullOrEmpty())
                {
                    MessageBox.Show(
                           $"Nenhum Personagem selecionado!",
                           "ERRO",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
                else
                {
                    var personagem = obterPersonagemSelecionado();
                    var idPersonagem = personagem.Id;

                    if ((bool)!personagem.CriadoPorUsuario)
                    {
                        MessageBox.Show(
                           $"Apenas Personagens criados por usu�rio podem ser editados!",
                           "ERRO",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                    else
                    {
                        var formEdicaoPersonagem = new FormEdicaoPersonagem(_servicoPersonagem, _servicoUsuario, idPersonagem);
                        formEdicaoPersonagem.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o Personagem!!");
            }
        }

        private void formatacaoDeValores(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPersonagem.Columns[e.ColumnIndex] == criadoPorUsuarioColumn)
            {
                if (e.Value is bool)
                {
                    var valor = (bool)e.Value;
                    e.Value = valor ? "Sim" : "N�o";
                    e.FormattingApplied = true;
                }
            }
            if (e.Value is decimal)
            {
                var valor = (decimal)e.Value;
                e.Value = valor.ToString("F2");
                e.FormattingApplied = true;
            }
        }
    }
}


