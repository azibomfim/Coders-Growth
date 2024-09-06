sap.ui.define([
    "sap/base/Log",
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
    "sap/ui/core/format/DateFormat",
    "sap/ui/thirdparty/jquery",
    "sap/ui/core/date/UI5Date",
    "genshin/app/model/formatter",
    "genshin/app/model/Repositorio"
], function (Log, BaseController, JSONModel, MessageToast, DateFormat, jQuery, UI5Date, formatter, Repositorio) {
    "use strict";

    const  URL_API = "https://localhost:7085/api/Personagem";
    const NOME_DO_MODELO = "Personagem";
    const INPUT_NOME = "inputNome";
    const INPUT_ELEMENTO = "inputElemento";
    const INPUT_ARMA = "inputArma";
    const INPUT_DATA = "inputData";
    const INPUT_CONSTELACAO = "inputConstelacao";
    const INPUT_USUARIO = "inputNomeUsuario";
    const INPUT_BONUS = "inputBonusElemental";
    const INPUT_CURA = "inputCura";
    const INPUT_ESCUDO = "inputEscudo";
    const INPUT_DANO = "inputDanoCrit";
    const INPUT_TAXA = "inputTaxaCrit";
    const INPUT_VIDA = "inputVida";
    const INPUT_ATAQUE = "inputAtaque";
    const INPUT_DEFESA = "inputDefesa";
    const INPUT_PROFICIENCIA = "inputProficiencia";
    const INPUT_RECARGA = "inputRecarga";

    return BaseController.extend("genshin.app.personagem.CadastroPersonagem", {
        formatter: formatter,

        onInit: function () {
            this.getRouter().getRoute("cadastroPersonagem").attachPatternMatched(async () => {
                return this.aoCoincidirRota();
            }, this);
        },

        aoCoincidirRota: function() {
            let view = this.getView();
            this.processarAcao(async () => {
                await Promise.all([
                    Repositorio.carregarDadosPersonagem("", view),
                    Repositorio.obterEnumNome(view),
                    Repositorio.obterEnumArma(view),
                    Repositorio.obterEnumElemento(view)
                ])
            })
        },

        aoPressionarRetornarNavegacao: function(){
            const rota = "listaPersonagem";
            return this.navegarPara(rota);
        },

        aoClicarEmSalvar: function(){
            const inputNome = this.getView().byId(INPUT_NOME).SelectedKey().getText();
            const inputArma = this.getView().byId(INPUT_ARMA).SelectedKey().getText();
            const inputElemento = this.getView().byId(INPUT_ELEMENTO).SelectedKey().getText();
            const inputUsuario = this.getView().byId(INPUT_USUARIO);
        }
    });
});