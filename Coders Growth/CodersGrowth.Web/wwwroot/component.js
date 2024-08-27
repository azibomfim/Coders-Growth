sap.ui.define([
	"sap/ui/core/UIComponent",
	"sap/ui/core/library"
], (UIComponent) => {
	"use strict";

	return UIComponent.extend("genshin.Component", {
		metadata: {
			interfaces: ["sap.ui.core.IAsyncContentCreation"],
			manifest: "json"
		},

		init() {
			UIComponent.prototype.init.apply(this, arguments);
			this.getRouter().initialize();
		}
	});
});