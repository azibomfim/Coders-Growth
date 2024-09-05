sap.ui.define([
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/type/DateTime"
], function (JSONModel, DateTime) {
    "use strict";

    return {
        formatarEnums(valorInteiroDoEnumNome, valorInteiroDoEnumElemento, valorInteiroDoEnumArma){
            const modeloNome = "enumNome";
            const modeloElemento = "enumElemento";
            const modeloArma = "enumArma";

            if (!valorInteiroDoEnumNome)
                return;

                let modeloN = this.getView().getModel(modeloNome);

                if (modeloN) 
                    return modeloN.getData()
                            .find(nome => nome.key === valorInteiroDoEnumNome)?.descricao
                else 
                    this.getView()
                        .setModel(new JSONModel([]), modeloNome)

            if (!valorInteiroDoEnumElemento)
                return;
            
                let modeloE = this.getView().getModel(modeloElemento);
            
                if (modeloE) 
                    return modeloE.getData()
                            .find(elemento => elemento.key === valorInteiroDoEnumElemento)?.descricao
                    else 
                        this.getView()
                            .setModel(new JSONModel([]), modeloElemento)

            if (!valorInteiroDoEnumArma)
                return;
                
                let modeloA = this.getView().getModel(modeloArma);
                
                if (modeloA) 
                    return modeloA.getData()
                            .find(arma => arma.key === valorInteiroDoEnumArma)?.descricao
                    else 
                            this.getView()
                                .setModel(new JSONModel([]), modeloArma)
            },

                    formatarData: function (sData) {
                        if (!sData) {
                            return "";
                        }
            
                        var oType = new DateTime({ pattern: "dd/MM/yyyy" });
                        var oDate = new Date(sData);
                        return oType.formatValue(oDate, "string");
                    }
        }
});