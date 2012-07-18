//function CoursesCtrl($scope, $http) {
//    $http.jsonp('http://localhost:52747//api/course?callback=JSON_CALLBACK').success(function (data) {
//        $scope.clubs = data;
//    }).error(function (data, status, headers, config) {
//        errData = data;
//        errStatus = status;
//        errHeaders = headers;
//        errConfig = config;
//        // called asynchronously if an error occurs8.    
//        // or server returns response with status9.    
//        // code outside of the <200, 400) range10.  
//    });
//}

function CoursesCtrl($scope, $http) {

    $http.get('http://localhost:52747/api/club').success(function (data) {
        $scope.clubs = data;
    }).error(function (data, status, headers, config) {
        errData = data;
        errStatus = status;
        errHeaders = headers;
        errConfig = config;
        // called asynchronously if an error occurs8.    
        // or server returns response with status9.    
        // code outside of the <200, 400) range10.  
    });

    $scope.hideTable = true;

    $scope.change = function () {
        if ($scope.filterQuery.length > 0) {
            $scope.hideTable = false;
        }
        else {
            $scope.hideTable = true;
        }
    };

    $scope.clubClick = function (clubId) {
        var id = clubId;
    }
}