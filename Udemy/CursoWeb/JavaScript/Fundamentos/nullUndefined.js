let valor //não inicializada
console.log(valor) //valor padrão undefined
console.log(typeof valor)

valor = null // ausência de valor, embora esteja definida
console.log(valor)
//console.log(valor.toString()) //Erro!

const produto = {}
console.log(produto.preco)
console.log(produto)

produto.preco = 3.50
console.log(produto)

produto.preco = undefined //evite atribuir undefined
console.log(!!produto.preco)
console.log(produto)
//delete produto.preco
//console.log(preco)


produto.preco = null // sem preço
console.log(!!produto.preco)
console.log(produto)