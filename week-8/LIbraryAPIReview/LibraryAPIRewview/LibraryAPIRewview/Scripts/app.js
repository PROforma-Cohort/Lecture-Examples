console.log("hello world");


var app = angular.
    module("helloWorldApp", ["ngRoute","customFilters"])

app.config(($routeProvider) => {
    $routeProvider.when("/contact",{
        templateUrl: 'scripts/pages/contact.html',
        controller: 'contact'
    }).when("/home", {
        templateUrl: 'scripts/pages/main.html',
        controller: 'mainController'
    })
})

