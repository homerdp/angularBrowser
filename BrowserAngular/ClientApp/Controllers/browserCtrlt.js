//Контроллер перехода по ссылкам
browser.controller("browserCtrl", ["$scope", "$rootScope", "$routeParams", "$templateCache", "browserSrv", function ($scope, $rootScope, $routeParams, $templateCache, browserSrv) {
    
    //переход по папкам
    $scope.getDirInfoByPath = function (path) {
        $scope.directoryInfo = browserSrv.getWithPath({ controller: 'dir', path: $routeParams.path });
        $rootScope.$broadcast("openDirectory", path);
    };
    
    $scope.directoryInfo = browserSrv.getWithPath({ controller: 'dir', path: $routeParams.path });
    $scope.$on('$routeChangeStart', function (event, next, current) {
        if (typeof (current) !== 'undefined') {
                $templateCache.remove(current.templateUrl);
                $rootScope.$broadcast("moveDirectory", next.params.path);  //Если переход не на рут директорию, то пользоваться кешем подсчета сумм файлов, так как долго считается
        }
    });
}]);