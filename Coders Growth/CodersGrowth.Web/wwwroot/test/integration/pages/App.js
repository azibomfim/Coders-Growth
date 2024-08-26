sap.ui.define([
	"sap/ui/test/Opa5",
	"sap/ui/test/actions/Press",
	"sap/ui/test/matchers/I18NText"
], (Opa5, Press, i18NText) => {
	"use strict";

	const sNomeDaView = "app.App";

	Opa5.createPageObjects({
		onAppPagina: {
			actions: {
				ClicoNoBotaoDeBoasVindas() {
					return this.waitFor({
						viewName: sNomeDaView,
						actions: new Press(),
						success: () => Opa5.assert.ok(true, "A caixa de diálogo foi encontrada"),
						errorMessage: "O botão 'Diga Bem Vindo com caixa de diálogo' não foi encontrado na visualização App"
					});
				}
			},

			assertions: {
				DeveExibirDialogoDeBoasVindas() {
					return this.waitFor({
						controlType: "sap.m.Dialog",
						success: () => Opa5.assert.ok(true, "A caixa de diálogo está aberta"),
						errorMessage: "O controle de diálogo não foi encontrado"
					});
				}
			}
		}
	});
});