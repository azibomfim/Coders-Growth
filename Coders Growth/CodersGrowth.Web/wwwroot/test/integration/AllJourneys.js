sap.ui.define([
	"sap/ui/test/Opa5",
	"genshin/test/integration/arrangements/Startup",
	"genshin/test/integration/JornadaCadastro",
	"genshin/test/integration/JornadaLista",
	"genshin/test/integration/JornadaNotFound"
	
], function (Opa5, Startup) {
	"use strict";

	const NAME_SPACE = "genshin";

	Opa5.extendConfig({
		arrangements: new Startup(),
		viewNamespace: NAME_SPACE,
		autoWait: true
	});
});