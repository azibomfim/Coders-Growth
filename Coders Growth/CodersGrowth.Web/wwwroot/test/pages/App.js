sap.ui.define([
	"sap/ui/test/Opa5",
	"sap/ui/test/actions/Press"
], (Opa5, Press) => {
	"use strict";

	const sNomeDaTela = "ui5.genshin.appcontrollerview.App";

	Opa5.createPageObjects({
		onAppPagina: {
			actions: {
				AoPressionarBotaoBoasVindas() {
					return this.waitFor({
						id: "btnBoasVindas",
						viewName: sNomeDaTela,
						actions: new Press(),
						errorMessage: "O botão 'Diga Bem Vindo com caixa de diálogo' não foi encontrado na visualização App"
					});
				}
			},

			assertions: {
				AoMostarDialogoBoasVindas() {
					return this.waitFor({
						controlType: "sap.m.Dialog",
						success() {
							Opa5.assert.ok(true, "A caixa de diálogo está aberta");
						},
						errorMessage: "O controle de diálogo não foi encontrado"
					});
				}
			}
		}
	});
});