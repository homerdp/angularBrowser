browser.controller("dirFilesCountCtrl", [
    "$scope", "$rootScope", "$templateCache","browserSrv", function ($scope, $rootScope,$templateCache, browserSrv) {
        
        $rootScope.$on("scopeEmitInitialInfo", function (event, data) {
            $scope.minMaxCount = data;
        });
        $rootScope.$on("openDirectory", function (event, data) {
            $scope.minMaxCount = browserSrv.getWithPath({ path: data });

        });
        $rootScope.$on("getDirInfoByPath", function (event, data) {
            $scope.minMaxCount = data;
        });
        $rootScope.$on("openDirectory111", function (event, data) {
            $scope.minMaxCount = browserSrv.getWithPath({ path: data });

        });



    }
]);