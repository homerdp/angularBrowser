browser.controller("filesCountCtrl", [
    "$scope", "$rootScope", "$templateCache", "$routeParams", "browserSrv", function ($scope, $rootScope, $templateCache, $routeParams, browserSrv) {

        $rootScope.$on("openRootDirectory", function (event, data) {
            $scope.minMaxCount = browserSrv.getWithPath({ controller: 'count', path: data });
            if ($scope.minMaxCount)
                $scope.loaded = true;
            $scope.currentPath = data;

        });
        $rootScope.$on("openDirectory", function (event, data) {
            $scope.minMaxCount = browserSrv.getWithPath({ controller: 'count', path: data });
            if ($scope.minMaxCount)
                $scope.loaded = true;
            $scope.currentPath = data;

        });
        $rootScope.$on("getDirInfoByPath", function (event, data) {
            $scope.minMaxCount = data;
        });
        $rootScope.$on("moveDirectory", function (event, data) {
            $scope.minMaxCount = browserSrv.getWithPath({ controller: 'count', path: data });
            $scope.currentPath = data;

        });
        $scope.$on("$routeChangeStart", function (event, next, current) {
            if (next.params.path != "")
                $scope.path = next.params.path;
        });



    }
]);