sap.ui.define([
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/type/DateTime"
], function (JSONModel, DateTime) {
    "use strict";

    return {
        formatarEnumNome(valorInteiroDoEnumNome){
            const nomeModelo = "enumNome";
            
            if (!valorInteiroDoEnumNome)
                return;
                let modelo = this.getView().getModel(nomeModelo);
                if (modelo) 
                    return modelo.getData()
                            .find(nome => nome.key === valorInteiroDoEnumNome)?.descricao
                else 
                    this.getView()
                        .setModel(new JSONModel([]), nomeModelo)
            },
            formatarEnumElemento(valorInteiroDoEnumElemento){
                const nomeModelo = "enumElemento";
    
                if (!valorInteiroDoEnumElemento)
                    return;
    
                    let modelo = this.getView().getModel(nomeModelo);
    
                    if (modelo) 
                        return modelo.getData()
                                .find(elemento => elemento.key === valorInteiroDoEnumElemento)?.descricao
                    else 
                        this.getView()
                            .setModel(new JSONModel([]), nomeModelo)
                },
                formatarEnumArma(valorInteiroDoEnumArma){
                    const nomeModelo = "enumArma";
        
                    if (!valorInteiroDoEnumArma)
                        return;
        
                        let modelo = this.getView().getModel(nomeModelo);
        
                        if (modelo) 
                            return modelo.getData()
                                    .find(arma => arma.key === valorInteiroDoEnumArma)?.descricao
                        else 
                            this.getView()
                                .setModel(new JSONModel([]), nomeModelo)
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