/*global angular, kendo, window */
(function () {
    'use strict';

    //register controller
    angular.module('app').controller('purchaseHistoryController', purchaseHistoryController);
    //inject controller dependencies
    purchaseHistoryController.$inject = [
        '$scope', '$rootScope', '$http', '$state', '$stateParams', 'salesService'];

    //controller definition
    function purchaseHistoryController($scope,
        $rootScope,
        $http,
        $state,
        $stateParams, salesService) {

        $scope.resPurchaseHistory = "";
        var salesHistory = salesService.getAllPurchases({}).$promise;
            salesHistory.then(function (res) {
                if (res.Success) {
                    $scope.resPurchaseHistory = res.Body;
                }
            },
            function(error) {
                $state.go("error");
            });
    }
})();