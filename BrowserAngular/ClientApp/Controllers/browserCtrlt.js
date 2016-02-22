browser.controller("browserCtrl", ["$scope", "$rootScope", "$routeParams", "browserSrv", function ($scope, $rootScope,$routeParams, browserSrv) {


    $scope.getDirInfoByPath = function (path) {
        $scope.directoryInfo = browserSrv.getWithPath({ path: $routeParams.path });
        //$rootScope.$emit("getDirInfoByPath", $scope.directoryInfo);
        $rootScope.$emit("openDirectory", path);
    };
    
    $scope.directoryInfo = browserSrv.getWithPath({ path: $routeParams.path });

}]);