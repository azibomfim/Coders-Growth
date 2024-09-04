sap.ui.define([
    "sap/base/Log",
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
    "sap/ui/core/format/DateFormat",
    "sap/ui/thirdparty/jquery",
    "sap/ui/core/date/UI5Date",
    "genshin/app/model/formatter",
    "genshin/app/model/Repository"
], function (Log, BaseController, JSONModel, MessageToast, DateFormat, jQuery, UI5Date, formatter, Repository) {
    "use strict";

    const  URL_API = "https://localhost:7085/api/Personagem";
    const FILTRO_NOME = "filtroNome";
    const FILTRO_DATA = "filtroData";
    const FILTRO_USUARIO = "filtroUsuario";
    const NOME_DO_MODELO = "Personagem";

    return BaseController.extend("genshin.app.personagem.ListaPersonagem", {
        formatter: formatter,

        onInit: function () {
            return this.aoCoincidirRota();
        },

        carregarDadosPersonagem: async function(){
            await fetch ("https://localhost:7085/api/Personagem")
                .then((res) => res.json())
                .then((data) => this.getView().setModel(new JSONModel(data), "Personagem"))
        },

        obterEnumNome: async function(){
            await fetch ("https://localhost:7085/api/Enum/nomes")
                .then((res) => res.json())
                .then((res) => this.getView().setModel(new JSONModel(res), "enumNome"))
        },

        obterEnumArma(){
            fetch ("https://localhost:7085/api/Enum/armas")
                .then((res) => res.json())
                .then((res) => this.getView().setModel(new JSONModel(res), "enumArma")
        )},

        obterEnumElemento (){
            fetch ("https://localhost:7085/api/Enum/elementos")
                .then((res) => res.json())
                .then((res) => this.getView().setModel(new JSONModel(res), "enumElemento")
        )},

        aoCoincidirRota() {
            this.processarAcao(() => {
                this.getRouter().getRoute("listaPersonagem").attachPatternMatched(async () => {
                    debugger
                    await Promise.all([
                    this.carregarDadosPersonagem(),
                    this.obterEnumNome(),
                    this.obterEnumArma(),
                    this.obterEnumElemento()
                    ])
                    
                }, this);
            })
        },

        aoAlterarFiltrar: async function(){
            debugger
            this.processarAcao(() => {
                let nomeUsuario = this.getView().byId(FILTRO_USUARIO).getValue();

                let dataFormatada = this.getView().byId(FILTRO_DATA).getValue();
    
                let nomePersonagem = this.getView().byId(FILTRO_NOME).getSelectedKey();
    
                var filtros = "";
    
                filtros = nomeUsuario.length == 0 ? filtros + "" : "nomeUsuario=" + nomeUsuario;
    
                filtros = dataFormatada.length == 0 ? filtros + "" : (filtros.length == 0 ? filtros + "dataDeAquisicao=" + dataFormatada: filtros + "&dataDeAquisicao=" + dataFormatada);
    
                filtros = nomePersonagem.length == 0 ? filtros + "" : (filtros.length == 0 ? filtros + "nomePersonagem=" + nomePersonagem: filtros + "&nomePersonagem=" + nomePersonagem);
    
                this.obterTodosFiltros(filtros, NOME_DO_MODELO);
    
                this.carregarDadosPersonagem(query, NOME_DO_MODELO, this.getView());

            });
        }

    });

});