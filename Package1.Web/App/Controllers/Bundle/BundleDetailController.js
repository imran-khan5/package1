(function () {

    var app = angular.module('Package.View');

    /// Controller for the bundle detail page
    var bundleDetailController = function ($scope, bundleService, $routeParams) {

        // Get the index page url
        $scope.indexPageUrl = bundleService.indexPageUrl;

        $scope.bundleId = $routeParams.bundleId;

        // Get the bundle data
        $scope.setBundle = function () {
            bundleService.setBundle($scope, false);
        };

        $scope.setBundle();

        // Set up the tabs
        $scope.tabs = bundleService.getTabs();

    };

    app.controller('BundleDetailController', ["$scope", "bundleService", "$routeParams", bundleDetailController]);

})();