sap.ui.define([
	"sap/ui/test/Opa5",
	"sap/ui/test/actions/Press",
    "sap/ui/test/actions/EnterText"
], (Opa5, Press, EnterText) => {
	"use strict";

	const nomeDaView = "app.personagem.ListaPersonagem";
    const nomeUsuario = "andre";
    const nomePersonagem = "Xiao";
    const dataDeAquisicao = "24 de jul. de 2024"
    const personagensPorUsuario = 1;
    const personagensPorNome = 2;
    const personagensPorData = 1;
    const idTabela = "table";

	Opa5.createPageObjects({
		naPaginaLista: {
			actions: {
                filtroPorNomeDePersonagem: function () {
					return this.waitFor({
						viewName: nomeDaView,
						controlType: "sap.m.ComboBox",
						matchers: {
							i18NText: {
								propertyName: "placeholder",
								key: "Filtro.NomePersonagem"
							}
						},
						actions: new EnterText({ text: nomePersonagem}),
						success: () => Opa5.assert.ok(true, "O nome escolhido foi selecionado"),
						errorMessage: "O filtro não foi encontrado na aplicação"
					});
				},

                filtroPorUsuarioCriador: function () {

                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: "sap.m.SearchField",
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: "Filtro.NomeUsuario"
                            }
                        },
                        actions: new EnterText({ text: nomeUsuario }),
                        success: () => Opa5.assert.ok(true, "O campo de busca foi preenchido com o nome de usuário "),
                        errorMessage: "O campo de busca não foi preenchido com o nome de usuário "
                    });
                },

                filtroPorData: function () {

                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: "sap.m.DatePicker",
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: "Filtro.Data"
                            }
                        },
                        actions: new EnterText({ text: dataDeAquisicao }),
                        success: () => Opa5.assert.ok(true, "A data foi adicionada no Datepicker"),
                        errorMessage: "A data não foi adicionada no Datepicker"
                    });
                }
            },

			assertions: {
				deveExibirTituloCorreto: function () {
					return this.waitFor({
						controlType: "sap.m.Title",
                        matchers: {
                            i18NText: {
                                propertyName: "text",
                                key: "ListaPersonagem.Titulo"
                            }
                        },
						success: () => Opa5.assert.ok(true, "O título está sendo exibido"),
						errorMessage: "O título não está sendo exibido"
					});
				},

				deveExibirPersonagensDoUsuario: function () {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: "sap.ui.table.Table",
                        check: function(tabela){
                            return tabela[0].getBinding().getLength() === personagensPorUsuario
                        },
                        success: (oTable) => Opa5.assert.ok( oTable, "Os personagens foram filtrados corretamente"),
                        errorMessage: "O número de personagens filtrados está errado"
                    });
				},

                deveExibirPersonagensPorData: function () {
                    return this.waitFor({
                        controlType: "sap.ui.table.Table",
                        viewName: nomeDaView,
                        check: function(tabela){
                            return tabela[0].getBinding().getLength() === personagensPorData;
                        },
                        success: (oTable) => Opa5.assert.ok( oTable, "Os personagens foram filtrados corretamente"),
                        errorMessage: "O número de personagens filtrados está errado"
                    });
				},

                deveExibirPersonagensPorNome: function () {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: "sap.ui.table.Table",
                        check: function(tabela){
                            return tabela[0].getBinding().getLength() === personagensPorNome;
                        },
                        success: (oTable) => Opa5.assert.ok( oTable, "Os personagens foram filtrados corretamente"),
                        errorMessage: "O número de personagens filtrados está errado"
                    });
				}
			}
		}
	});
});