sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/core/UIComponent",
    "sap/ui/model/json/JSONModel"
], function (Controller, History, UIComponent, JSONModel) {
    "use strict";

    return Controller.extend("genshin.app.common.BaseController", {

        processarAcao: function(action) {
			try {
				const result = action();
				return result;
			} 
            catch (error) {
				console.log(error);
			}
		},

		navegarPara: function (rota, id) {
            return this.getRouter().navTo(rota, {
                id: id
            }, true);
        },

        getRouter() {
			return UIComponent.getRouterFor(this);
		},
		
		getModel : function (name) {
			return this.getView().getModel(name);
		}
    });
});