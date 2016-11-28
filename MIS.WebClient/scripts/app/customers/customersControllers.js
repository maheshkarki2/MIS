/*global angular, kendo, window */
(function () {
    'use strict';

    //register controller
    angular.module('app').controller('customersctrl', customersController);
    //inject controller dependencies
   customersController.$inject = [
        '$scope', '$rootScope', '$http', '$state', '$stateParams', 'salesService'
    ];

    //controller definition
   function customersController($scope,
        $rootScope,
        $http,
        $state,
        $stateParams,
      salesService) {

       var customers = salesService.getAllCustomers({}).$promise;
       customers.then(function() {

       });
   }
})();