package br.com.fiap.si;

import java.util.Scanner;

public class ExemploEntradaDeDados {
	
	public static void main(String[] args) {
		
		double nota1, nota2, media;
		int cont = 1;
		
		Scanner entrada = new Scanner(System.in);
		
		while(cont <= 50) {
			System.out.println("Digite a primeira nota");
			nota1 = entrada.nextDouble();
			System.out.println("Digite a segunda nota");
			nota2 = entrada.nextDouble();
			media = (nota1 + nota2)/2;
			System.out.print("Média do aluno " + cont);
			System.out.println( "= " + media);
			cont++;
		}
		entrada.close();		
	}

}
