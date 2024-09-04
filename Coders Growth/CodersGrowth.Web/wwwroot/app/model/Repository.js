// sap.ui.define([
//     "sap/ui/model/json/JSONModel",
//     "genshin/app/personagem/ListaPersonagem"
// ], function (JSONModel, ListaPersonagem) {
//     "use strict";

//     ListaPersonagem.extend("genshin.app.personagem.ListaPersonagem", {

//     obterEnumNome: function(){
//         debugger
//         let kk = ListaPersonagem
//         fetch ("https://localhost:7085/api/Enum/nomes")
//             .then((res) => res.json())
//             .then((res) => ListaPersonagem.getView().setModel(new JSONModel({enumNome: res}))
//     )},

//     obterEnumArma: function(){
//         fetch ("https://localhost:7085/api/Enum/armas")
//             .then((res) => res.json())
//             .then((res) => this.getView().setModel(new JSONModel({enumArma: res}))
//     )},

//     obterEnumElemento: function(){
//         fetch ("https://localhost:7085/api/Enum/elementos")
//             .then((res) => res.json())
//             .then((res) => this.getView().setModel(new JSONModel({enumElemento: res}))
//     )}
// })})
