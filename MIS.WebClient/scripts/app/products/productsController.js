/*global angular, kendo, window */
(function () {
    'use strict';

    //register controller
    angular.module('app').controller('productsctrl', productsController);
    //inject controller dependencies
    productsController.$inject = [
        '$scope', '$rootScope', '$http', '$state', '$stateParams', 'salesService','$uibModal'

    ];

    //controller definition

    function productsController($scope,
        $rootScope,
        $http,
        $state,
        $stateParams,
        salesService,
        $uibModal
    ) {
        $scope.newProduct = {};
        $scope.resProducts = "";
        var products = salesService.getAllProducts({}).$promise;
        products.then(function(res) {
            if (res.success) {
                $scope.resProducts = res.body;
            }
        });

        $scope.insertProduct = function() {
            $scope.newProduct = {
                ProductName: $scope.productName,
                ProductCode: $scope.productCode,
                Description: $scope.productDescription,
                Price: $scope.productPrice
            }
            var addProduct = salesService.addProduct({
                    ProductName: $scope.productName,
                    ProductCode: $scope.productCode,
                    Description: $scope.productDescription
                })
                .$promise;
            addProduct.then(function() {
                    $state.go("products");
                },
                function(error) {
                    $state.go("error");
                });
        }

        var openDialog = function (data) {
            $scope.modalInstance = $uibModal.open({
                templateUrl: '/scripts/app/products/_productDetail.html',
                controller: 'productDetailsCtrl',
                resolve: {
                    product: function () {
                        return data.Body;
                    },
                    close: function () {
                        return $scope.modalclose;
                    }
                }
            });
            $scope.modalInstance.result.then(function () {
            });
        };
        var errorFunction=function() {
            $state.go("error");
        }

        $scope.close = function () {
            $uibModalInstance.close();
        };

        $scope.openProduct=function(id) {
            var singleProduct = salesService.getProductById({ id: id }).$promise;
            singleProduct.then(
            function (data) {
                if(data.success){
                    openDialog(data);
                }
            }, errorFunction);
        }

    }
})();