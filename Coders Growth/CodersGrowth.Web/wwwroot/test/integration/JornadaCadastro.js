sap.ui.define([
    "sap/ui/test/opaQunit",
    "genshin/test/integration/pages/Cadastro"
], (opaTest) => {
    "use strict";

    QUnit.module("Cadastro");

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

        opaTest("Ao adicionar um personagem com campos vazios, deve abrir a mensagem de erro", (Given, When, Then) => {
            Given.iStartMyUIComponent({
                componentConfig: {
                    name: "genshin"
                },
                hash: "cadastroPersonagem"
            });
            
            When.naPaginaCadastro.ClicoNoBotaoDeSalvar();
            
            Then.naPaginaCadastro.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();
            Then.naPaginaCadastro.pressionaOBotaoDeFecharCaixaDeDialogo();
            }); 

        opaTest("Ao adicionar um personagem com nome de usuário inválido, deve abrir a mensagem de erro", (Given, When, Then) => {
            When.naPaginaCadastro.inseridoNomePersonagem(nomePersonagem);
            When.naPaginaCadastro.inseridoNomeUsuario(nomeUsuarioErrado);
            When.naPaginaCadastro.inseridoArma(arma);
            When.naPaginaCadastro.inseridoElemento(elemento);
            When.naPaginaCadastro.inseridoVida(vida);
            When.naPaginaCadastro.inseridoAtaque(ataque);
            When.naPaginaCadastro.inseridoDefesa(defesa);
            When.naPaginaCadastro.inseridoTaxa(taxaCrit);
            When.naPaginaCadastro.inseridoDano(danoCrit);
            When.naPaginaCadastro.inseridoCura(bonusCura);
            When.naPaginaCadastro.inseridoBonus(bonusElemental);
            When.naPaginaCadastro.inseridoEscudo(escudo);
            When.naPaginaCadastro.inseridoProficiencia(proficiencia);
            When.naPaginaCadastro.inseridoRecarga(recarga);
            When.naPaginaCadastro.inseridoConstelacao(constelacao);
            When.naPaginaCadastro.inseridoData(dataDeAquisicao);
            When.naPaginaCadastro.ClicoNoBotaoDeSalvar();
            
            Then.naPaginaCadastro.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();
            Then.naPaginaCadastro.pressionaOBotaoDeFecharCaixaDeDialogo();
        }); 

        opaTest("Ao adicionar um personagem com campos vazios, deve abrir a mensagem de erro", (Given, When, Then) => {
            When.naPaginaCadastro.ClicoNoBotaoDeSalvar();
            
            Then.naPaginaCadastro.verificaSeAbreUmaCaixaDeDialogoIndicandoErro();
            Then.naPaginaCadastro.pressionaOBotaoDeFecharCaixaDeDialogo();
            }); 

        opaTest("Ao adicionar um personagem válido, deve abrir a mensagem de sucesso", (Given, When, Then) => {
            When.naPaginaCadastro.inseridoNomePersonagem(nomePersonagem);
            When.naPaginaCadastro.inseridoNomeUsuario(nomeUsuario);
            When.naPaginaCadastro.inseridoArma(arma);
            When.naPaginaCadastro.inseridoElemento(elemento);
            When.naPaginaCadastro.inseridoVida(vida);
            When.naPaginaCadastro.inseridoAtaque(ataque);
            When.naPaginaCadastro.inseridoDefesa(defesa);
            When.naPaginaCadastro.inseridoTaxa(taxaCrit);
            When.naPaginaCadastro.inseridoDano(danoCrit);
            When.naPaginaCadastro.inseridoCura(bonusCura);
            When.naPaginaCadastro.inseridoBonus(bonusElemental);
            When.naPaginaCadastro.inseridoEscudo(escudo);
            When.naPaginaCadastro.inseridoProficiencia(proficiencia);
            When.naPaginaCadastro.inseridoRecarga(recarga);
            When.naPaginaCadastro.inseridoConstelacao(constelacao);
            When.naPaginaCadastro.inseridoData(dataDeAquisicao);
            When.naPaginaCadastro.ClicoNoBotaoDeSalvar();
            
            Then.naPaginaCadastro.verificaSeAbreUmaCaixaDeDialogoIndicandoSucesso();

            Then.naPaginaCadastro.pressionaOBotaoDeFecharCaixaDeDialogo();

            Then.iTeardownMyApp();
        }); 
    });
