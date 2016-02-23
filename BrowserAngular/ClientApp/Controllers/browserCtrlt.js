browser.controller("browserCtrl", ["$scope", "$rootScope", "$routeParams","$templateCache", "browserSrv", function ($scope, $rootScope,$routeParams,$templateCache, browserSrv) {


    $scope.getDirInfoByPath = function (path) {
        $scope.directoryInfo = browserSrv.getWithPath({ path: $routeParams.path });
        //$rootScope.$emit("getDirInfoByPath", $scope.directoryInfo);
        $rootScope.$emit("openDirectory", path);
    };
    
    $scope.directoryInfo = browserSrv.getWithPath({ path: $routeParams.path });
    $scope.$on('$routeChangeStart', function (event, next, current) {
        if (typeof (current) !== 'undefined') {
            $templateCache.remove(current.templateUrl);
            //console.log($routeParams.path);
            //console.log(current.params.path);
            $rootScope.$emit("openDirectory111", next.params.path);
            console.log(next.params.path);
            //console.log(next);
            //console.log(current);
        }
    });
}]);