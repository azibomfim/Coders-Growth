sap.ui.define([
    "sap/ui/test/Opa5",
    "sap/ui/test/matchers/I18NText",
    "sap/ui/test/actions/EnterText",
    "sap/ui/test/actions/Press",
    "sap/ui/test/matchers/PropertyStrictEquals",
    "sap/ui/test/matchers/Properties",
    "sap/m/ObjectAttribute"
],
    function (Opa5, I18NText, EnterText, Press, PropertyStrictEquals, Properties, ObjectAttribute) {
	"use strict";

	const nomeDaView = "app.personagem.DetalhesPersonagem";
	const nomeDaViewEdicao = "app.personagem.CadastroPersonagem";
    const controltypeObj = "sap.m.ObjectAttribute";
    const propriedadeText = "text";
    const controltypeBotao = "sap.m.Button";
    const botaoEditar = "Editar.Botao";
    const botaoDeletar = "Deletar.Botao";
    const botaoCancelar = "Remocao.Confirmacao.BotaoCancelar";
    const botaoConfirmar = "Remocao.Confirmacao.BotaoConfirmar";
    const controltypeMessagebox = "sap.m.Dialog";

	Opa5.createPageObjects({
		naPaginaDetalhes: {
			actions: {
                pressionoBotaoDeEditar: function () {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeBotao,
                        matchers: {
                            i18NText: {
                                propertyName: propriedadeText,
                                key: botaoEditar
                            }
                        },
                        actions: new Press(),
                        success: () => Opa5.assert.ok(true, "O botao de editar foi pressionado"),
                        errorMessage: "O botao de editar não foi pressionado"
                    });
                },

                pressionoBotaoDeDeletar: function () {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeBotao,
                        matchers: {
                            i18NText: {
                                propertyName: propriedadeText,
                                key: botaoDeletar
                            }
                        },
                        actions: new Press(),
                        success: () => Opa5.assert.ok(true, "O botão de deletar personagem foi pressionado"),
                        errorMessage: "O botão de deletar personagem não foi pressionado"
                    });
                },

                pressionoBotaoCancelarDeletar: function () {
                    return this.waitFor({
                        controlType: controltypeBotao,
                        matchers: new PropertyStrictEquals({
                            name: propriedadeText,
                            value: "Cancelar"
                        }),
                        actions: new Press(),
                        success: () => Opa5.assert.ok(true, "O botão de cancelar foi clicado"),
                        errorMessage: "O botão de cancelar não foi clicado"
                    });
                },

                pressionoBotaoConfirmarDeletar: function () {
                    return this.waitFor({
                        controlType: controltypeBotao,
                        matchers: new PropertyStrictEquals({

                            name: propriedadeText,
                            value: "Confirmar"
                        }),
                        actions: new Press(),
                        success: () => Opa5.assert.ok(true, "O botão de confirmar foi clicado"),
                        errorMessage: "O botão de confirmar não foi clicado"
                    });
                }
            },

			assertions: {
                confiroOsValoresDosAtributos: function (valorDaPropriedade) {
                    return this.waitFor({
                        viewName: nomeDaView,
                        controlType: controltypeObj,
                        matchers: new PropertyStrictEquals({

                            name: propriedadeText,
                            value: valorDaPropriedade
                        }),
                        success: () => Opa5.assert.ok(true, "O campo possui o valor esperado"),
                        errorMessage: "O campo não possui o valor esperado"
                    });
                },

                aTelaDeEdicaoFoiCarregada: function () {
                    const rotaDeEdicao = "edicaoPersonagem";
                    return this.waitFor({
                        viewName: nomeDaViewEdicao,
                        check: function () {
                            console.log(window.location.hash.includes(rotaDeEdicao));
                            return window.location.hash.includes(rotaDeEdicao);
                        },
                        success: () => Opa5.assert.ok(true, "A tela de edição foi carregada corretamente"),
                        errorMessage: "A tela de edição não foi carregada corretamente"
                    });
                },

				verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso: function () {
                    const mensagemEsperada = "Sucesso";
                    return this.waitFor({
                        controlType: controltypeMessagebox,
                        check: function (MessageBox) {
                            return MessageBox[0].getTitle() == mensagemEsperada;
                        },
                        success: () => Opa5.assert.ok(true, "O personagem foi deletado com sucesso"),
                        errorMessage: "O personagem não foi deletado"
                    });
                }
			}
		}
	})
});