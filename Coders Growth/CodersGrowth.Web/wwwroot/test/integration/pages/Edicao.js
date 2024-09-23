sap.ui.define([
    "sap/ui/test/Opa5",
    "sap/ui/test/matchers/I18NText",
    "sap/ui/test/matchers/Matcher",
    "sap/ui/test/matchers/Properties",
    "sap/ui/test/actions/EnterText",
    "sap/ui/test/actions/Press",
    "sap/ui/test/matchers/AggregationLengthEquals",
    "sap/m/Dialog"
],
    function (Opa5, I18NText, Matcher, Properties, EnterText, Press, AggregationLengthEquals, Dialog) {
	"use strict";

	const nomeDaView = "app.personagem.CadastroPersonagem";
    const INPUT_NOME = "Cadastro.NomePersonagem";
    const INPUT_ELEMENTO = "Cadastro.Elemento";
    const INPUT_ARMA = "Cadastro.Arma";
    const INPUT_DATA = "Cadastro.Data";
    const INPUT_CONSTELACAO = "Cadastro.Constelacao";
    const INPUT_USUARIO = "Cadastro.NomeUsuario";
    const INPUT_BONUS = "Cadastro.BonusElemental";
    const INPUT_CURA = "Cadastro.Cura";
    const INPUT_ESCUDO = "Cadastro.Escudo";
    const INPUT_DANO = "Cadastro.DanoCrit";
    const INPUT_TAXA = "Cadastro.TaxaCrit";
    const INPUT_VIDA = "Cadastro.Vida";
    const INPUT_ATAQUE = "Cadastro.Ataque";
    const INPUT_DEFESA = "Cadastro.Defesa";
    const INPUT_PROFICIENCIA = "Cadastro.Proficiencia";
    const INPUT_RECARGA = "Cadastro.Recarga";
    const controltypeInput = "sap.m.Input";
    const controltypeBotao = "sap.m.Button";
    const controltypeMessagebox = "sap.m.Dialog";
    const controltypeDatePicker = "sap.m.DatePicker";
    const controltypeComboBox = "sap.m.ComboBox";

	Opa5.createPageObjects({
		naPaginaEdicao: {
			actions: {
                inseridoNomePersonagem: function (nomePersonagem) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeComboBox,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_NOME
                            }
                        },
                        actions: new EnterText({ text: nomePersonagem }),
                        success: () => Opa5.assert.ok(true, "O input de nome do personagem foi preenchido"),
                        errorMessage: "O input de nome do personagem não foi preenchido"
                    });
                },

                inseridoNomeUsuario: function (nomeUsuario) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_USUARIO
                            }
                        },
                        actions: new EnterText({ text: nomeUsuario }),
                        success: () => Opa5.assert.ok(true, "O input de nome do usuário foi preenchido"),
                        errorMessage: "O input de nome do usuário não foi preenchido"
                    });
                },

                inseridoNomeUsuarioErrado: function (nomeUsuarioErrado) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_USUARIO
                            }
                        },
                        actions: new EnterText({ text: nomeUsuarioErrado }),
                        success: () => Opa5.assert.ok(true, "O input de nome do usuário foi preenchido"),
                        errorMessage: "O input de nome do usuário não foi preenchido"
                    });
                },

                inseridoArma: function (arma) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeComboBox,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_ARMA
                            }
                        },
                        actions: new EnterText({ text: arma }),
                        success: () => Opa5.assert.ok(true, "O input de arma foi preenchido"),
                        errorMessage: "O input de arma não foi preenchido"
                    });
                },
                inseridoElemento: function (elemento) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeComboBox,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_ELEMENTO
                            }
                        },
                        actions: new EnterText({ text: elemento }),
                        success: () => Opa5.assert.ok(true, "O input de elemento foi preenchido"),
                        errorMessage: "O input de elemento não foi preenchido"
                    });
                },
                inseridoVida: function (vida) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_VIDA
                            }
                        },
                        actions: new EnterText({ text: vida }),
                        success: () => Opa5.assert.ok(true, "O input de vida foi preenchido"),
                        errorMessage: "O input de vida não foi preenchido"
                    });
                },
                
                inseridoAtaque: function (ataque) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_ATAQUE
                            }
                        },
                        actions: new EnterText({ text: ataque }),
                        success: () => Opa5.assert.ok(true, "O input de ataque foi preenchido"),
                        errorMessage: "O input de ataque não foi preenchido"
                    });
                },

                inseridoDefesa: function (defesa) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_DEFESA
                            }
                        },
                        actions: new EnterText({ text: defesa }),
                        success: () => Opa5.assert.ok(true, "O input de defesa foi preenchido"),
                        errorMessage: "O input de defesa não foi preenchido"
                    });
                },
                
                inseridoTaxa: function (taxaCrit) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_TAXA
                            }
                        },
                        actions: new EnterText({ text: taxaCrit }),
                        success: () => Opa5.assert.ok(true, "O input de taxa crítica foi preenchido"),
                        errorMessage: "O input de taxa crítica não foi preenchido"
                    });
                },

                inseridoDano: function (danoCrit) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_DANO
                            }
                        },
                        actions: new EnterText({ text: danoCrit }),
                        success: () => Opa5.assert.ok(true, "O input de dano crítico foi preenchido"),
                        errorMessage: "O input de dano crítico não foi preenchido"
                    });
                },

                inseridoCura: function (bonusCura) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_CURA
                            }
                        },
                        actions: new EnterText({ text: bonusCura }),
                        success: () => Opa5.assert.ok(true, "O input de bônus de cura foi preenchido"),
                        errorMessage: "O input de bônus de cura não foi preenchido"
                    });
                },

                inseridoBonus: function (bonusElemental) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_BONUS
                            }
                        },
                        actions: new EnterText({ text: bonusElemental }),
                        success: () => Opa5.assert.ok(true, "O input de bônus elemental foi preenchido"),
                        errorMessage: "O input de bônus elemental não foi preenchido"
                    });
                },

                inseridoEscudo: function (escudo) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_ESCUDO
                            }
                        },
                        actions: new EnterText({ text: escudo }),
                        success: () => Opa5.assert.ok(true, "O input de escudo foi preenchido"),
                        errorMessage: "O input de escudo não foi preenchido"
                    });
                },

                inseridoProficiencia: function (proficiencia) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_PROFICIENCIA
                            }
                        },
                        actions: new EnterText({ text: proficiencia }),
                        success: () => Opa5.assert.ok(true, "O input de proficiência elemental foi preenchido"),
                        errorMessage: "O input de proficiência elemental não foi preenchido"
                    });
                },

                inseridoRecarga: function (recarga) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_RECARGA
                            }
                        },
                        actions: new EnterText({ text: recarga }),
                        success: () => Opa5.assert.ok(true, "O input de recarga de energia foi preenchido"),
                        errorMessage: "O input de recarga de energia não foi preenchido"
                    });
                },

                inseridoConstelacao: function (constelacao) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeInput,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_CONSTELACAO
                            }
                        },
                        actions: new EnterText({ text: constelacao }),
                        success: () => Opa5.assert.ok(true, "O input de constelação foi preenchido"),
                        errorMessage: "O input de constelação não foi preenchido"
                    });
                },

                inseridoData: function (dataDeAquisicao) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeDatePicker,
                        matchers: {
                            i18NText: {
                                propertyName: "placeholder",
                                key: INPUT_DATA
                            }
                        },
                        actions: new EnterText({ text: dataDeAquisicao }),
                        success: () => Opa5.assert.ok(true, "O input de data foi preenchido"),
                        errorMessage: "O input de data não foi preenchido"
                    });
                },

                ClicoNoBotaoDeSalvar() {
					return this.waitFor({
						viewName: nomeDaView,
						controlType: controltypeBotao,
						matchers: {
							i18NText: {
								propertyName: "text",
								key: "Cadastro.Salvar"
							}
						},
						actions: new Press(),
						success: () => Opa5.assert.ok(true, "O botão foi pressionado"),
						errorMessage: "O botão não foi encontrado"
					});
				}
            },

			assertions: {
                verificaSeAbreUmaCaixaDeDialogoIndicandoErro: function () {
                    const mensagemEsperada = "Erro";
                    return this.waitFor({
                        controlType: controltypeMessagebox,
                        check: function (MessageBox) {
                            return MessageBox[0].getTitle() == mensagemEsperada;
                        },
                        success: () => Opa5.assert.ok(true, "O erro nos dados inseridos foi indentificado com sucesso"),
                        errorMessage: "O erro nos dados inseridos não foi indentificado"
                    });
                },

				verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso: function () {
                    const mensagemEsperada = "Sucesso";
                    return this.waitFor({
                        controlType: controltypeMessagebox,
                        check: function (MessageBox) {
                            return MessageBox[0].getTitle() == mensagemEsperada;
                        },
                        success: () => Opa5.assert.ok(true, "O personagem foi criado com sucesso"),
                        errorMessage: "O personagem não foi criado"
                    });
                },
                
                pressionaOBotaoDeFecharCaixaDeDialogo: function () {
                    return this.waitFor({
                        controlType: controltypeBotao,
                        actions: new Press(),
                        success: () => Opa5.assert.ok(true, "O botão de fechar caixa de diálogo foi pressionado"),
                        errorMessage: "O botão de fechar caixa de diálogo não foi pressionado"
                    });
                }
			}
		}
	})
});