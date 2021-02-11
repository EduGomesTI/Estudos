package br.com.fiap.si;

import java.util.Scanner;

public class Matrizes1 
{

	public static void main(String[] args) 
	{
		
		int[][] tempos = new int[10][3];
		int posicaoMenor;
		Scanner sc = new Scanner(System.in);
		
		//looping que rodará 3 vezes, um para cada turma
		for(int it = 0; it < 3; it++)
		{
			System.out.println("Iniciando a turma " + it);
			posicaoMenor = 0;
			//looping que rodará 10 ezes para cada turma
			for(int ia = 0; ia < 10; ia++)
			{
				System.out.println("Informe o tempo do aluno " + ia);
				tempos[ia][it] = sc.nextInt();
				if(tempos[ia][it] < tempos[posicaoMenor][it])
				{
					posicaoMenor = ia;
				}
			}
			System.out.println("O menor tempo lido na turma foi de " + tempos[posicaoMenor][it] + " segundos.");
		}
		sc.close();
	}

}
