package br.com.fiap.si;

import java.util.Scanner;

public class SomaDeNumeros {
	
	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
	
		System.out.print("Digite o primeiro n�mero: ");
		int numero1 = sc.nextInt();
		System.out.print("Digite o segundo n�mero: ");
		int numero2 = sc.nextInt();
		
		int soma = numero1 +numero2;
		System.out.println("A soma � " + soma);
		
		int resto = soma % 2;
		if (resto == 0) {
			//Se resto for = 0
			System.out.println("A soma � par.");
		} else {
			//Se resto for diferente de 0
			System.out.println("A soma � impar.");
		}
		
		sc.close();
	}
	
}
