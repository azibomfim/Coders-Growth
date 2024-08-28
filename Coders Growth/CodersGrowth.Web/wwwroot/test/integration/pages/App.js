sap.ui.define([
	"sap/ui/test/Opa5",
	"sap/ui/test/actions/Press"
], (Opa5, Press) => {
	"use strict";

	const nomeDaView = "app.App";

	Opa5.createPageObjects({
		naPaginaApp: {
			actions: {
				clicoNoBotaoDeBoasVindas() {
					return this.waitFor({
						viewName: nomeDaView,
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
				clicoNoBotaoDeFecharDialogo() {
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
				deveExibirDialogoDeBoasVindas() {
					return this.waitFor({
						controlType: "sap.m.Dialog",
						success: () => Opa5.assert.ok(true, "A caixa de diálogo está aberta"),
						errorMessage: "O controle de diálogo não foi encontrado"
					});
				},
				deveFecharDialogoDeBoasVindas() {
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