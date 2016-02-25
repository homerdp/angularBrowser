//Начальный контроллер
browser.controller("initDirCtrl", [
    "$scope","$rootScope","browserSrv", function ($scope,$rootScope,browserSrv) {
        $scope.directoryInfo = browserSrv.getInitial({controller:"dir"});
        $scope.rootOpen = function(path) {
            $rootScope.$emit("openRootDirectory", path);
        }
    }
]);