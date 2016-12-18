
(function (angular) {
    function mapController($http) {
        $http.get('../API/Map').then(function (response) {
            console.log(response);
        });
        this.model = { value: ':)' };
    }

    angular.module('AngleMaps').controller('MapController', mapController);
})
(angular)