﻿var browser = angular.module("browser", ["ngRoute","browserServices"]);

browser.config(["$routeProvider", "$compileProvider", function ($routeProvider, $compileProvider) {
    $routeProvider.
        when('/', {
            templateUrl: 'ClientApp/partials/initial.html',
            controller: 'initDirCtrl'
        }).
        when('/:path', {
            templateUrl: 'ClientApp/partials/directories.html',
            controller: 'browserCtrl'
        }).
        otherwise({
            redirectTo: '/'
        });
    $compileProvider.aHrefSanitizationWhitelist(/^(?:[\w]\:)|(https?|ftp|mailto|file|javascript|chrome-extension):/);
    
}]);