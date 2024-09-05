sap.ui.define([
    "sap/ui/test/opaQunit",
    "genshin/test/integration/pages/Lista"
], (opaTest) => {
    "use strict";

    QUnit.module("Lista");

    opaTest("O título da tela de lista deve ser exibido corretamente", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "genshin"
            },
        });
        
        Then.naPaginaLista.deveExibirTituloCorreto();
        }); 

    opaTest("A tela deve exibir 2 personagens ao filtrar por nome", (Given, When, Then) => {
        When.naPaginaLista.filtroPorNomeDePersonagem();
            
        Then.naPaginaLista.deveExibirPersonagensPorNome();
        }); 

    opaTest("A tela deve exibir 3 personagens ao filtrar por usuário criador", (Given, When, Then) => {
        When.naPaginaLista.filtroPorUsuarioCriador();
                
        Then.naPaginaLista.deveExibirPersonagensDoUsuario();
        }); 

    opaTest("A tela deve exibir 2 personagens ao filtrar por data", (Given, When, Then) => {
        When.naPaginaLista.filtroPorData();
                
        Then.naPaginaLista.deveExibirPersonagensPorData();

            Then.iTeardownMyApp();
        }); 
    });
