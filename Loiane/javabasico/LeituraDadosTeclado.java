package javabasico;

import java.util.Scanner;

public class LeituraDadosTeclado 
{
    public static void main(String[] args) 
    {
        Scanner scan = new Scanner(System.in);
        
        System.out.println("Digite seu nome completo:");
        String nomeCompleto = scan.nextLine(); //Lê a linha inteira
        System.out.println("Seu nome completo é: " +  nomeCompleto);

        System.out.println("Digite seu primeiro nome:");
        String primeiroNome = scan.next(); //Lê apenas a primeira string
        System.out.println("Seu primeiro nome é: " +  primeiroNome);

        scan.close();
    }
}