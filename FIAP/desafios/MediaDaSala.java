package desafios;

import java.util.Scanner;
import java.util.stream.IntStream;

public class MediaDaSala 
{

	public static void main(String[] args) 
	{
		//define as variáveis
		int[] notas = new int[5];
		int media = 0;
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Entre com as notas dos alunos:");
		
		for(int i = 0; i < notas.length; i++)
		{
			//guarda as notas no array
			notas[i] = sc.nextInt();
		}
		
		media = IntStream.of(notas).sum() / notas.length;
		
		if(media < 6)
		{
			System.out.print("A média foi de " + media + ". Precisa conversar!");
		}
		else
		{
			System.out.print("A média foi de " + media + ". Dê os parabéns!");
		}
		
		sc.close();
	}

}
