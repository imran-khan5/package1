(function () {
    
    var app = angular.module("Package.View", ["ngRoute", "ui.bootstrap", "ui", "ui.bootstrap.modal"]);

    // configure our routes
    app.config(function ($routeProvider) {

        $routeProvider
            .when("/", {
                templateUrl: "App/Views/Home/Index.html",
                controller: "HomeController"
            })

            ///////////////////////////////////////////////
            //////////// Site Routes
            ///////////////////////////////////////////////

            .when("/bundle/:bundleId", {
                templateUrl: "App/Views/bundle/Detail.html",
                controller: "BundleDetailController"
            })
            .otherwise({ redirectTo: "/" });
    });

    app.constant('ngAuthSettings', {
        apiServiceBaseUri: window.webApiUrl
    });
})();
