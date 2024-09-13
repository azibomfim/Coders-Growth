sap.ui.define([
    "sap/ui/model/json/JSONModel",
], function (JSONModel) {
    "use strict";

    return {

        validarSeCampoPossuiValor: function (valorDoCampo){
            if (!valorDoCampo) {
                return false;
            }

            return true;
        }
    }
})