//pessoa -> endereço de memória 123 -> {...}
const pessoa = {nome:'Joao'}
pessoa.nome = 'Pedro'
console.log(pessoa)

//pessoa ->  mudou para endereço de memória 456 -> {...}
//pessoa = {nome: 'Ana'}

Object.freeze(pessoa) //trava completamente o obejto
pessoa.nome = 'Maria'
console.log(pessoa.nome)
