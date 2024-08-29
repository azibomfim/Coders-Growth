sap.ui.define([
    "sap/ui/test/opaQunit",
    "genshin/test/integration/pages/NotFound"
], (opaTest) => {
    "use strict";

    QUnit.module("NotFound");

    opaTest("Ao realizar uma requisição em uma rota inexistente, deve mostrar a tela de NotFound", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "genshin"
            },
            hash: "teste"
        });
        
        Then.naPaginaNotFound.aTelaNotFoundFoiCarregadaCorretamente();

            Then.iTeardownMyApp();
        }); 
    });
