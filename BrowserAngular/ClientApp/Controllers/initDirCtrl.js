browser.controller("initDirCtrl", [
    "$scope","$rootScope","browserSrv", function ($scope,$rootScope,browserSrv) {
        $scope.directoryInfo = browserSrv.get();
        //$rootScope.$emit("scopeEmitInitialInfo", $scope.directoryInfo);
        $scope.rootOpen = function(path) {
            $rootScope.$emit("openDirectory", path);
        }

    }
]);