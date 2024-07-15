using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;

namespace CodersGrowth.Forms1
{
    public partial class FormCadastroPersonagem : Form
    {
        private FiltroUsuario? filtroUsuario = new FiltroUsuario();
        private ServicoPersonagem _servicoPersonagem;
        private ServicoUsuario _servicoUsuario;
        public Personagem personagemNovo = new();
        public FormCadastroPersonagem(ServicoPersonagem servicoPersonagem, ServicoUsuario servicoUsuario)
        {
            _servicoPersonagem = servicoPersonagem;
            _servicoUsuario = servicoUsuario;
            InitializeComponent();
        }

        private void aoCarregarTelaDeCadastro(object sender, EventArgs e)
        {
            carregarEnumsNaComboBox();
            textBoxNomeU.Text = personagemNovo.NomeUsuario;
        }

        private void carregarEnumsNaComboBox()
        {
            comboBoxArma.DataSource = Enum.GetValues(typeof(ArmaEnum));
            comboBoxElemento.DataSource = Enum.GetValues(typeof(ElementoEnum));
            comboBoxNome.DataSource = Enum.GetValues(typeof(NomeEnum));
        }

        private void aoClicarEmCadastrarUsuario(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var formCadastroUsuario = new FormsCadastroUsuario(_servicoPersonagem, _servicoUsuario);
            formCadastroUsuario.Show();
        }
       
        private void cadastrarNovoPersonagem()
        {
            try
            {
                var usuarioCriador = new Usuario();

                var ataque = ConverterParaInt(textBoxAtq.Text);
                var defesa = ConverterParaInt(textBoxDef.Text);
                var vida = ConverterParaInt(textBoxHP.Text);
                var proficiencia = ConverterParaInt(textBoxPE.Text);
                var constelacao = ConverterParaInt(textBoxConst.Text);
                var taxa = ConverterParaDecimal(textBoxTC.Text);
                var dano = ConverterParaDecimal(textBoxDC.Text);
                var cura = ConverterParaDecimal(textBoxCura.Text);
                var elemental = ConverterParaDecimal(textBoxBE.Text);
                var recarga = ConverterParaDecimal(textBoxRE.Text);
                var escudo = ConverterParaDecimal(textBoxShield.Text);

                personagemNovo.NomePersonagem = (NomeEnum)comboBoxNome.SelectedItem;
                personagemNovo.Elemento = (ElementoEnum)comboBoxElemento.SelectedItem;
                personagemNovo.Arma = (ArmaEnum)comboBoxArma.SelectedItem;
                personagemNovo.Ataque = ataque;
                personagemNovo.Vida = vida;
                personagemNovo.Defesa = defesa;
                personagemNovo.ProficienciaElemental = proficiencia;
                personagemNovo.DanoCrit = dano;
                personagemNovo.TaxaCrit = taxa;
                personagemNovo.BonusCura = cura;
                personagemNovo.BonusElemental = elemental;
                personagemNovo.ConstelacaoLv = constelacao;
                personagemNovo.RecargaDeEnergia = recarga;
                personagemNovo.Escudo = escudo;
                personagemNovo.CriadoPorUsuario = true;
                personagemNovo.DataDeAquisicao = dateTimePicker.Value;
                personagemNovo.NomeUsuario = textBoxNomeU.Text;

                filtroUsuario.NomeDeUsuario = personagemNovo.NomeUsuario;
                usuarioCriador = _servicoUsuario.ObterTodos(filtroUsuario).FirstOrDefault();

                if (usuarioCriador != null)
                    personagemNovo.IdUsuario = usuarioCriador.Id;

                _servicoPersonagem.Criar(personagemNovo);

                MessageBox.Show("Personagem criado com sucesso!");

                this.Close();
                var formLista = new FormListaPersonagem(_servicoPersonagem, _servicoUsuario);
                formLista.Show();
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

        private void aoClicarEmSalvar(object sender, EventArgs e)
        {
            cadastrarNovoPersonagem();
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
                var formLista = new FormListaPersonagem(_servicoPersonagem, _servicoUsuario);
                formLista.Show();
            }
        }

        private void aoDigitarValorInvalidoEmConstelacao(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmVida(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmAtaque(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmDefesa(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmProficiencia(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmRecarga(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmDanoCritico(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmTaxaCritica(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmBonusCura(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmEscudo(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmBonusElemental(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresNaoNumericos(sender, e);
        }

        private void aoDigitarValorInvalidoEmNomeUsuario(object sender, KeyPressEventArgs e)
        {
            validarEntradaDeValoresQueNaoSaoLetras(sender, e);
        }

        private int ConverterParaInt(string text) => string.IsNullOrEmpty(text) ? (int)default : Convert.ToInt32(text);
        
        private decimal ConverterParaDecimal(string text) => string.IsNullOrEmpty(text) ? (decimal)default : Convert.ToDecimal(text);
        
        private void validarEntradaDeValoresNaoNumericos(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
       
        private void validarEntradaDeValoresQueNaoSaoLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
