sap.ui.define([
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "genshin/app/model/Repositorio",
    "genshin/app/model/formatter",
], function (BaseController, JSONModel, Repositorio, formatter) {
    "use strict";

    const CONTROLLER = "genshin.app.personagem.DetalhesPersonagem";
    const ID_DETALHES = "detalhesPersonagem";
    const NOME_DO_MODELO_DE_PERSONAGEM_SELECIONADO = "PersonagemSelecionado";
    const MODELO_DE_REQUISICAO = "Personagem";


    return BaseController.extend(CONTROLLER, {
        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute(ID_DETALHES).attachPatternMatched(async (evento) => {
                return this.aoCoincidirRota(evento);
            }, this)
        },

        aoCoincidirRota: function(evento) {
            let idPersonagem = evento.getParameters().arguments.id;
            let view = this.getView();
            this.processarAcao(async () => {
                await Promise.all([
                    Repositorio.obterPorId(view, idPersonagem, MODELO_DE_REQUISICAO, NOME_DO_MODELO_DE_PERSONAGEM_SELECIONADO),
                    Repositorio.obterEnumNome(view),
                    Repositorio.obterEnumArma(view),
                    Repositorio.obterEnumElemento(view)
                ])
            })
        },

        retornarNavegacao: function(){
            const rota = "listaPersonagem";
            return this.navegarPara(rota);
        },

        aoPressionarEditar: function () {
            const rotaTelaDeEdicao = "edicaoPersonagem";
            let PersonagemEdicao = this.getView().getModel(NOME_DO_MODELO_DE_PERSONAGEM_SELECIONADO).getData().id;
            return this.navegarPara(rotaTelaDeEdicao, PersonagemEdicao);
        }
    });
});