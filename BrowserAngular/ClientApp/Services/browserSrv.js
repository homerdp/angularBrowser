var browserSrv =  angular.module("browserServices",["ngResource"]);

browserSrv.factory("browserSrv", [
    "$resource", function($resource) {
        return $resource("http://localhost\\:49557/api/dir/", {}, {
            getWithPath: { method: 'GET',  isArray: false }
        });
    }
]);