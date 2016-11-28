/*global angular, kendo ,window  */
(function () {
    'use strict';
    angular.module('app')
       .controller('productDetailsCtrl', productDetailsController)
       .value('product', null)
       .value('close', null)
    .value('$uibModalInstance', null);
    //register controller
    // angular.module('app').controller('productDetailsCtrl', productDetailsController);

    //inject controller dependencies
    productDetailsController.$inject = [
        '$scope', '$uibModal', '$uibModalInstance', '$rootScope', '$stateParams', 'product', 'close', 'appSettings', '$state','salesService'
    ];

    //controller definition
    function productDetailsController($scope,
        $uibModal,
        $uibModalInstance,
        $rootScope,
        $stateParams,
        product,
        close,
        appSettings,
        $state,
        salesService) {

        $scope.close = close;
        $scope.products = product;
        $scope.isPageView = true;
        
        $scope.close = function () {
            $uibModalInstance.close();
        };
        
    }
})();