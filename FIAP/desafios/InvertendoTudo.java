package desafios;

import java.util.Scanner;

public class InvertendoTudo
{
    public static void main(String[] args) {
        
        int[] vetorA = new int[10];
        int[] vetorB = new int[10];
        Scanner sc = new Scanner(System.in);

        System.out.print("Digite 10 números diferentes: ");

        for (int i = 0; i < vetorA.length; i++) {
            vetorA[i] = sc.nextInt();
            vetorB[9-i] = vetorA[i];
        }
        //mostra os vetores
        for (int i = 0; i < vetorA.length; i++) 
        {
            System.out.println(vetorA[i] + " - " + vetorB[i]);    
        }
        sc.close();
    }
}