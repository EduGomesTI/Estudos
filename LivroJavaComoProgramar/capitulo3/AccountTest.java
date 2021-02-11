package capitulo3;

//Figura 3.2: AccountTest.Java
//Cria e manipula um objeto Account.

import java.util.Scanner;

public class AccountTest {

	public static void main(String[] args) {
		
		//cria dois objetos Account
		Account account1 = new Account("Jane Green", 50.00);
		Account account2 = new Account("John Blue", -7.53);
		
		//exibe o saldo incial de cada objeto
		displayAccount(account1);
		displayAccount(account2);
		
		
		//cria um Scanner para obter entrada a partir da janela de comando
		Scanner input = new Scanner(System.in);
		//input.useLocale(Locale.ENGLISH);
		
		System.out.print("Enter deposit amount for account1: ");
		double depositAmount = input.nextDouble();
		System.out.printf("%nadding %.2f to account balance%n%n", depositAmount);
		account1.deposit(depositAmount); //adiciona o saldo de account1
		System.out.print("Enter withdraw amouint for account1: ");
		double withdrawAmount = input.nextDouble();
		System.out.printf("%npulling out %.2f to account balance%n%n", withdrawAmount);
		account1.withdraw(withdrawAmount);
		
		//exibe os saldos
		displayAccount(account1);
		displayAccount(account2);
		
		System.out.print("Enter deposit amount for account2: ");
		depositAmount = input.nextDouble();
		System.out.printf("%nadding %.2f to account balance%n%n", depositAmount);
		account2.deposit(depositAmount); //adiciona o saldo de account2
		System.out.print("Enter withdraw amouint for account2: ");
		withdrawAmount = input.nextDouble();
		System.out.printf("%npulling out %.2f to account balance%n%n", withdrawAmount);
		account2.withdraw(withdrawAmount);
		
		//exibe os saldos
		displayAccount(account1);
		displayAccount(account2);

		input.close();
		
	}
	
	public static void displayAccount(Account accountToDisplay)
	{
		System.out.printf("%s balance: $%.2f %n", accountToDisplay.getName(), accountToDisplay.getBalance());
	}
}
