(function() {
    'use strict';

    //angular.module('app',
    //[
    //    'ui.router', 'ui.bootstrap', 'angular-loading-bar',
    //    'ngCookies', 'angularModalService', 'chart.js',
    //    'ngResource'
    //]);
    angular.module('app',
    [
        'ui.router', 'ui.bootstrap', 'angular-loading-bar',
        'ngCookies', 'angularModalService',
        'ngResource', 'ui.bootstrap.modal'
    ]);
    angular.module('app')
        .constant('appSettings',
        {
            serverPath: 'http://localhost:61762/'
               
          
        });

}());