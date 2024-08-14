sap.ui.define([
   "sap/ui/core/mvc/Controller",
   "sap/ui/model/resource/ResourceModel"
   ], (Controller, ResourceModel) => {
   "use strict";
   
   return Controller.extend("ui5.genshin.app.App", {
       onInit(){
           const i18nModel = new ResourceModel({
               bundleName: "ui5.genshin.i18n.i18n"
           });
           this.getView().setModel(i18nModel, "i18n");
       },
   
       async onBoasVindas() {
           this.oDialogo ??= await this.loadFragment({
               name: "ui5.genshin.app.BoasVindasDialogo"
           });
   
           this.oDialogo.open();
       },
   
       onFecharDialogo(){
           this.byId("boasVindasDialogo").close();
       }
   });
   });