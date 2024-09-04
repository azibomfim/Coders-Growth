sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/core/UIComponent",
    "sap/ui/model/json/JSONModel"
], function (Controller, History, UIComponent, JSONModel) {
    "use strict";

    return Controller.extend("genshin.app.common.BaseController", {

        aoPressionarRetornarNavegacao: function () {
            var oHistory, sPreviousHash;

            oHistory = History.getInstance();
            sPreviousHash = oHistory.getPreviousHash();
            
            if (sPreviousHash !== undefined) {
                window.history.go(-1);
            } else {
                this.getOwnerComponent().getRouter().navTo("app");
            }
        },

        processarAcao: function(action) {
			try {
				const result = action();
				return result;
			} 
            catch (error) {
				console.log("erro");
			}
		},

        getRouter() {
			return UIComponent.getRouterFor(this);
		},
		
		getModel : function (name) {
			return this.getView().getModel(name);
		},

        obterTodosFiltros: async function (filtros, nomeDoModelo) {

            const urlPagina = window.location.origin;

            const url = urlPagina + "/api/" + nomeDoModelo + "?" + filtros;
            
            console. log(url)

            await fetch(url)
                .then(requisicao => {
                    console.log(requisicao.status);
                    return requisicao.json();
                })
                .then(dados => {
                    console. log(dados)
                    const oDadosRequisicao = new JSONModel(dados);
                    this.getView().setModel(oDadosRequisicao, nomeDoModelo);
                })
                .catch(erro => {
                    console.error("Erro ao obter dados:", erro);
                });
            }

    });

});