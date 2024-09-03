sap.ui.define([
    "sap/base/Log",
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
    "sap/ui/core/format/DateFormat",
    "sap/ui/thirdparty/jquery",
    "sap/ui/core/date/UI5Date",
    "genshin/app/model/formatter"
], function (Log, BaseController, JSONModel, MessageToast, DateFormat, jQuery, UI5Date, formatter) {
    "use strict";

    const  URL_API = "https://localhost:7085/api/Personagem";
    const FILTRO_NOME = "filtroNome";
    const FILTRO_DATA = "filtroData";
    const FILTRO_USUARIO = "filtroUsuario";
    const NOME_DO_MODELO = "personagem";

    return BaseController.extend("genshin.app.personagem.ListaPersonagem", {
        formatter: formatter,

        onInit: function () {
            this.aoCoincidirRota();
        },

        carregarDadosPersonagem: function(){
            fetch ("https://localhost:7085/api/Personagem")
                .then((res) => res.json())
                .then((data) => this.getView().setModel(new JSONModel(data), "Personagem"))
        },

        aoCoincidirRota() {
            this.processarAcao(() => {
                this.getRouter().getRoute("listaPersonagem").attachPatternMatched(async () => {
                    await this.carregarDadosPersonagem()
                    // await this.obterNomes()
                }, this);
            })
        },

        aoAlterarFiltrar: function(){
            
            this.processarAcao(() => {
                const queryParts = [];
                const filtroUsuario = this.getView().byId(FILTRO_USUARIO).getText();
                const filtroData = this.getView().byId(FILTRO_DATA).getValue(data);
                const filtroNome = this.getView().byId(FILTRO_NOME).getSelectedItem().getText();
                
               
                if (filtroNome) {
                    queryParts.push(`Nome=${filtroNome}`);
                }

                if (filtroData) {
                    queryParts.push(`DataDeAquisicao=${filtroData}`);
                }

                if (filtroUsuario) {
                    queryParts.push(`NomeUsuario=${filtroUsuario}`);
                }

                const query = URL_API + "?" + queryParts.join("&");

                this.carregarDadosPersonagem(query, NOME_DO_MODELO, this.getView());
            });
        }

    });

});