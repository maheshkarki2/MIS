/*global angular*/
(function () {
    'use strict';

    // register service as a factory
    angular.module('app').factory('dashBoardService', dashBoardService);

    dashBoardService.$inject = ['$resource', 'appSettings'];

    function dashBoardService($resource, appSettings) {

        return $resource(appSettings.serverPath + '/api/product/',
        {},
        {
            'getProductsCount': { 'method': 'GET', 'url': appSettings.serverPath + '/api/product/getProductCount' },
            'getPurchaseCount': { 'method': 'GET', 'url': appSettings.serverPath + '/api/sales/GetPurchaseCount' }
        });
    }
})();