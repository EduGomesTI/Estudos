// Criar um vetor A com 10 elementos inteiros. Desenvolver um programa
// que defina o percentual de elementos pares e ímpares,
// respectivamente, armazenados neste vetor.

package exercicios.aula19;

public class Exe15{
    public static void main(String[] args) {
        int[] a = new int[10];
        double pares = 0.0;
        double impares = 0.0;

        for (int i = 0; i < a.length; i++) {
            a[i] = i * 15;
            if (a[i] % 2 == 0){
                pares++;
            } else {
                impares++;
            }
        }
        pares = pares * 10;
        impares = impares * 10;
        System.out.println("Pares: " + pares + " " + "Impares: " + impares);
    }
}