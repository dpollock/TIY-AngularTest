(function () {
    'use strict';

    angular
        .module('app')
        .controller('carController', carController);

    carController.$inject = ['$scope', '$location', 'carFactory'];

    function carController($scope, $location, carFactory) {
        /* jshint validthis:true */

        activate();

        $scope.saveNewCar = function () {
            carFactory.saveCar($scope.newCarInfo).then(function (data) {
                $scope.cars.push({
                    Make: data.data.Make,
                    Model: data.data.Model,
                    Year: data.data.Year,
                    Id: data.data.Id
                });
            });


        };

        function activate() {

            carFactory.getData().then(function (data) {
                $scope.cars = data.data;

            });
        }
    }
})();
