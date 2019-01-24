//mapear todos os serviços relacionados a cliente 
//$http -> objeto do angular para realizar chamadas HTTP
app.service('$salaService', function ($http) { 

    //variavel..         
    var urlBase = "http://localhost:58901/api/sala"; 

    //criando uma variavel JSON para declarar as funções         
    //que irão acessar os serviços..         
    var services = {}; //vazio..

    //função para executar o serviço de cadastro (POST)..         
    services.cadastrar = function (model) {
        return $http.post(urlBase + "/cadastrar", model);
    }; 

    //função para executar o serviço de edição (PUT)..         
    services.atualizar = function (model) {
        return $http.put(urlBase + "/atualizar", model);
    }; 

    //função para executar o serviço de edição (DELETE)..         
    services.excluir = function (id) {
        return $http.delete(urlBase + "/excluir?id=" + id);
    }; 

    //função para executar o serviço de consulta (GET)..         
    services.consultar = function () {
        return $http.get(urlBase + "/consultar");
    }; 

    //função para executar o serviço de obter por id (GET)..         
    services.obter = function (id) {
        return $http.get(urlBase + "/obter?id=" + id);
    }; 

    //retornando..         
    return services;
}); 