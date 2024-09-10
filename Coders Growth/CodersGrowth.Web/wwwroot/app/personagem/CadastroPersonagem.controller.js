sap.ui.define([
    "sap/base/Log",
    "genshin/app/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
    "sap/ui/core/format/DateFormat",
    "sap/ui/thirdparty/jquery",
    "sap/ui/core/date/UI5Date",
    "genshin/app/model/formatter",
    "genshin/app/model/Repositorio",
], function (Log, BaseController, JSONModel, MessageToast, DateFormat, jQuery, UI5Date, formatter, Repositorio) {
    "use strict";

    const  URL_API = "https://localhost:7085/api/Personagem/";
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
    const REQUISICAO_POST = "POST"

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

        retornarNavegacao: function(){
            const rota = "listaPersonagem";
            return this.navegarPara(rota);
        },

        aoClicarEmSalvar: function(){

                let nome = this.getView().byId(INPUT_NOME).getSelectedKey();
                let arma = this.getView().byId(INPUT_ARMA).getSelectedKey();
                let elemento = this.getView().byId(INPUT_ELEMENTO).getSelectedKey();
                let inputUsuario = this.getView().byId(INPUT_USUARIO);
                let data = this.getView().byId(INPUT_DATA).getValue();
                let constelacao = this.getView().byId(INPUT_CONSTELACAO).getValue();
                let bonusElemental = this.getView().byId(INPUT_BONUS).getValue();
                let cura = this.getView().byId(INPUT_CURA).getValue();
                let escudo = this.getView().byId(INPUT_ESCUDO).getValue();
                let danoCrit = this.getView().byId(INPUT_DANO).getValue();
                let taxaCrit = this.getView().byId(INPUT_TAXA).getValue();
                let vida = this.getView().byId(INPUT_VIDA).getValue();
                let ataque = this.getView().byId(INPUT_ATAQUE).getValue();
                let defesa = this.getView().byId(INPUT_DEFESA).getValue();
                let proficiencia = this.getView().byId(INPUT_PROFICIENCIA).getValue();
                let recarga = this.getView().byId(INPUT_RECARGA).getValue();
                let nomeUsuario = inputUsuario.getValue();
                let idUsuario = 5;
                
                    let novoPersonagem = {
                        nomePersonagem: parseInt(nome),
                        vida: vida,
                        ataque: ataque,
                        defesa: defesa,
                        proficienciaElemental: proficiencia,
                        taxaCrit: taxaCrit,
                        danoCrit: danoCrit,
                        bonusCura: cura,
                        recargaDeEnergia: recarga,
                        escudo: escudo,
                        bonusElemental: bonusElemental,
                        criadoPorUsuario: true,
                        constelacaoLv: constelacao,
                        dataDeAquisicao: new Date(data),
                        elemento: parseInt(elemento),
                        arma: parseInt(arma),
                        idUsuario: idUsuario,
                        nomeUsuario: nomeUsuario
                    }
                    let personagemString = JSON.stringify(novoPersonagem);
                    
                    const requisicao = REQUISICAO_POST;
                    Repositorio.requistarApi(URL_API, personagemString, requisicao);
        }
    }
)})