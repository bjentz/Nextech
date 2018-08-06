"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var rxjs_1 = require("../../../node_modules/rxjs");
var environment_1 = require("../../environments/environment");
var operators_1 = require("rxjs/operators");
var HackerNewsService = /** @class */ (function () {
    function HackerNewsService(http) {
        this.http = http;
    }
    HackerNewsService.prototype.getBestStories = function () {
        var _this = this;
        return this.http.get(environment_1.environment.apiUrl).pipe(operators_1.map(function (res) { return res; })
        //, tap(data => console.log('All: ' + JSON.stringify(data)))
        , operators_1.catchError(function (err) { return rxjs_1.Observable.throw(_this.handleError); }));
    };
    HackerNewsService.prototype.handleError = function (err) {
        // just logging it to the console
        var errorMessage = '';
        if (err.error instanceof ErrorEvent) {
            // A client-side or network error occurred. Handle it accordingly.
            errorMessage = "An error occurred: " + err.error.message;
        }
        else {
            // The backend returned an unsuccessful response code.
            // The response body may contain clues as to what went wrong,
            errorMessage = "Server returned code: " + err.status + ", error message is: " + err.message;
        }
    };
    HackerNewsService = __decorate([
        core_1.Injectable({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], HackerNewsService);
    return HackerNewsService;
}());
exports.HackerNewsService = HackerNewsService;
//# sourceMappingURL=hackernews.service.js.map