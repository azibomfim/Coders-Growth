sap.ui.define([
    "sap/ui/test/opaQunit",
    "genshin/test/integration/pages/Edicao"
], (opaTest) => {
    "use strict";

    QUnit.module("Edicao");

    const nomeUsuario = "monakai";
    const nomeUsuarioErrado = "fdjkhskdfksjhdf"
    const nomePersonagem = "Shikanoin Heizou";
    const dataDeAquisicao = "24 de jul. de 2024";
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
    const stringVazia = "";

    opaTest("Ao editar um personagem com campos vazios, deve abrir a mensagem de erro", (Given, When, Then) => {
        Given.iStartMyUIComponent({
            componentConfig: {
                name: "genshin"
            },
            hash: "edicaoPersonagem/230"
        });
        
        When.naPaginaEdicao.inseridoNomePersonagem(stringVazia);
        When.naPaginaEdicao.inseridoNomeUsuario(stringVazia);
        When.naPaginaEdicao.inseridoArma(stringVazia);
        When.naPaginaEdicao.inseridoElemento(stringVazia);
        When.naPaginaEdicao.inseridoVida(stringVazia);
        When.naPaginaEdicao.inseridoAtaque(stringVazia);
        When.naPaginaEdicao.inseridoDefesa(stringVazia);
        When.naPaginaEdicao.inseridoTaxa(stringVazia);
        When.naPaginaEdicao.inseridoDano(stringVazia);
        When.naPaginaEdicao.inseridoCura(stringVazia);
        When.naPaginaEdicao.inseridoBonus(stringVazia);
        When.naPaginaEdicao.inseridoEscudo(stringVazia);
        When.naPaginaEdicao.inseridoProficiencia(stringVazia);
        When.naPaginaEdicao.inseridoRecarga(stringVazia);
        When.naPaginaEdicao.inseridoConstelacao(stringVazia);
        When.naPaginaEdicao.inseridoData(stringVazia);
        When.naPaginaEdicao.ClicoNoBotaoDeSalvar();
        
        Then.naPaginaEdicao.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();
        Then.naPaginaEdicao.pressionaOBotaoDeFecharCaixaDeDialogo();
    }); 

    opaTest("Ao editar um personagem com nome de usuário inválido, deve abrir a mensagem de erro", (Given, When, Then) => {
        When.naPaginaEdicao.inseridoNomePersonagem(nomePersonagem);
        When.naPaginaEdicao.inseridoNomeUsuarioErrado(nomeUsuarioErrado);
        When.naPaginaEdicao.inseridoArma(arma);
        When.naPaginaEdicao.inseridoElemento(elemento);
        When.naPaginaEdicao.inseridoVida(vida);
        When.naPaginaEdicao.inseridoAtaque(ataque);
        When.naPaginaEdicao.inseridoDefesa(defesa);
        When.naPaginaEdicao.inseridoTaxa(taxaCrit);
        When.naPaginaEdicao.inseridoDano(danoCrit);
        When.naPaginaEdicao.inseridoCura(bonusCura);
        When.naPaginaEdicao.inseridoBonus(bonusElemental);
        When.naPaginaEdicao.inseridoEscudo(escudo);
        When.naPaginaEdicao.inseridoProficiencia(proficiencia);
        When.naPaginaEdicao.inseridoRecarga(recarga);
        When.naPaginaEdicao.inseridoConstelacao(constelacao);
        When.naPaginaEdicao.inseridoData(dataDeAquisicao);
        When.naPaginaEdicao.ClicoNoBotaoDeSalvar();
        
        Then.naPaginaEdicao.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();
        Then.naPaginaEdicao.pressionaOBotaoDeFecharCaixaDeDialogo();
    }); 

    opaTest("Ao editar um personagem válido, deve abrir a mensagem de sucesso", (Given, When, Then) => {
        When.naPaginaEdicao.inseridoNomePersonagem(nomePersonagem);
        When.naPaginaEdicao.inseridoNomeUsuario(nomeUsuario);
        When.naPaginaEdicao.inseridoArma(arma);
        When.naPaginaEdicao.inseridoElemento(elemento);
        When.naPaginaEdicao.inseridoVida(vida);
        When.naPaginaEdicao.inseridoAtaque(ataque);
        When.naPaginaEdicao.inseridoDefesa(defesa);
        When.naPaginaEdicao.inseridoTaxa(taxaCrit);
        When.naPaginaEdicao.inseridoDano(danoCrit);
        When.naPaginaEdicao.inseridoCura(bonusCura);
        When.naPaginaEdicao.inseridoBonus(bonusElemental);
        When.naPaginaEdicao.inseridoEscudo(escudo);
        When.naPaginaEdicao.inseridoProficiencia(proficiencia);
        When.naPaginaEdicao.inseridoRecarga(recarga);
        When.naPaginaEdicao.inseridoConstelacao(constelacao);
        When.naPaginaEdicao.inseridoData(dataDeAquisicao);
        When.naPaginaEdicao.ClicoNoBotaoDeSalvar();
        
        Then.naPaginaEdicao.verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso();

        Then.naPaginaEdicao.pressionaOBotaoDeFecharCaixaDeDialogo();

        Then.iTeardownMyApp();
    }); 
    });
