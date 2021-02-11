package desafios;

import java.util.Scanner;

public class IrmaosHarrei
{
    public static void main(String[] args) 
    {
        //declaração de variáveis
        double [][] poupanca = new double [12][2];
        Scanner sc = new Scanner(System.in);
        double [] media =new double [2];

        System.out.println("Entre com os valores que os irmãos Harrei pouparam em cada mês:");

        //preenchendo as matrizes
        for (int i = 0; i < poupanca[0].length; i++) 
        {
            System.out.println("Digite a poupança do irmão " + (i+1));
            for (int j = 0; j < poupanca.length; j++) 
            {
                System.out.println("Informe o valor da poupança no mês " + (j+1) + ":");
                media[i] = (media[i] + sc.nextDouble()) / 12;
            }
        }
        sc.close();
    }
}
