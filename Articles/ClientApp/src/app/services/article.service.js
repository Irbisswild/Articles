"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ArticleService = void 0;
var ArticleService = /** @class */ (function () {
    function ArticleService(http) {
        this.loadArticles(http, "/");
    }
    ArticleService.prototype.getArticles = function () {
        return this.articles;
    };
    ArticleService.prototype.loadArticles = function (http, baseUrl) {
        var _this = this;
        http.get(baseUrl + 'api/article').subscribe(function (result) {
            _this.articles = result;
        }, function (error) { return console.error(error); });
    };
    return ArticleService;
}());
exports.ArticleService = ArticleService;
//# sourceMappingURL=article.service.js.map