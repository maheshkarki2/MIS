/*global angular*/
(function () {
    'use strict';

    // register service as a factory
    angular.module('app').factory('salesService', salesService);

    salesService.$inject = ['$resource', 'appSettings'];

    function salesService($resource, appSettings) {

        return $resource(appSettings.serverPath + '/api/product/',
        { id: '@id' },
        {
            'query': { isArray: false },
            'getAllProducts': { 'method': 'GET', 'url': appSettings.serverPath + '/api/getAllProduct' },
            'getAllCustomers': { 'method': 'GET', 'url': appSettings.serverPath + '/api/sales/GetCustomerss' },
            'getAllPurchaseDetails': { 'method': 'GET', 'url': appSettings.serverPath + '/api/sales/GetPurchaseDetails' },
            'getAllPurchases': { 'method': 'GET', 'url': appSettings.serverPath + '/api/purchase/getAllPurchases' },
            'addProduct': { 'method': 'POST', 'url': appSettings.serverPath + '/api/product/SaveProduct' },
            'getProductById':{ 'method': 'GET', 'url': appSettings.serverPath + '/api/product/getProductById/:id' }
        });
    }
})();