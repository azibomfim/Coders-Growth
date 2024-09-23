sap.ui.define([
    "sap/base/Log",
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
    "sap/ui/core/format/DateFormat",
    "sap/ui/thirdparty/jquery",
    "sap/ui/core/date/UI5Date",
    "sap/m/MessageBox",
    "genshin/app/model/formatter",
    "genshin/app/model/Repositorio",
    "genshin/app/model/Validator",
    "sap/ui/core/ValueState",
    "sap/m/library",
    "sap/ui/core/library",
     "sap/m/Text",
     "sap/m/Dialog",
    "sap/m/Button"
], function (Log, BaseController, JSONModel, MessageToast, DateFormat, jQuery, UI5Date, MessageBox, formatter, Repositorio, Validator, ValueState, mobileLibrary, coreLibrary, Text,Dialog, Button) {
    "use strict";

    const  URL_API = "https://localhost:7085/api/Personagem";
    const NOME_DO_MODELO = "Personagem";
    const INPUT_NOME = "inputNome";
    const INPUT_ELEMENTO = "inputElemento";
    const INPUT_ARMA = "inputArma";
    const INPUT_DATA = "inputData";
    const INPUT_CONSTELACAO = "inputConstelacao";
    const INPUT_USUARIO = "inputNomeUsuario";
    const INPUT_BONUS = "inputBonusElemental";
    const INPUT_CURA = "inputCura";
    const INPUT_ESCUDO = "inputEscudo";
    const INPUT_DANO = "inputDanoCrit";
    const INPUT_TAXA = "inputTaxaCrit";
    const INPUT_VIDA = "inputVida";
    const INPUT_ATAQUE = "inputAtaque";
    const INPUT_DEFESA = "inputDefesa";
    const INPUT_PROFICIENCIA = "inputProficiencia";
    const INPUT_RECARGA = "inputRecarga";
    const REQUISICAO_POST = "POST";
    const REQUISICAO_PATCH = "PATCH"
    const NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM = "PersonagemRequisicao";
    const i18n = "i18n";
    const valueStateDeErro = "Error";
    const valueStateCerto = "None";
    const ValidacaoNomeMsg = "Validacao.Nome";
    const ValidacaoUsuarioMsg = "Validacao.Usuario";
    const ValidacaoArmaMsg = "Validacao.Arma";
    const ValidacaoElementoMsg = "Validacao.Elemento";
    const ValidacaoDataMsg = "Validacao.Data";
    const ValidacaoConstelacaoLvMsg = "Validacao.ConstelacaoLv";
    const ValidacaoBonusElementalMsg = "Validacao.BonusElemental";
    const ValidacaoRecargaDeEnergiaMsg = "Validacao.RecargaDeEnergia";
    const ValidacaoEscudoMsg = "Validacao.Escudo";
    const ValidacaoBonusCuraMsg = "Validacao.BonusCura";
    const ValidacaoTaxaCritMsg = "Validacao.TaxaCrit";
    const ValidacaoDanoCritMsg = "Validacao.DanoCrit";
    const ValidacaoVidaMsg = "Validacao.Vida";
    const ValidacaoAtaqueMsg = "Validacao.Ataque";
    const ValidacaoDefesaMsg = "Validacao.Defesa";
    const ValidacaoProficienciaElementalMsg = "Validacao.ProficienciaElemental";
    const QUEBRA_DE_LINHA = "\n";
    const ID_DETALHES = "detalhesPersonagem";
    const modelo_i18n = "modeloTitulo";
    const rotaCadastro = "cadastroPersonagem";
    const rotaEdicao = "edicaoPersonagem";
    const erroTitulo = "CadastroErro.Titulo"
    const sucessoTitulo = "CadastroSucesso.Titulo";
    const sucessoMsg = "CadastroSucesso.Mensagem";

    return BaseController.extend("genshin.app.personagem.CadastroPersonagem", {
        formatter: formatter,
        idPersonagem: null,
        mensagensDeErro: null,

        onInit: function () {
            this.getRouter().getRoute(rotaCadastro).attachPatternMatched(async () => {
                return this.aoCoincidirRotaCriar();
            }, this);
            this.getRouter().getRoute(rotaEdicao).attachPatternMatched(async (evento) => {
                return this.aoCoincidirRotaEditar(evento);
            }, this);
        },

        aoCoincidirRotaCriar: function() {
            let view = this.getView();
            this.processarAcao(async () => {
                await Promise.all([
                    Repositorio.carregarDadosPersonagem("", view),
                    Repositorio.obterEnumNome(view),
                    Repositorio.obterEnumArma(view),
                    Repositorio.obterEnumElemento(view),
                    this.preencheri18nCerto()
                ])
            })
        },

        aoCoincidirRotaEditar: function(evento) {
            this.idPersonagem = evento.getParameters().arguments.id;
            let view = this.getView();
            this.processarAcao(async () => {
                await Promise.all([
                    Repositorio.obterPorId(view, this.idPersonagem, NOME_DO_MODELO, NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM),
                    Repositorio.obterEnumNome(view),
                    Repositorio.obterEnumArma(view),
                    Repositorio.obterEnumElemento(view),
                    this.preencheri18nCerto()
                ])
            })
        },

        retornarNavegacao: function(){
            const rota = "listaPersonagem";
            this.limparCamposEValueState();
            return this.navegarPara(rota);
        },

        preencheri18nCerto: function(){
            let titulo;
            const tituloCadastro = "Cadastro.Titulo";
            const tituloEdicao = "Edicao.Titulo"
            this.idPersonagem
                ?titulo = tituloEdicao
                :titulo = tituloCadastro
            let modeloTitulo = new JSONModel({
                Title: titulo
            })
            this.getView().setModel(modeloTitulo, modelo_i18n);
        },
         
        obterDadosPersonagem: function(){
            const usuarioId = 5;

            let nome = this.getView().byId(INPUT_NOME).getSelectedKey();
            let arma = this.getView().byId(INPUT_ARMA).getSelectedKey();
            let elemento = this.getView().byId(INPUT_ELEMENTO).getSelectedKey();
            let inputUsuario = this.getView().byId(INPUT_USUARIO);
            let data = this.getView().byId(INPUT_DATA).getDateValue();
            let constelacao = this.getView().byId(INPUT_CONSTELACAO).getValue();
            let bonusElemental = this.getView().byId(INPUT_BONUS).getValue();
            let cura = this.getView().byId(INPUT_CURA).getValue();
            let escudo = this.getView().byId(INPUT_ESCUDO).getValue();
            let danoCrit = this.getView().byId(INPUT_DANO).getValue();
            let taxaCrit = this.getView().byId(INPUT_TAXA).getValue();
            let vida = this.getView().byId(INPUT_VIDA).getValue();
            let ataque = this.getView().byId(INPUT_ATAQUE).getValue();
            let defesa = this.getView().byId(INPUT_DEFESA).getValue();
            let proficiencia = this.getView().byId(INPUT_PROFICIENCIA).getValue();
            let recarga = this.getView().byId(INPUT_RECARGA).getValue();
            let nomeUsuario = inputUsuario.getValue();
            let idUsuario = usuarioId;
    
            let modeloPersonagem = new JSONModel( {
                id: this.idPersonagem,
                nomePersonagem: parseInt(nome),
                vida: vida,
                ataque: ataque,
                defesa: defesa,
                proficienciaElemental: proficiencia,
                taxaCrit: taxaCrit,
                danoCrit: danoCrit,
                bonusCura: cura,
                recargaDeEnergia: recarga,
                escudo: escudo,
                bonusElemental: bonusElemental,
                criadoPorUsuario: true,
                constelacaoLv: constelacao,
                dataDeAquisicao: data,
                elemento: parseInt(elemento),
                arma: parseInt(arma),
                idUsuario: idUsuario,
                nomeUsuario: nomeUsuario
            })

            this.getView().setModel(modeloPersonagem, NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM);
        },

        aoClicarEmSalvar: function(){
            if(!this.idPersonagem){
                this.aoClicarEmSalvarCriar();
            }
            else{
                this.aoClicarEmSalvarEditar();
            }
        },

        aoClicarEmSalvarCriar: async function(){
            this.obterDadosPersonagem();
            let dadosPersonagem = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData();
            let personagemString = JSON.stringify(dadosPersonagem);

            const tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(erroTitulo);
            const estadoDoDialogoDeErro = ValueState.Error;
                    
            if (this.validarPersonagem()){
                let resposta = await Repositorio.requistarApi(URL_API, personagemString, REQUISICAO_POST);
                this.id = resposta?.id
                    if (resposta.id) {
                        const tituloCaixaDeDialogoDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(sucessoTitulo);
                        const estadoDoDialogoDeSucesso = ValueState.Success;
                        const mensagemDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(sucessoMsg);
                        this.abrirDialogo(tituloCaixaDeDialogoDeSucesso, mensagemDeSucesso, estadoDoDialogoDeSucesso);
                    } 
                    else {
                        let mensagemDeErro = {
                            title: resposta.Title,
                            status: resposta.Status,
                            type: resposta.Type,
                            details: resposta.Detail
                        };

                        let mensagemFormatada =
                            "Título: " + mensagemDeErro.title + QUEBRA_DE_LINHA +
                            "Status: " + mensagemDeErro.status + QUEBRA_DE_LINHA +
                            "Tipo: " + mensagemDeErro.type + QUEBRA_DE_LINHA +
                            "Detalhes: " + mensagemDeErro.details;

                        this.abrirDialogo(tituloCaixaDeDialogoDeErro, mensagemFormatada, estadoDoDialogoDeErro);

                        this.getView().byId(INPUT_USUARIO).setValueState(valueStateDeErro);
                    }
            }
        },

        aoClicarEmSalvarEditar: async function(){
            this.obterDadosPersonagem();
            let dadosPersonagem = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData();
            let personagemString = JSON.stringify(dadosPersonagem);

            const tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(erroTitulo);
            const estadoDoDialogoDeErro = ValueState.Error;
                    
            if (this.validarPersonagem()){
                let resposta = await Repositorio.requistarApi(URL_API, personagemString, REQUISICAO_PATCH);
                    if (resposta.ok) {
                        const tituloCaixaDeDialogoDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(sucessoTitulo);
                        const estadoDoDialogoDeSucesso = ValueState.Success;
                        const mensagemDeSucesso = this.getView().getModel(i18n).getResourceBundle().getText(sucessoMsg);
                        this.abrirDialogo(tituloCaixaDeDialogoDeSucesso, mensagemDeSucesso, estadoDoDialogoDeSucesso);
                    } 
                    else {
                        let mensagemDeErro = {
                            title: resposta.Title,
                            status: resposta.Status,
                            type: resposta.Type,
                            details: resposta.Detail
                        };

                        let mensagemFormatada =
                            "Título: " + mensagemDeErro.title + QUEBRA_DE_LINHA +
                            "Status: " + mensagemDeErro.status + QUEBRA_DE_LINHA +
                            "Tipo: " + mensagemDeErro.type + QUEBRA_DE_LINHA +
                            "Detalhes: " + mensagemDeErro.details;

                        this.abrirDialogo(tituloCaixaDeDialogoDeErro, mensagemFormatada, estadoDoDialogoDeErro);

                        this.getView().byId(INPUT_USUARIO).setValueState(valueStateDeErro);
                    }
            }
        },

        abrirDialogo: function (tituloCaixaDeDialogo, mensagem, estadoDoDialogo) {
            const okBotao = "OK"
            var ButtonType = mobileLibrary.ButtonType;
            var DialogType = mobileLibrary.DialogType;

            let botao;

            if (estadoDoDialogo === ValueState.Error) {
                botao = new Button({
                    type: ButtonType.Emphasized,
                    text: okBotao,
                    press: function () {
                        this.oErrorMessageDialog.close();
                    }.bind(this)
                })
            } else {
                botao = new Button({
                    type: ButtonType.Emphasized,
                    text: okBotao,
                    press: function () {
                        this.aofecharAbreTelaDeDetalhes();
                    }.bind(this)
                });
            }

            this.oErrorMessageDialog = new Dialog({
                type: DialogType.Message,
                title: tituloCaixaDeDialogo,
                state: estadoDoDialogo,
                content: new Text({ text: mensagem }),
                beginButton: botao
            });

            this.oErrorMessageDialog.open();
        },

        aofecharAbreTelaDeDetalhes: function () {
            if(this.idPersonagem){
                return this.navegarPara(ID_DETALHES, this.idPersonagem);
            }
            else{
                return this.navegarPara(ID_DETALHES, this.id);
            }
    },

        limparCamposEValueState: function(){
                this.obterDadosPersonagem();
                this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).setData({});           
                this.getView().byId(INPUT_NOME).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_ARMA).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_ELEMENTO).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_USUARIO).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_DATA).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_CONSTELACAO).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_BONUS).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_CURA).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_ESCUDO).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_DANO).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_TAXA).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_VIDA).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_ATAQUE).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_DEFESA).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_PROFICIENCIA).setValueState(valueStateCerto).setValue();
                this.getView().byId(INPUT_RECARGA).setValueState(valueStateCerto).setValue();
        },

        aplicarValidacao: function (validacao, idInput, idI18n) {
            if (!validacao) {
                this.getView().byId(idInput).setValueState(valueStateDeErro);
                this.mensagensDeErro += this.getView().getModel(i18n).getResourceBundle().getText(idI18n) + QUEBRA_DE_LINHA;
                return false;
            } else {
                this.getView().byId(idInput).setValueState();
                return true;
            }
        },

        validarPersonagem: function () {
            this.mensagensDeErro = ""

            let nomePersonagem = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().nomePersonagem;
            let nomePersonagemNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(nomePersonagem), INPUT_NOME, ValidacaoNomeMsg);

            let elemento = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().elemento;
            let elementoNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(elemento), INPUT_ELEMENTO, ValidacaoElementoMsg);

            let arma = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().arma;
            let armaNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(arma), INPUT_ARMA, ValidacaoArmaMsg);

            let dataDeAquisicao = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().dataDeAquisicao;
            let dataDeAquisicaoNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(dataDeAquisicao), INPUT_DATA, ValidacaoDataMsg);

            let nomeUsuario = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().nomeUsuario;
            let nomeUsuarioNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(nomeUsuario), INPUT_USUARIO, ValidacaoUsuarioMsg);
            
            let vida = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().vida;
            let vidaNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(vida), INPUT_VIDA, ValidacaoVidaMsg);

            let ataque = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().ataque;
            let ataqueNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(ataque), INPUT_ATAQUE, ValidacaoAtaqueMsg);

            let defesa = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().defesa;
            let defesaNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(defesa), INPUT_DEFESA, ValidacaoDefesaMsg);

            let proficienciaElemental = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().proficienciaElemental;
            let proficienciaElementalNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(proficienciaElemental), INPUT_PROFICIENCIA, ValidacaoProficienciaElementalMsg);

            let taxaCrit = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().taxaCrit;
            let taxaCritNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(taxaCrit), INPUT_TAXA, ValidacaoTaxaCritMsg);
            
            let danoCrit = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().danoCrit;
            let danoCritNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(danoCrit), INPUT_DANO, ValidacaoDanoCritMsg);

            let bonusCura = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().bonusCura;
            let bonusCuraNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(bonusCura), INPUT_CURA, ValidacaoBonusCuraMsg);

            let recargaDeEnergia = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().recargaDeEnergia;
            let recargaDeEnergiaNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(recargaDeEnergia), INPUT_RECARGA, ValidacaoRecargaDeEnergiaMsg);

            let escudo = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().escudo;
            let escudoNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(escudo), INPUT_ESCUDO, ValidacaoEscudoMsg);

            let bonusElemental = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().bonusElemental;
            let bonusElementalNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(bonusElemental), INPUT_BONUS, ValidacaoBonusElementalMsg);

            let constelacaoLv = this.getView().getModel(NOME_DO_MODELO_DE_REQUISICAO_PERSONAGEM).getData().constelacaoLv;
            let constelacaoLvNaoENulo = this.aplicarValidacao(Validator.validarSeCampoPossuiValor(constelacaoLv), INPUT_CONSTELACAO, ValidacaoConstelacaoLvMsg);


            if (this.mensagensDeErro) {
                let tituloCaixaDeDialogoDeErro = this.getView().getModel(i18n).getResourceBundle().getText(erroTitulo);
                let estadoDoDialogoDeErro = ValueState.Error;
                this.abrirDialogo(tituloCaixaDeDialogoDeErro, this.mensagensDeErro, estadoDoDialogoDeErro);
            }
            return nomePersonagemNaoENulo && elementoNaoENulo
            && armaNaoENulo && dataDeAquisicaoNaoENulo
            && nomeUsuarioNaoENulo&&constelacaoLvNaoENulo
            &&ataqueNaoENulo&&vidaNaoENulo
            &&defesaNaoENulo&&escudoNaoENulo
            &&bonusCuraNaoENulo&&bonusElementalNaoENulo
            &&proficienciaElementalNaoENulo&&recargaDeEnergiaNaoENulo
            &&taxaCritNaoENulo&&danoCritNaoENulo;
        }
    }
)})