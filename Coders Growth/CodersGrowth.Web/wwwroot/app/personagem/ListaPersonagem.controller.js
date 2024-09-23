sap.ui.define([
    "sap/base/Log",
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
    "sap/ui/core/format/DateFormat",
    "sap/ui/thirdparty/jquery",
    "sap/ui/core/date/UI5Date",
    "genshin/app/model/formatter",
    "genshin/app/model/Repositorio"
], function (Log, BaseController, JSONModel, MessageToast, DateFormat, jQuery, UI5Date, formatter, Repositorio) {
    "use strict";

    const FILTRO_NOME = "filtroNome";
    const FILTRO_DATA = "filtroData";
    const FILTRO_USUARIO = "filtroUsuario";
    const ID_DETALHES = "detalhesPersonagem";
    const nomeUsuarioURL = "nomeUsuario=";
    const dataDeAquisicaoURL = "dataDeAquisicao=";
    const eDataDeAquisicaoURL = "&dataDeAquisicao=";
    const nomePersonagemURL = "nomePersonagem="
    const eNomePersonagemURL = "&nomePersonagem="
    const stringVazia = "";

    return BaseController.extend("genshin.app.personagem.ListaPersonagem", {
        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute("listaPersonagem").attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this);
        },

        aoCoincidirRota: function() {
            let view = this.getView();
            this.processarAcao(async () => {
                await Promise.all([
                    Repositorio.carregarDadosPersonagem(stringVazia, view),
                    Repositorio.obterEnumNome(view),
                    Repositorio.obterEnumArma(view),
                    Repositorio.obterEnumElemento(view)
                ])
            })
        },

        aoClicarEmCriar: function(){
            const rota = "cadastroPersonagem";
            return this.navegarPara(rota);
        },

        aoAlterarFiltrar: async function(){
            this.processarAcao(() => {
                let view = this.getView();
                let nomeUsuario = this.getView().byId(FILTRO_USUARIO).getValue();

                let dataFormatada = this.getView().byId(FILTRO_DATA).getValue();
    
                let nomePersonagem = this.getView().byId(FILTRO_NOME).getSelectedKey();
    
                var filtros = stringVazia;
    
                filtros = nomeUsuario.length == 0 ? filtros + stringVazia : nomeUsuarioURL + nomeUsuario;
    
                filtros = dataFormatada.length == 0 ? filtros + stringVazia : (filtros.length == 0 ? filtros + dataDeAquisicaoURL + dataFormatada: filtros + eDataDeAquisicaoURL + dataFormatada);
    
                filtros = nomePersonagem.length == 0 ? filtros + stringVazia : (filtros.length == 0 ? filtros + nomePersonagemURL + nomePersonagem: filtros + eNomePersonagemURL + nomePersonagem);
    
                Repositorio.carregarDadosPersonagem(filtros, view);
            });
        },

        aoPressionarAbreTelaDeDetalhes: function (eventoDeClique) {
                let idPersonagemSelecionado = eventoDeClique.getParameters().rowBindingContext.getObject().id
                return this.navegarPara(ID_DETALHES, idPersonagemSelecionado);
        }
    });
});