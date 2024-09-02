sap.ui.define([
    "sap/base/Log",
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
    "sap/ui/core/format/DateFormat",
    "sap/ui/thirdparty/jquery",
    "sap/ui/core/date/UI5Date",
    "genshin/app/model/formatter"
], function (Log, Controller, JSONModel, MessageToast, DateFormat, jQuery, UI5Date, formatter) {
    "use strict";

    return Controller.extend("sap.ui.table.sample.Basic.Controller", {
        formatter: formatter,

        onInit: function () {
            this.carregarDadosPersonagem();
        },

        carregarDadosPersonagem: function(){
            fetch ("https://localhost:7085/api/Personagem")
                .then((res) => res.json())
                .then((data) => this.getView().setModel(new JSONModel(data), "Personagem"))
        }

    });

});