package capitulo4;

import java.util.Scanner;

public class ClassAverage {

	public static void main(String[] args) 
	{
		//cria Scanner para obter entrada a partir da janela de comando
		Scanner input = new Scanner(System.in);
				
		//fase de inicializa��o
		int total = 0;
		int gradeCounter = 0;
		
		//fase de processamento
		//solicita entrada e l� a nota do usu�rio
		System.out.print("Enter grade or -1 to quit: ");
		int grade = input.nextInt();
		
		//faz um loop at� ler o valor de sentinela inserido pelo usu�rio
		while (grade != -1)
		{
			total = total + grade;
			gradeCounter = gradeCounter + 1;
			
			//solicita entrada e l� a pr�xima nota fornecida pelo usu�rio
			System.out.print("Enter grade or -1 to quit");
			grade = input.nextInt();
		}
		
		//fase de t�rmino
		//se usu�rio inseriu pelo menos uma nota...
		if (gradeCounter != 0)
		{
			//usa n�mero com ponto decimal para calcular m�dia das notas
			double average = (double) total / gradeCounter;
			
			//exibe o total e a media (com 2 digitos de precis�o)
			System.out.printf("%nTotal of the %d grade entered is %d%n", gradeCounter, total);
			System.out.printf("Class average is %.2f%n", average);
		}
		else
			System.out.println("No grades were entered");
				
		input.close();
	}

}
