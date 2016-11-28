/*global angular */
(function () {
    'use strict';

    angular.module('app')
        .config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {

            $stateProvider
                .state('login',
                {
                    url: '/login',
                    templateUrl: 'scripts/app/login/login.html',
                    controller: 'loginCtrl'
                  
                })
            .state('dash',
               {
                   url: '/dashboard',
                   templateUrl: 'scripts/app/dashboard/dashboard.html',
                   controller: 'dashctrl'
                  
               })
            .state('products',
              {
                  url: '/products',
                  templateUrl: 'scripts/app/products/products.html',
                  controller: 'productsctrl'


              })
             .state('addProduct',
              {
                  url: '/addProduct',
                  templateUrl: 'scripts/app/products/Addproduct.html',
                  controller: 'productsctrl'
              })
            .state('customers',
              {
                  url: '/customers',
                  templateUrl: 'scripts/app/customers/customers.html',
                  controller: 'customersctrl'

              })
            .state('purchase',
              {
                  url: '/purchase',
                  templateUrl: 'scripts/app/purchaseHistory/purchaseHistory.html',
                  controller: 'purchaseHistoryController'

              })
            .state('error',
              {
                  url: '/error',
                  templateUrl: 'scripts/app/Error/Error.html',
                  controller: 'purchaseHistoryController'

              });
               
            $urlRouterProvider.otherwise('/login');
        }]);


})();