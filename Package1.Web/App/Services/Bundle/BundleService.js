(function () {

    /// Service for all things Bundle
    var bundleService = function ($http, ngAuthSettings) {
        var serviceBase = ngAuthSettings.apiServiceBaseUri;
        var pageTitleList = "Bundles Details";
        var indexPageUrl = "#/";

        /// <summary>
        /// Gets the the tabs for the page
        /// </summary>
        var getTabs = function () {
            return [
                { title: "General", url: "App/Views/Bundle/Sections/General.html" },
                { title: "Without Line Rental", url: "App/Views/Bundle/Sections/WithoutLineRental.html" }
    ];
        };

        /// <summary>
        /// Set the bundle
        /// </summary> 
        var setBundle = function ($scope) {

            $http.get(serviceBase + '/bundle/' + $scope.bundleId)
                .success(function (data) {
                    $scope.bundle = data;
                    toastr.success('Bundle details loaded ', "Done");

                })
                .error(function (error, status) {
                    $scope.data.error = { message: error, status: status };
                    console.log($scope.data.error.status);
                });

        };

        return {
            setBundle: setBundle,
            getTabs: getTabs,
            indexPageUrl: indexPageUrl,
            pageTitleList: pageTitleList
        };
    };

    var app = angular.module("Package.View");
    app.factory("bundleService", bundleService);

})();