sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/core/UIComponent"
], function (Controller, History, UIComponent) {
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
		}

    });

});