let Index = {
    CarregarClientes: function () {
        let tabela = document.querySelector("#tableBody");
        tabela.innerHTML = `
            <tr>
                <td colspan="6" rowspan="6">
                    <?xml version="1.0" encoding="utf-8"?>
                        <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="margin: auto; background: none; display: block; shape-rendering: auto;" width="404px" height="404px" viewBox="0 0 100 100" preserveAspectRatio="xMidYMid">
                        <rect x="19" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.125s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.25s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.875s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.375s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.75s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.625s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.5s" calcMode="discrete"></animate>
                        </rect>
                        <!-- [ldio] generated by https://loading.io/ --></svg>
                </td>

            </tr>
        `;
        HTTPClient.get("/Cliente/BuscarClientes?query=")
            .then(
                function (retornoServidor) {
                    return retornoServidor.json()
                }
            )
            .then(
                function (obj) {
                    Index.CarregarTabela(obj);
                }
            )
            .catch(
                function () {
                    alert("Deu erro no HTTPClient");
                }
            )
            .finally(
                function () {
                }
            )
    },
    PesquisarClientesPorNome: function () {
        let tabela = document.querySelector("#tableBody");
        tabela.innerHTML = `
            <tr>
                <td colspan="6" rowspan="6">
                    <?xml version="1.0" encoding="utf-8"?>
                        <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="margin: auto; background: none; display: block; shape-rendering: auto;" width="404px" height="404px" viewBox="0 0 100 100" preserveAspectRatio="xMidYMid">
                        <rect x="19" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.125s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.25s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.875s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.375s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.75s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.625s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.5s" calcMode="discrete"></animate>
                        </rect>
                        <!-- [ldio] generated by https://loading.io/ --></svg>
                </td>

            </tr>
        `;
        var query = document.querySelector("#inpNome").value;


        HTTPClient.get("/Cliente/PesquisarClientesPorNome?nome=" + query)
            .then(
                function (retornoServidor) {

                    return retornoServidor.json()
                }
            )
            .then(
                function (obj) {

                    Index.CarregarTabela(obj);
                }
            )
            .catch(
                function () {
                    alert("Deu erro no HTTPClient");
                }
            )
            .finally(
                function () {
                }
            )
    },
    PesquisarClientesPorCPF: function () {
        let tabela = document.querySelector("#tableBody");
        tabela.innerHTML = `
            <tr>
                <td colspan="6" rowspan="6">
                    <?xml version="1.0" encoding="utf-8"?>
                        <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="margin: auto; background: none; display: block; shape-rendering: auto;" width="404px" height="404px" viewBox="0 0 100 100" preserveAspectRatio="xMidYMid">
                        <rect x="19" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.125s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.25s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.875s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.375s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.75s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.625s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.5s" calcMode="discrete"></animate>
                        </rect>
                        <!-- [ldio] generated by https://loading.io/ --></svg>
                </td>

            </tr>
        `;
        var query = document.querySelector("#inpCPF").value;


        HTTPClient.get("/Cliente/PesquisarClientesPorCPF?cpf=" + query)
            .then(
                function (retornoServidor) {
                    return retornoServidor.json()
                }
            )
            .then(
                function (obj) {

                    Index.CarregarTabela(obj);
                }
            )
            .catch(
                function () {
                    alert("Deu erro no HTTPClient");
                }
            )
            .finally(
                function () {
                }
            )
    },
    PesquisarClientesPorTelefone: function () {
        let tabela = document.querySelector("#tableBody");
        tabela.innerHTML = `
            <tr>
                <td colspan="6" rowspan="6">
                    <?xml version="1.0" encoding="utf-8"?>
                        <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="margin: auto; background: none; display: block; shape-rendering: auto;" width="404px" height="404px" viewBox="0 0 100 100" preserveAspectRatio="xMidYMid">
                        <rect x="19" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.125s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.25s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.875s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.375s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.75s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.625s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.5s" calcMode="discrete"></animate>
                        </rect>
                        <!-- [ldio] generated by https://loading.io/ --></svg>
                </td>

            </tr>
        `;
        var query = document.querySelector("#inpTelefone").value;


        HTTPClient.get("/Cliente/PesquisarClientesPorTelefone?telefone=" + query)
            .then(
                function (retornoServidor) {
                    return retornoServidor.json()
                }
            )
            .then(
                function (obj) {

                    Index.CarregarTabela(obj);
                }
            )
            .catch(
                function () {
                    alert("Deu erro no HTTPClient");
                }
            )
            .finally(
                function () {
                }
            )
    },
    ExcluirClientes: function (codigo) {
        let tabela = document.querySelector("#tableBody");
        tabela.innerHTML = `
            <tr>
                <td colspan="6" rowspan="6">
                    <?xml version="1.0" encoding="utf-8"?>
                        <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="margin: auto; background: none; display: block; shape-rendering: auto;" width="404px" height="404px" viewBox="0 0 100 100" preserveAspectRatio="xMidYMid">
                        <rect x="19" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.125s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="19" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.25s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.875s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="40" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.375s" calcMode="discrete"></animate>
                        </rect><rect x="19" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.75s" calcMode="discrete"></animate>
                        </rect><rect x="40" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.625s" calcMode="discrete"></animate>
                        </rect><rect x="61" y="61" width="20" height="20" fill="#93dbe9">
                          <animate attributeName="fill" values="#689cc5;#93dbe9;#93dbe9" keyTimes="0;0.125;1" dur="1s" repeatCount="indefinite" begin="0.5s" calcMode="discrete"></animate>
                        </rect>
                        <!-- [ldio] generated by https://loading.io/ --></svg>
                </td>

            </tr>
        `;
        var dados = {
            codigo : codigo    
        }

        HTTPClient.get("/Cliente/ExcluirClienteFisico", dados)
            .then(
                function (retornoServidor) {
                    return retornoServidor.json()
                }
            )
            .then(
                function (obj) {

                    Index.CarregarTabela(obj);
                }
            )
            .catch(
                function () {
                    alert("Deu erro no HTTPClient");
                }
            )
            .finally(
                function () {
                }
            )
    },
    CarregarTabela: function (dados) {
        let tabela = document.querySelector("#tableBody");

        tabela.innerHTML = "";

        let linhas = "";

        dados.forEach((dado) => {
            
            linhas +=
                `<tr>
                    <td>${dado.codigo}</td >
                    <td>${dado.nome}</td>
                    <td>${dado.cpf}</td>
                    <td>${dado.email}</td>
                    <td>${dado.telefone}</td>
                    <td>${(dado.fiado == '1' ? "Sim":"Não")}</td>
                    <td>
                        <button class="btn btn-outline-warning" onclick="${dado.codigo}">
                            Editar
                                </button>
                        <button class="btn btn-outline-danger"  onclick="Index.ExcluirClientes(${dado.codigo})">
                            Excluir
                                </button>
                        <button class="btn btn-outline-info"  onclick="Index.VerMais(${dado.codigo})">
                            Ver +
                                </button>
                    </td>
                </tr>`
        }
        )
        tabela.innerHTML = linhas;
    },
    VerMais: function (codigo) {
        IndexInterface.codigo = codigo;

        window.location.href = "~/Cliente/Editar";
    }
    
}

