sap.ui.define([
	"sap/ui/test/Opa5",
	"sap/ui/test/actions/Press"
], (Opa5, Press) => {
	"use strict";

	const NomeDaView = "app.App";

	Opa5.createPageObjects({
		NaPaginaApp: {
			actions: {
				ClicoNoBotaoDeBoasVindas() {
					return this.waitFor({
						viewName: NomeDaView,
						controlType: "sap.m.Button",
						matchers: {
							i18NText: {
								propertyName: "text",
								key: "btn.Boas.Vindas"
							}
						},
						actions: new Press(),
						success: () => Opa5.assert.ok(true, "A caixa de diálogo foi encontrada"),
						errorMessage: "O botão 'Diga Bem Vindo com caixa de diálogo' não foi encontrado na visualização App"
					});
				},
				ClicoNoBotaoDeFecharDialogo() {
					return this.waitFor({
						searchOpenDialogs: true,
						controlType: "sap.m.Button",
						matchers: {
							i18NText: {
								propertyName: "text",
								key: "btn.Fechar.Dialogo"
							}
						},
						actions: new Press(),
						success: () => Opa5.assert.ok(true, "A caixa de diálogo foi fechada"),
						errorMessage: "O botão 'Ok' não foi encontrado"
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
				},
				DeveFecharDialogoDeBoasVindas() {
					return this.waitFor({
						controlType: "sap.m.Button",
						matchers: {
							i18NText: {
								propertyName: "text",
								key: "btn.Boas.Vindas"
							}
						},
						success: () => Opa5.assert.ok(true, "A caixa de diálogo está fechada"),
						errorMessage: "A caixa de diálogo não foi fechada"
					});
				}
			}
		}
	});
});