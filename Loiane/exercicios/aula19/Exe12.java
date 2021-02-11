// Criar um vetor A com 10 elementos inteiros. Implementar um programa
// que defina e escreva a soma de todos os elementos armazenados
// neste vetor.

package exercicios.aula19;

public class Exe12{
    public static void main(String[] args) {
        int[] a = new int[10];
        int soma = 0;

        for (int i = 0; i < a.length; i++) {
            a[i] = i + 3;
            soma = soma + a[i];
        }

        System.out.println("A soma dos elementos é: " + soma);

    } 
}