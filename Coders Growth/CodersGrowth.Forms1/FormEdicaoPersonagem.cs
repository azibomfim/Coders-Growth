using CodersGrowth.Dominio.Enums;
using CodersGrowth.Dominio.Filtros;
using CodersGrowth.Dominio.Models;
using CodersGrowth.Servicos.Servicos;

namespace CodersGrowth.Forms1
{
    public partial class FormEdicaoPersonagem : Form
    {
        private FiltroUsuario? filtroUsuario = new FiltroUsuario();
        private ServicoPersonagem _servicoPersonagem;
        private ServicoUsuario _servicoUsuario;
        public Personagem personagemEditavel = new();
        public FormEdicaoPersonagem(ServicoPersonagem servicoPersonagem, ServicoUsuario servicoUsuario, int idPersonagem)
        {
            _servicoPersonagem = servicoPersonagem;
            _servicoUsuario = servicoUsuario;
            personagemEditavel = _servicoPersonagem.ObterPorId(idPersonagem);
            InitializeComponent();
        }

        private void aoCarregarTelaDeEdicao(object sender, EventArgs e)
        {
            carregarEnumsNaComboBox();
            carregarDadosParaEdicao();
        }

        private void carregarDadosParaEdicao()
        {
            textBoxAtq.Text = Convert.ToString(personagemEditavel.Ataque);
            textBoxHP.Text = Convert.ToString(personagemEditavel.Vida);
            textBoxDef.Text = Convert.ToString(personagemEditavel.Defesa);
            textBoxPE.Text = Convert.ToString(personagemEditavel.ProficienciaElemental);
            textBoxDC.Text = Convert.ToString(personagemEditavel.DanoCrit);
            textBoxTC.Text = Convert.ToString(personagemEditavel.TaxaCrit);
            textBoxCura.Text = Convert.ToString(personagemEditavel.BonusCura);
            textBoxBE.Text = Convert.ToString(personagemEditavel.BonusElemental);
            textBoxConst.Text = Convert.ToString(personagemEditavel.ConstelacaoLv);
            textBoxRE.Text = Convert.ToString(personagemEditavel.RecargaDeEnergia);
            textBoxShield.Text = Convert.ToString(personagemEditavel.Escudo);
            comboBoxArma.SelectedItem = personagemEditavel.Arma;
            personagemEditavel.CriadoPorUsuario = true;
            dateTimePicker.Value = (DateTime)personagemEditavel.DataDeAquisicao;
            comboBoxElemento.SelectedItem = personagemEditavel.Elemento;
            comboBoxNome.SelectedItem = personagemEditavel.NomePersonagem;
            textBoxNomeU.Text = personagemEditavel.NomeUsuario;
        }

        private void carregarEnumsNaComboBox()
        {
            comboBoxArma.DataSource = Enum.GetValues(typeof(ArmaEnum));
            comboBoxElemento.DataSource = Enum.GetValues(typeof(ElementoEnum));
            comboBoxNome.DataSource = Enum.GetValues(typeof(NomeEnum));
        }
        private void editarPersonagem()
        {
            try
            {
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


                personagemEditavel.NomePersonagem = (NomeEnum)comboBoxNome.SelectedItem;
                personagemEditavel.Elemento = (ElementoEnum)comboBoxElemento.SelectedItem;
                personagemEditavel.Arma = (ArmaEnum)comboBoxArma.SelectedItem;
                personagemEditavel.Ataque = ataque;
                personagemEditavel.Vida = vida;
                personagemEditavel.Defesa = defesa;
                personagemEditavel.ProficienciaElemental = proficiencia;
                personagemEditavel.DanoCrit = dano;
                personagemEditavel.TaxaCrit = taxa;
                personagemEditavel.BonusCura = cura;
                personagemEditavel.BonusElemental = elemental;
                personagemEditavel.ConstelacaoLv = constelacao;
                personagemEditavel.RecargaDeEnergia = recarga;
                personagemEditavel.Escudo = escudo;
                personagemEditavel.DataDeAquisicao = dateTimePicker.Value.Date;

                _servicoPersonagem.Editar(personagemEditavel);

                MessageBox.Show("Personagem editado com sucesso!");

                this.Close();
                var formLista = new FormListaPersonagem(_servicoPersonagem, _servicoUsuario);
                formLista.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao tentar editar, {ex.Message}",
                    "ERRO!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void aoClicarEmSalvar(object sender, EventArgs e)
        {
            editarPersonagem();
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

        private int ConverterParaInt(string text) => string.IsNullOrEmpty(text) ? (int)default : Convert.ToInt32(text);
        
        private decimal ConverterParaDecimal(string text) => string.IsNullOrEmpty(text) ? (decimal)default : Convert.ToDecimal(text);
        
        private void validarEntradaDeValoresNaoNumericos(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
