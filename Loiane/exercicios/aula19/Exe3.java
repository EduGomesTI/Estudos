// Criar um vetor A com 15 elementos inteiros. Construir um vetor B de
// mesmo tipo e tamanho, sendo que cada elemento do vetor B deverá
// ser o quadrado do respectivo elemento de A, ou seja:
// B[i] = A[i] * A[I].

package exercicios.aula19;

public class Exe3{

    public static void main(String[] args) {
        
        int[] a = new int[15];
        int[] b = new int[15];

        for (int i = 0; i < a.length; i++) {
            
            a[i] = (i + 1);
            b[i] = a[i] * a[i];
            System.out.println(a[i] + " " + b[i]);
        }
    }
}