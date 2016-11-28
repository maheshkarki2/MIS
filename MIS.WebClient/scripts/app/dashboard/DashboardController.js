/*global angular, kendo, window */
(function () {
    'use strict';

    //register controller
    angular.module('app').controller('dashctrl', dashboardController);
    //inject controller dependencies
    dashboardController.$inject = [
        '$scope', '$rootScope', '$http', '$state', '$stateParams', '$window', '$timeout', '$location', 'appSettings', 'dashBoardService'
    ];

    //controller definition
    function dashboardController($scope,
        $rootScope,
        $http,
        $state,
        $stateParams,
        $window,
        $timeout,
        $location,
        appSettings,
        dashBoardService) {


        dashBoardService.getProductsCount(function (res) {
            if (res.Success) {
                $state.go("error");
                $scope.totalRepairFaults = new kendo.data.DataSource({ data: res.body });
                $scope.donutOptions = {
                    legend: {
                        padding: {
                            right: 5,
                            top: 20
                        }
                    },
                    seriesDefaults: {
                        type: 'donut',
                        startAngle: 270,
                        visibleInLegendField: false
                    },
                    dataSource: $scope.totalRepairFaults,

                    series: [
                        {
                            field: 'Value',
                            categoryField: 'Type',
                            visibleInLegendField: false
                        }
                    ],
                    seriesColors: ['#9de219', '#068c35', '#033939', '#90cc38'],
                    tooltip: {
                        visible: true,
                        template: '#= Type # - #= Value #'
                    }
                };
            } else {
                $state.go("error");
            }
        },function(error) {
            $state.go("error");
        });
    }
})();