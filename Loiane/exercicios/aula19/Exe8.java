// Criar dois vetores A e B cada um com 10 elementos inteiros. Construir
// um vetor C, onde cada elemento de C é a multiplicação dos
// respectivos elementos em A e B, ou seja:
// C[i] = A[i] * B[i].

package exercicios.aula19;

public class Exe8{
    public static void main(String[] args) {
        int[] a = new int[10];
        int[] b = new int[10];
        int[] c = new int[10];

        for (int i = 0; i < a.length; i++) {
            a[i] = (i + 1);
            b[i] = a[i] * i;
            c[i] = a[i] * b[i];

            System.out.println(a[i] + " " + b[i] + " " + c[i]);
        } 
    }
}