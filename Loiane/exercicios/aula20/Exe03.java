//Capture do teclado valores para preenchimento de uma matriz M
//3x3. Ap�s a captura imprima a matriz criada e encontre a
//quantidade de n�meros pares, a quantidade de n�meros �mpares.

package exercicios.aula20;

import java.util.Scanner;

public class Exe03 {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		int[][] m = new int[3][3];
		int impar = 0;
		int par = 0;
		
		//Pegar os dados.
		System.out.println("Entre com os valores:");
		for(int i = 0;i < m.length; i++) {
			for(int j = 0;j < m[i].length;j++) {
				System.out.println("�ndice " + i + "-" + j);
				m[i][j] = input.nextInt();
			}
		}
		//Mostra os dados.
		for(int i = 0; i < m.length;i++) {
			for(int j = 0; j < m[i].length; j++) {
				System.out.println("O valor do �ndice " + i + "-" + j + " �: " + m[i][j]);
			}
		}
		//Quantidade de �pares e pares.
		for(int i = 0; i < m.length; i++) {
			for(int j = 0; j < m[i].length; j++) {
				if((m[i][j] % 2) == 0) {
					par++;
				}else {
					impar++;
				}
			}
		}
		System.out.print("Pares = " + par + " / �mpares = " + impar);
		input.close();
	}

}
