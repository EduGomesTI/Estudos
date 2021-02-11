// Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-
// 9. Após isso determine o maior número da matriz e a sua posição
// (linha, coluna).

package exercicios.aula20;

import java.util.Random;

public class Exe01{
    public static void main(String[] args) {

        int m[][] = new int[4][4];
        Random numAleat = new Random();
        int maiorNumero = 0;
        int posLinha = 0;
        int posColuna = 0;

        // Gera os números aleatórios
        System.out.println("Numero - Linha - Coluna");
        for (int i = 0; i < m.length; i++) {
            for (int j = 0; j < m[i].length; j++) {
                m[i][j] = numAleat.nextInt(9);                
                System.out.println((m[i][j]) + " " + (i) + " " +  (j));
            }
        }
        // Guarda o maior número gerado e sua posição
        for (int i = 0; i < m.length; i++) {
            for (int j = 0; j < m[i].length; j++) {
                if (m[i][j] > maiorNumero){
                    maiorNumero = m[i][j];
                    posLinha = i;
                    posColuna = j;
                }
            }
        }

        System.out.println("O maior número gerado foi: " + maiorNumero);
        System.out.println("A posição deste número é: " + posLinha + " " + posColuna);
        
    }
}