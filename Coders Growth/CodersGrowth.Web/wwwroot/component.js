sap.ui.define([
    "sap/ui/core/UIComponent",
    "sap/ui/core/mvc/XMLView"
], (UIComponent, XMLView) => {
    "use strict";

    return UIComponent.extend("genshin.Component", {

        metadata: {
            interfaces: ["sap.ui.core.IAsyncContentCreation"],
            manifest: "json"
        },

        init: function () {
            UIComponent.prototype.init.apply(this, arguments);
            this.getRouter().initialize();
        },

        getTable: function () {
            return this.getRootControl().getContent()[0];
        }
    });
});