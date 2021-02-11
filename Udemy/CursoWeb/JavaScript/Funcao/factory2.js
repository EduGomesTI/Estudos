function criarProduto(nome, preco){
    return{
        nome,
        preco,
        desconto: 0.1
    }
}

console.log(criarProduto('Celular', 100))
console.log(criarProduto('Tablet', 200))