//par nome/valor
const saudacao = 'Opa' //contexto léxico 1

function exec()
{
    const saudacao = 'Faaaaala' //contexto léxico 2
    return saudacao
}

//Objetos são grupos aninhados de pares chaves (ou nomes)/valores
const cliente = {
    nome: 'Pedro',
    idade: 32,
    peso: 90,
    endereco: {
        logradouro: 'Rua Muito legal',
        numero: 123
    }
}

console.log(saudacao)
console.log(exec())
console.log(cliente)