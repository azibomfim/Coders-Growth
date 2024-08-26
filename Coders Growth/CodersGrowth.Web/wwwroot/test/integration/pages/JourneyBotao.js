sap.ui.define([
    "sap/ui/test/opaQunit",
    "sap/ui/core/library",
    "genshin/test/integration/pages/App"
], (opaTest) => {
    "use strict";

    QUnit.module("Botao");

    opaTest("Ao clicar, deve mostrar o dialogo de boas vindas", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "genshin"
            }
        }); 

        When.onAppPagina.ClicoNoBotaoDeBoasVindas();

        Then.onAppPagina.DeveExibirDialogoDeBoasVindas();
    });
});