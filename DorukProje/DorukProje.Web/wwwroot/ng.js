var app = angular.module("uygulama", []);

app.controller("emirCtrl", function ($scope, $http) {

    $http.get("http://localhost:28859/Deneme/GetDurusListele").then(function (response) {       
            $scope.durusListesi = response.data;
        });

});


app.controller("isEmriCtrl", function ($scope, $http) {

    $http.get("http://localhost:28859/Deneme/GetEmirListele").then(function (response) {
        $scope.isEmriListesi = response.data;
    });

});

app.controller("RaporCtrl", function ($scope, $http) {

    $http.get("http://localhost:28859/Deneme/GetRapor").then(function (response) {
        $scope.RaporListesi = response.data;
    });

});
