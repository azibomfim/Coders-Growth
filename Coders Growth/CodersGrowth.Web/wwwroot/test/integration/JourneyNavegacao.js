sap.ui.define([
	"sap/ui/test/opaQunit",
	"./pages/App"
], (opaTest) => {
	"use strict";

	QUnit.module("Navigation");

	opaTest("Mostrar o dialogo de boas vindas", (Given, When, Then) => {
		Given.iStartMyUIComponent({
			componentConfig: {
				name: "ui5.genshin"
			}
		});

		When.onAppPagina.AoPressionarBotaoBoasVindas();

		Then.onAppPagina.AoMostarDialogoBoasVindas();

		Then.iTeardownMyApp();
	});
});