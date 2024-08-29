sap.ui.define([
   "sap/ui/core/mvc/Controller",
   "sap/ui/model/resource/ResourceModel",
   "genshin/app/BaseController",
   "sap/ui/core/library"
   ], (BaseController) => {
   "use strict";
   
   return BaseController.extend("genshin.app.App", {
       onInit : function(){
       },
   
       aoClicarEmBoasVindas : async function() {
           this.oDialogo ??= await this.loadFragment({
               name: "genshin.app.BoasVindasDialogo"
           });
   
           this.oDialogo.open();
       },
   
       aoClicarEmFecharDialogo : function(){
           this.byId("boasVindasDialogo").close();
       }
   });
   });