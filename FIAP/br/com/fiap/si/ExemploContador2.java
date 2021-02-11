package br.com.fiap.si;

public class ExemploContador2 {

	public static void main(String[] args) {
		
		int cont = 1;
		int soma = 0;
		
		while(cont <=100) {
			
			if(cont % 2 == 0) {
				soma += cont;
			}
			cont++;
		}
		System.out.println("Soma dos números pares = " + soma);
		
	}
}
