// Criar um vetor A com 10 elementos inteiros. Implementar um programa
// que defina e escreva a quantidade de elementos armazenados neste
// vetor que são pares.

package exercicios.aula19;

public class Exe11{
    public static void main(String[] args) {
        int[] a = new int[10];
        int par = 0;


        for (int i = 0; i < a.length; i++) {
            a[i] = (i+1) * 2;
            if (a[i] % 2 == 0){
                par++;
            }
        }
        System.out.print("Existem " + par + " números pares");
    }
}