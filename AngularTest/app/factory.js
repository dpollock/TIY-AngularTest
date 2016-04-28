(function () {
    'use strict';

    angular
        .module('app')
        .factory('carFactory', factory);

    factory.$inject = ['$http'];

    function factory($http) {
        var service = {
            getData: getData,
            saveCar: saveCar
        };

        return service;

        function getData() {
            return $http.get('/home/getallcars');
        }

        function saveCar(carInfo) {
            return $http.post('/home/savecar', carInfo);
        }

    }
})();