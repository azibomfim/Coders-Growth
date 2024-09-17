sap.ui.define([
    "sap/ui/test/opaQunit",
    "genshin/test/integration/pages/Detalhes"
], (opaTest) => {
    "use strict";

    QUnit.module("Detalhes");

    const nomeUsuario = "monakai";
    const nomeUsuarioErrado = "fdjkhskdfksjhdf"
    const nomePersonagem = "Shikanoin Heizou";
    const dataDeAquisicao = "24/07/2024";
    const arma = "Catalisador";
    const elemento = "Anemo";
    const constelacao = "1";
    const vida = "1";
    const ataque = "1";
    const defesa = "1";
    const proficiencia = "1";
    const danoCrit = "1";
    const taxaCrit = "1";
    const recarga = "1";
    const escudo = "1";
    const bonusElemental = "1";
    const bonusCura = "1";

    opaTest("Ao entrar na tela de detalhes do personagem de id 250, deve exibir seus dados corretamente", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "genshin"
            },
            hash: "detalhesPersonagem/250"
        });
        
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(nomePersonagem);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(nomeUsuario);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(arma);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(elemento);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(vida);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(ataque);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(defesa);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(taxaCrit);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(danoCrit);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(bonusCura);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(bonusElemental);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(escudo);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(proficiencia);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(recarga);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(constelacao);
        Then.naPaginaDetalhes.confiroOsValoresDosAtributos(dataDeAquisicao);
        }); 

        opaTest("Ao clicar em editar, deve abrir a tela de edição", (Given, When, Then) => {
            When.naPaginaDetalhes.pressionoBotaoDeEditar();
            
            Then.naPaginaDetalhes.aTelaDeEdicaoFoiCarregada();
    
                Then.iTeardownMyApp();
            }); 
    });
