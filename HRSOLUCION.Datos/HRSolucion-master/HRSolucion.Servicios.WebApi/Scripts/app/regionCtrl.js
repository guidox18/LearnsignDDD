//create angularjs controller
var app = angular.module('app', []);//set and get the angular module
app.controller('regionController', ['$scope', '$http', regionController]);

//angularjs controller method
function regionController($scope, $http) {

    //declare variable for mainain ajax load and entry or edit mode
    $scope.loading = true;
    $scope.addMode = false;

    //get all customer information
    $http.get('/regiones/').success(function (data) {
        $scope.regiones = data;
        $scope.loading = false;
    })
    .error(function () {
        $scope.error = "An Error has occured while loading posts!";
        $scope.loading = false;
    });

    ////by pressing toggleEdit button ng-click in html, this method will be hit
    //$scope.toggleEdit = function () {
    //    this.customer.editMode = !this.customer.editMode;
    //};

    //by pressing toggleAdd button ng-click in html, this method will be hit
    $scope.toggleAdd = function () {
        $scope.addMode = !$scope.addMode;
    };

    //Inser Customer
    $scope.add = function () {
        $scope.loading = true;
        $http.post('/regiones/', this.nuevaregion).success(function (data) {
            alert("Añadido Correctmente!!!");
            $scope.addMode = false;
            $scope.customers.push(data);
            $scope.loading = false;
        }).error(function (data) {
            $scope.error = "Un error ocurrio mientras se añadía la región! " + data;
            $scope.loading = false;
        });
    };

    ////Edit Customer
    //$scope.save = function () {
    //    alert("Edit");
    //    $scope.loading = true;
    //    var frien = this.customer;
    //    alert(frien);
    //    $http.put('/api/Customer/' + frien.Id, frien).success(function (data) {
    //        alert("Saved Successfully!!");
    //        frien.editMode = false;
    //        $scope.loading = false;
    //    }).error(function (data) {
    //        $scope.error = "An Error has occured while Saving customer! " + data;
    //        $scope.loading = false;
    //    });
    //};

    ////Delete Customer
    //$scope.deletecustomer = function () {
    //    $scope.loading = true;
    //    var Id = this.customer.Id;
    //    $http.delete('/api/Customer/' + Id).success(function (data) {
    //        alert("Deleted Successfully!!");
    //        $.each($scope.customers, function (i) {
    //            if ($scope.customers[i].Id === Id) {
    //                $scope.customers.splice(i, 1);
    //                return false;
    //            }
    //        });
    //        $scope.loading = false;
    //    }).error(function (data) {
    //        $scope.error = "An Error has occured while Saving Customer! " + data;
    //        $scope.loading = false;
    //    });
    //};

}