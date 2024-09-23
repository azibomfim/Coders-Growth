sap.ui.define([
    "sap/ui/model/json/JSONModel",
    "genshin/app/common/BaseController",
    "sap/m/MessageBox",
    "sap/ui/core/UIComponent",
    "sap/ui/core/routing/History"
], function (JSONModel, BaseController, MessageBox, UIComponent, History) {
    "use strict";

    const nomeDoModelo = "Personagem"
    const urlPesquisaApi = "/api/";
    const barra = "/";
    const requisicaoDelete = "DELETE";
    const requisicaoPost = "POST";
    const requisicaoPatch = "PATCH";
    const stringVazia = "";
    const interrogacao = "?";
    const enumNome = "enumNome";
    const enumArma = "enumArma";
    const enumElemento = "enumElemento";


    return {
        carregarDadosPersonagem: async function (filtros, view) {
            const urlPagina = window.location.origin;
            const url = urlPagina + urlPesquisaApi + nomeDoModelo;
            const urlFiltro = urlPagina + urlPesquisaApi + nomeDoModelo + interrogacao + filtros;
            if (filtros == stringVazia) {
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
                .then(dados => view.setModel(new JSONModel(dados), enumNome))
        },

        obterEnumArma: async function(view){
            await fetch ("https://localhost:7085/api/Enum/armas")
                .then((res) => res.json())
                .then((res) => view.setModel(new JSONModel(res), enumArma))
        },

        obterEnumElemento: async function(view){
            await fetch ("https://localhost:7085/api/Enum/elementos")
                .then((res) => res.json())
                .then((res) => view.setModel(new JSONModel(res), enumElemento))
        },

        requistarApi: async function(urlApi, personagemNovo, requisicao){
            let status;
            let resposta = await fetch(urlApi, {
                method: requisicao,
                headers: { "Content-type": "application/json"},
                body: personagemNovo
            })
            if(requisicao == requisicaoPatch){
                status = 204
            }
            else if (requisicao == requisicaoPost){
                status = 201
            }
            if(resposta.status != status){
                
                return resposta.json();  
            };
            if(status == 201)
                return resposta.json()

            return resposta;
        },

        obterPorId: async function (view, id, requisicao, nomeDoModelo) {
            let urlPagina = window.location.origin + urlPesquisaApi + requisicao + barra + id;
            let url = new URL(urlPagina);

            let urlRequisicao = new URL(`${url.origin}${url.pathname}`);

            await fetch(urlRequisicao)
                .then(requisicao => {
                    return requisicao.json();
                })
                .then(dados => {
                    const dadosRequisicao = new JSONModel(dados);
                    view.setModel(dadosRequisicao, nomeDoModelo)
                })
                .catch(erro => {
                });
        },

        deletar: async function (requisicao, id) {
            let urlPagina = window.location.origin + urlPesquisaApi + requisicao + barra + id;
            let urlRequisicao = new URL(urlPagina);

            let resposta = await fetch(urlRequisicao, {
                method: requisicaoDelete,
                headers: {
                    'Content-Type': 'application/json'
                }
            });

            if (!resposta.ok) {
                return resposta.json();
            };
            return resposta;
        }
    };
});