// Gere e imprima uma matriz M 10x10 com valores aleatórios entre
// 0-9. Após isso indique qual é o maior e o menor valor da linha 5 e
// qual é o maior e o menor valor da coluna 7.

package exercicios.aula20;

import java.util.Random;

public class Exe02{

    public static void main(String[] args) {
        
        int[][] m = new int[10][10];
        Random numAleat = new Random();
        int maior5 = 0;
        int menor5 = 100;
        int maior7 = 0;
        int menor7 = 100;
       
        for (int i = 0; i < m.length; i++) {
            for (int j = 0; j < m[i].length; j++) {
                m[i][j] = numAleat.nextInt(100);
            }
        }
        //Maior e menor valor da linha 5.
        System.out.println("Número - linha - coluna");
           for (int i = 0; i < m.length; i++) {
            if (maior5 < m[5][i]){
                maior5 = m[5][i];
            }
            
            if (menor5 > m[5][i]){
                menor5 = m[5][i];
            }
            System.out.println(m[5][i] + "  " + "5" + "  " + i);
        }
        //Maior e menor da coluna 7.
        System.out.println("Número - linha - coluna");
        for (int i = 0; i < m.length; i++) {
            if (m[i][7] > maior7){
                maior7 = m[i][7];
            }
            
            if (m[i][7] < menor7){
                menor7 = m[i][7];
            }
            System.out.println(m[i][7] + "  " + i + "  " + "7");
        }
        System.out.println("O maior e o menor valor da linha 5 são: " + maior5 + " e " + menor5);
        System.out.println("O maior e o menor valor da coluna 7 são: " + maior7 + " e " + menor7);
    }

}