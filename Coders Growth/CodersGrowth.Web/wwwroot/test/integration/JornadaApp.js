sap.ui.define([
    "sap/ui/test/opaQunit",
    "sap/ui/core/library",
    "genshin/test/integration/pages/App"
], (opaTest) => {
    "use strict";

    QUnit.module("App");

    opaTest("Ao clicar, deve mostrar o dialogo de boas vindas", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "genshin"
            }
        }); 

        When.naPaginaApp.clicoNoBotaoDeBoasVindas();

        Then.naPaginaApp.deveExibirDialogoDeBoasVindas();
    });

    opaTest("Ao clicar, deve fechar o dialogo de boas vindas", (Given, When, Then) => {
        When.naPaginaApp.clicoNoBotaoDeFecharDialogo();

        Then.naPaginaApp.deveFecharDialogoDeBoasVindas();

        Then.iTeardownMyApp();
    });
});