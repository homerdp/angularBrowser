browser.controller("browserCtrl", ["$scope", "browserSrv", function($scope,browserSrv) {
    $scope.directoryInfo = browserSrv.get();
    $scope.rootPath = "";
    $scope.rootOpen = function(path) {
        $scope.rootPath = path;
        $scope.directoryInfo = browserSrv.getWithPath({path:path});
}

    $scope.getDirInfoByPath = function (path) {
           $scope.directoryInfo = browserSrv.getWithPath({ path: path });
       };

}]);