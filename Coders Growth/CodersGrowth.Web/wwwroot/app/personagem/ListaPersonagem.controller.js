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

    const  URL_API = "https://localhost:7085/api/Personagem";
    const FILTRO_NOME = "filtroNome";
    const FILTRO_DATA = "filtroData";
    const FILTRO_USUARIO = "filtroUsuario";
    const NOME_DO_MODELO = "Personagem";

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
                    Repositorio.carregarDadosPersonagem("", view),
                    Repositorio.obterEnumNome(view),
                    Repositorio.obterEnumArma(view),
                    Repositorio.obterEnumElemento(view)
                ])
            })
        },

        aoAlterarFiltrar: async function(){
            this.processarAcao(() => {
                let view = this.getView();
                let nomeUsuario = this.getView().byId(FILTRO_USUARIO).getValue();

                let dataFormatada = this.getView().byId(FILTRO_DATA).getValue();
    
                let nomePersonagem = this.getView().byId(FILTRO_NOME).getSelectedKey();
    
                var filtros = "";
    
                filtros = nomeUsuario.length == 0 ? filtros + "" : "nomeUsuario=" + nomeUsuario;
    
                filtros = dataFormatada.length == 0 ? filtros + "" : (filtros.length == 0 ? filtros + "dataDeAquisicao=" + dataFormatada: filtros + "&dataDeAquisicao=" + dataFormatada);
    
                filtros = nomePersonagem.length == 0 ? filtros + "" : (filtros.length == 0 ? filtros + "nomePersonagem=" + nomePersonagem: filtros + "&nomePersonagem=" + nomePersonagem);
    
                Repositorio.carregarDadosPersonagem(filtros, view);
            });
        }
    });
});