let IndexConfig = {
    CarregarNome: function () {
        var TituloPagina = document.querySelector("#TituloPagina");
        var CaminhoPagina = document.querySelector("#CaminhoPagina");

        TituloPagina.innerHTML = 'Gerenciar Clientes';
        CaminhoPagina.innerHTML = `
            <li class="breadcrumb-item"><a href="/Home">Inicio</a></li>
            <li class="breadcrumb-item">Cliente</a></li>
        `;

    },
    opNome: function () {
        var opNome = document.querySelector('#BuscarNome');
        var opCPF = document.querySelector('#BuscarCPF');
        var opTelefone = document.querySelector('#BuscarTelefone');
        opCPF.value = '';
        opTelefone.value = '';
        opCPF.classList.remove('show');
        opTelefone.classList.remove('show');
    },
    opCPF: function () {
        var opNome = document.querySelector('#BuscarNome');
        var opCPF = document.querySelector('#BuscarCPF');
        var opTelefone = document.querySelector('#BuscarTelefone');
        opNome.value = '';
        opTelefone.value = '';
        opNome.classList.remove('show');
        opTelefone.classList.remove('show');
    },
    opTelefone: function () {
        var opNome = document.querySelector('#BuscarNome');
        var opCPF = document.querySelector('#BuscarCPF');
        var opTelefone = document.querySelector('#BuscarTelefone');
        opCPF.value = '';
        opNome.value = '';
        opCPF.classList.remove('show');
        opNome.classList.remove('show');
    }
}

IndexConfig.CarregarNome();
Index.CarregarClientes();
