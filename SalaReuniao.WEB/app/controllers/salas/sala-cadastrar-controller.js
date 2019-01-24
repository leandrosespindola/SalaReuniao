app.controller('salaCadastrarController',
    function ($scope, $salaService) {

        $scope.sala = {};

        $scope.cadastrar = function () {
            $scope.mensagem = "Enviando requisição.";

            $salaService.cadastrar($scope.sala)
                .then(function () {
                    $scope.mensagem = "Sala cadastrada com sucesso.";
                    $scope.sala = {};
                })
                .catch(function (e) {
                    $scope.mensagem = e.data;
                });


            //$scope.mensagem = JSON.stringify($scope.sala);
        };

});