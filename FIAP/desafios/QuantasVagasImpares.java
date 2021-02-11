package desafios;

import java.util.Scanner;

public class QuantasVagasImpares
{
    public static void main(String[] args) 
    {
        int[] vagas = new int[20];
        int vagasImpares = 0;
        int vagasPares = 0;
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite o número das vagas com problemas: ");
        //guarda as notas no array
        for (int i = 0; i < vagas.length; i++) 
        {
            vagas[i] = sc.nextInt();
        }
        //se o número da vaga for ímpar adiciona 1 para vagasImpares,
        //senão adiciona 1 para vagasPares
        for (int i = 0; i < vagas.length; i++) 
        {
            if ((vagas[i] % 2) == 1) 
            {
                vagasImpares ++;
            }
            else
            {
                vagasPares ++;
            }
        }
        //verifica se a quantidade de vagas ímpares é maior ou menor que
        //as vagas pares.
        if (vagasImpares > vagasPares) 
        {
            System.out.print("Existem mais vagas ímpares");
        } else if (vagasImpares < vagasPares) 
        {
            System.out.print("Existem mais vagas pares"); 
        }
        else
        {
            System.out.print("O número de vagas ímpares é igual ao de pares.");
        }
        sc.close();
    }        
}