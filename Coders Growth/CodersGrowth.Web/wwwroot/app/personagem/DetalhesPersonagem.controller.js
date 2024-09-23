sap.ui.define([
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "genshin/app/model/Repositorio",
    "genshin/app/model/formatter",
    "sap/m/MessageToast",
    "sap/m/MessageBox",
    "sap/ui/core/ValueState",
    "sap/ui/core/library",
    "sap/m/Dialog",
    "sap/m/Button",
    "sap/m/library",
    "sap/m/Text"
], function (BaseController, JSONModel, Repositorio, formatter, MessageToast, MessageBox, ValueState, coreLibrary, Dialog, Button, mobileLibrary, Text) {
    "use strict";

    const CONTROLLER = "genshin.app.personagem.DetalhesPersonagem";
    const ID_DETALHES = "detalhesPersonagem";
    const NOME_DO_MODELO_DE_PERSONAGEM_SELECIONADO = "PersonagemSelecionado";
    const MODELO_DE_REQUISICAO = "Personagem";
    let idPersonagem;
    const i18n = "i18n"
    const erroTitulo = "CadastroErro.Titulo"
    const sucessoTitulo = "CadastroSucesso.Titulo"
    const sucessoMsg = "RemocaoSucesso.Mensagem"
    const QUEBRA_DE_LINHA = "\n"

    return BaseController.extend(CONTROLLER, {
        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute(ID_DETALHES).attachPatternMatched(async (evento) => {
                return this.aoCoincidirRota(evento);
            }, this)
        },

        aoCoincidirRota: function(evento) {
            idPersonagem = evento.getParameters().arguments.id;
            let view = this.getView();
            this.processarAcao(async () => {
                await Promise.all([
                    Repositorio.obterPorId(view, idPersonagem, MODELO_DE_REQUISICAO, NOME_DO_MODELO_DE_PERSONAGEM_SELECIONADO),
                    Repositorio.obterEnumNome(view),
                    Repositorio.obterEnumArma(view),
                    Repositorio.obterEnumElemento(view)
                ])
            })
        },

        retornarNavegacao: function(){
            const rota = "listaPersonagem";
            return this.navegarPara(rota);
        },

        aoPressionarEditar: function () {
            const rotaTelaDeEdicao = "edicaoPersonagem";
            let PersonagemEdicao = this.getView().getModel(NOME_DO_MODELO_DE_PERSONAGEM_SELECIONADO).getData().id;
            return this.navegarPara(rotaTelaDeEdicao, PersonagemEdicao);
        },

        aoPressionarDeletar: function () {
            this.abreDialogoDeConfirmacao();
        },

        deletarPersonagem: async function () {
            let idPersonagemSelecionado = this.getView().getModel(NOME_DO_MODELO_DE_PERSONAGEM_SELECIONADO).getData().id;
            let requisicao = await Repositorio.deletar(MODELO_DE_REQUISICAO, idPersonagemSelecionado);

            let tituloCaixaDeDialogo;
            let mensagem;
            let estadoDoDialogo;

            if (requisicao.ok) {
                tituloCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText(sucessoTitulo);
                mensagem = this.getView().getModel(i18n).getResourceBundle().getText(sucessoMsg);
                estadoDoDialogo = ValueState.Success;
            } else {
                tituloCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText(erroTitulo);
                mensagem = this.criarMensagemDeErro(requisicao);
                estadoDoDialogo = ValueState.Error;
            }

            this.abrirDialogo(tituloCaixaDeDialogo, mensagem, estadoDoDialogo)
        },

        abreDialogoDeConfirmacao: function () {
            const confirmarTitulo = "Remocao.Confirmacao.Titulo"
            const confirmarMsg = "Remocao.Confirmacao.Mensagem"
            const confirmarBotao = "Remocao.Confirmacao.BotaoConfirmar"
            const cancelarBotao = "Remocao.Confirmacao.BotaoCancelar"

            let ButtonType = mobileLibrary.ButtonType;
            let DialogType = mobileLibrary.DialogType;
            let titulo = this.getView().getModel(i18n).getResourceBundle().getText(confirmarTitulo);
            let mensagem = this.getView().getModel(i18n).getResourceBundle().getText(confirmarMsg);
            let textoBotaoConfirmar = this.getView().getModel(i18n).getResourceBundle().getText(confirmarBotao);
            let textoBotaoCancelar = this.getView().getModel(i18n).getResourceBundle().getText(cancelarBotao);
            let valueStateDeConfirmacao = ValueState.Warning;

            let botaoConfirmar = new Button({
                type: ButtonType.Emphasized,
                text: textoBotaoConfirmar,
                press: function () {
                    this.oConfirmationMessageDialog.close();
                    this.deletarPersonagem();
                }.bind(this)
            });

            let botaoCancelar = new Button({
                type: ButtonType.Emphasized,
                text: textoBotaoCancelar,
                press: function () {
                    this.oConfirmationMessageDialog.close();
                }.bind(this)
            });

            this.oConfirmationMessageDialog = new Dialog({
                type: DialogType.Message,
                title: titulo,
                state: valueStateDeConfirmacao,
                content: new Text({ text: mensagem }),
                beginButton: botaoConfirmar,
                endButton: botaoCancelar
            });

            this.oConfirmationMessageDialog.open();
        },

        criarMensagemDeErro: function (requisicao) {
            let mensagemDeErro = {
                title: requisicao.Title,
                status: requisicao.Status,
                type: requisicao.Type,
                details: requisicao.Detail
            };

            let regex = /at .*/s;
            let detalhesLimpos = mensagemDeErro.details.replace(regex, '').trim();

            detalhesLimpos = detalhesLimpos.replace(/(\r?\n\s*){2,}/g, '\n\n').trim();

            let mensagemFormatada =
                "Título: " + mensagemDeErro.title + QUEBRA_DE_LINHA +
                "Status: " + mensagemDeErro.status + QUEBRA_DE_LINHA +
                "Tipo: " + mensagemDeErro.type + QUEBRA_DE_LINHA +
                "Detalhes: " + detalhesLimpos;

            return mensagemFormatada;
        },

        abrirDialogo: function (tituloCaixaDeDialogo, mensagem, estadoDoDialogo) {
            const botaoFecharDialogo = "Cadastro.FecharDiaogo.Botao";
            let ButtonType = mobileLibrary.ButtonType;
            let DialogType = mobileLibrary.DialogType;
            let botaoCaixaDeDialogo = this.getView().getModel(i18n).getResourceBundle().getText(botaoFecharDialogo);

            let botao = new Button({
                type: ButtonType.Emphasized,
                text: botaoCaixaDeDialogo,
                press: function () {
                    this.retornarNavegacao();
                }.bind(this)
            });

            this.oErrorMessageDialog = new Dialog({
                type: DialogType.Message,
                title: tituloCaixaDeDialogo,
                state: estadoDoDialogo,
                content: new Text({ text: mensagem }),
                beginButton: botao
            });

            this.oErrorMessageDialog.open();
        },
    });
});