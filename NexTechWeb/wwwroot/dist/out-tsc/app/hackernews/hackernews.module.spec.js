"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var hackernews_module_1 = require("./hackernews.module");
describe('HackernewsModule', function () {
    var hackernewsModule;
    beforeEach(function () {
        hackernewsModule = new hackernews_module_1.HackernewsModule();
    });
    it('should create an instance', function () {
        expect(hackernewsModule).toBeTruthy();
    });
});
//# sourceMappingURL=hackernews.module.spec.js.map