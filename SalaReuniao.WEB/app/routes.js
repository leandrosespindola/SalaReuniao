app.config(function ($routeProvider) {

    $routeProvider
        .when('/sala/cadastro',
        {
            templateUrl: '/app/views/salas/cadastro.html',
            controller: 'salaCadastrarController'
        }
        )
        .when('/sala/consulta',
        {
            templateUrl: '/app/views/salas/consulta.html'
        }
        );      
});

app.config(function ($locationProvider) {
    $locationProvider.hashPrefix('');
}); 