// Criar um vetor A com 10 elementos inteiros. Implementar um programa
// que determine a soma dos elementos armazenados neste vetor que
// são múltiplos de 5.

package exercicios.aula19;

public class Exe13{
    public static void main(String[] args) {
        int[] a = new int[10];
        int soma = 0;

        for (int i = 0; i < a.length; i++) {
            a[i] = i * 5;
            System.out.println(a[i]);
            if (a[i] % 5 == 0){
                soma = soma + a[i];
            }
        }
        System.out.println("A soma dos múltipos de 5 é: " + soma);
    }
}