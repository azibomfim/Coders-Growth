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
	const nomeDaViewEdicao = "app.personagem.EdicaoPersonagem";
    const controltypeObj = "sap.m.ObjectAttribute";
    const propriedadeText = "text";
    const controltypeBotao = "sap.m.Button";
    const botaoEditar = "Editar.Botao";


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
                        errorMessage: "O botao de editarnão foi pressionado"
                    });
                },
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
			}
		}
	})
});