/*global angular, kendo, window */
(function() {
    'use strict';

    //register controller
    angular.module('app').controller('loginCtrl', loginController);
    //inject controller dependencies
    loginController.$inject = [
        '$scope', '$rootScope', '$http'
    ];

    //controller definition
    function loginController($scope,
        $rootScope,
        $http
      ) {
    }
})();