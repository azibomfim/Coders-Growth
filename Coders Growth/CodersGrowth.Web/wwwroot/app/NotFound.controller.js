sap.ui.define([
   "genshin/app/common/BaseController"
], function (BaseController) {
   "use strict";

       const NAME_SPACE = "genshin.app.NotFound";

       return BaseController.extend(NAME_SPACE, {
        onInit: function () {

        },
      
        aoPressionarRetornarNavegacao: function(){
            const rota = "listaPersonagem";
            return this.navegarPara(rota);
        }
    });
   });