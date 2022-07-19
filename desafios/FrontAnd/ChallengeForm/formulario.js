//
document.getElementById('form-cadastro').addEventListener('submit',function (e) {
    e.preventDefault();
});

document.getElementById('tabela-cadastrado').classList.remove('d-none');
    envioTabela();

const termosAceiteElement = document.getElementById('i-termos-aceite')

termosAceiteElement.addEventListener('scroll', () => {
    if (termosAceiteElement.offsetHeight + termosAceiteElement.scrollTop >= termosAceiteElement.scrollHeight) {
        document.getElementById("i-aceite").disabled = false;
    }
})

document.getElementById('nome').addEventListener('keyup', gerarLogin);
document.getElementById('sobrenome').addEventListener('keyup', gerarLogin);

function gerarLogin() {
    const nome = document.getElementById('nome').value;
    const sobrenome = document.getElementById('sobrenome').value;
    const login = nome + '.' + sobrenome;
    document.getElementById('login').value = login.toLowerCase();
}

function pesquisacep() {
    var cep = document.getElementById('i-cep').value.replace(/\D/g, '');

    if (cep != "") {

        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep)) {
            const url = 'https://viacep.com.br/ws/' + cep + '/json/';
            fetch(url)
                .then(response => response.json())
                .then(json => {
                    if (json.logradouro) {
                        document.getElementById('i-endereco').value = json.endereco;
                        document.getElementById('i-bairro').value = json.bairro;
                        document.getElementById('i-cidade').value = json.localidade;
                        document.getElementById('i-estado').value = json.uf;
                        document.getElementById('i-complemento').value = json.complemento;
                    } else {
                        alert("CEP NÃO ENCONTRADO")
                    }
                })
        } else {
            alert("CEP INVÁLIDO")
        }
    }
}

function envioTabela() {
    //Copiando os valores para a tabela
    let html = document.getElementById("nome").innerHTML;
    document.getElementById("i-nome").innerHTML = html;
    //document.getElementById('i-nome').innerHTML = document.getElementById('nome').value;
    document.getElementById('i-sobrenome').innerHTML = document.getElementById('sobrenome').value;
    document.getElementById('i-email').innerHTML = document.getElementById('email').value;
    document.getElementById('i-login').innerHTML = document.getElementById('login').value;
    document.getElementById('i-senha').innerHTML = document.getElementById('senha').value;
    document.getElementById('i-cep').innerHTML = document.getElementById('cep').value;
    document.getElementById('i-endereco').innerHTML = document.getElementById('endereco').value;
    document.getElementById('i-complemento').innerHTML = document.getElementById('complemento').value;
    document.getElementById('i-bairro').innerHTML = document.getElementById('bairro').value;
    document.getElementById('i-cidade').innerHTML = document.getElementById('cidade').value;
    document.getElementById('i-estado').innerHTML = document.getElementById('estado').value;

    document.getElementById('i-perfilgithub').innerHTML = document.getElementById('perfilgithub').value;

    var iAcademia = document.getElementById("academia");
    document.getElementById('i-academia').innerHTML = iAcademia.options[iAcademia.selectedIndex].text;

    var iProfessor = document.getElementById("professor");
    document.getElementById('i-professor').innerHTML = iProfessor.options[iProfessor.selectedIndex].text;

    document.getElementById('i-aceite').innerHTML = document.getElementById('aceite').value == "on" ? 'Sim' : 'Não'
};
