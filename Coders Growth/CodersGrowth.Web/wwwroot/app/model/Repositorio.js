sap.ui.define([
    "sap/ui/model/json/JSONModel",
    "genshin/app/common/BaseController",
    "sap/m/MessageBox",
    "sap/ui/core/UIComponent",
    "sap/ui/core/routing/History"
], function (JSONModel, BaseController, MessageBox, UIComponent, History) {
    "use strict";

    const nomeDoModelo = "Personagem"

    return {
        carregarDadosPersonagem: async function (filtros, view) {
            const urlPagina = window.location.origin;
            const url = urlPagina + "/api/" + nomeDoModelo;
            const urlFiltro = urlPagina + "/api/" + nomeDoModelo + "?" + filtros;
            if (filtros == "") {
                await fetch(url)
                    .then(requisicao => requisicao.json())
                    .then(dados => view.setModel(new JSONModel(dados), nomeDoModelo))
            } else {
                await fetch(urlFiltro)
                    .then(requisicao => requisicao.json())
                    .then(dados => view.setModel(new JSONModel(dados), nomeDoModelo))
            }
        },

        obterEnumNome: async function(view){
            await fetch ("https://localhost:7085/api/Enum/nomes")
                .then((res) => res.json())
                .then(dados => view.setModel(new JSONModel(dados), "enumNome"))
        },

        obterEnumArma: async function(view){
            await fetch ("https://localhost:7085/api/Enum/armas")
                .then((res) => res.json())
                .then((res) => view.setModel(new JSONModel(res), "enumArma"))
        },

        obterEnumElemento: async function(view){
            await fetch ("https://localhost:7085/api/Enum/elementos")
                .then((res) => res.json())
                .then((res) => view.setModel(new JSONModel(res), "enumElemento"))
        },

        requistarApi: async function(urlApi, personagemNovo){
            const metodo = "POST"
            let resposta = await fetch(urlApi, {
                method: metodo,
                headers: { "Content-type": "application/json"},
                body: personagemNovo
            })
            if(resposta.status != 201){
                
                return resposta.json();  
            };

            return resposta;
        }
    }
});