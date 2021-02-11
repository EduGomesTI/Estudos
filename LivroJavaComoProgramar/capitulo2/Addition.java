package capitulo2;

//Figura 2.7

import java.util.Scanner;


public class Addition {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		int number1;
		int number2;
		int sum;
		
		System.out.print("Enter fisrt integer:");
		number1 = input.nextInt();
		
		System.out.print("Enter second integer");
		number2 = input.nextInt();
		
		sum = number1 + number2;
		
		System.out.printf("Sum is %d%n", sum);

		input.close();
	}

}
