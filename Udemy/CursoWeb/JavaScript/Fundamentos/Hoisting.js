//Não faz sentido usar isso, é só para conhecimento...
//Hoisting é içar ou jogar a variável para cima.
//Como se fosse assim:
//var a...
console.log('a = ', a)
var a = 2
console.log('a = ', a)

console.log('b = ', b)
let b = 2 //let não permite hoisting, vai dar erro!
console.log('b = ', b)