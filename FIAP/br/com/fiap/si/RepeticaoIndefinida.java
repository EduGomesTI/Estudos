package br.com.fiap.si;

import java.util.Scanner;

public class RepeticaoIndefinida {
	
	public static void main(String[] args) {
		
		Scanner entrada = new Scanner(System.in);
		
		int valor = 0;
		int soma = 0;
		
		while(valor >= 0) {
			System.out.println("Informe um valor ");
			valor = entrada.nextInt();
			if(valor > 0) {
				soma = soma + valor;
			}			
		}
		System.out.println("Soma dos valores positivos -> " + soma);
		entrada.close();
	}

}
