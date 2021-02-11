//Cadeia de protótipos (prototype chain)

const avo = {
    attr1: 'A'
}
const pai = {
    __proto__: avo,
    attr2: 'B'
}
const filho = {
    __proto__: pai,
    attr3: 'C'
}
console.log(filho.attr1)

const carro= {
    velAtual: 0,
    velMax: 200,
    acelerarMais(delta){
        if(this.velAtual + delta <= this.velMax){
            this.velAtual += delta
        }else{
            this.velAtual = this.velMax
        }
    },
    status(){
        return `${this.velAtual}Km/h de ${this.velMax}Km/h`
    }
}

const ferrarri = {
    model: 'F40',
    velMax: 324 //shadowing
}

const volvo = {
    modelo: 'V40',
    status(){
        return `${this.modelo}: ${super.status()}`
    }
}

Object.setPrototypeOf(ferrarri, carro)
Object.setPrototypeOf(volvo, carro)

console.log(ferrarri)
console.log(volvo)

volvo.acelerarMais(100)
console.log(volvo.status())
ferrarri.acelerarMais(300)
console.log(ferrarri.status())