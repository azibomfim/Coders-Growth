QUnit.config.autostart = false;

sap.ui.require(["sap/ui/core/Core"], async(Core) => {
	"use strict";

	sap.ui.require([
		"genshin/test/integration/AllJourneys"
	], function() {
		QUnit.start();
	});
});