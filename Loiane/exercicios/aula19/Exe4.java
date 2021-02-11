// Criar um vetor A com 15 elementos inteiros. Construir um vetor B de
// mesmo tamanho, sendo que cada elemento do vetor B deverá ser a
// raiz quadrada do respectivo elemento de A, ou seja:
// B[i] = sqrt(A[i]).

package exercicios.aula19;

import java.lang.Math;

public class Exe4{

    public static void main(String[] args) {
        
        int[] a = new int[15];
        double[] b = new double[15];

        for (int i = 0; i < a.length; i++) {
            
            a[i] = (i + 1);
            b[i] = Math.sqrt(a[i]);

            System.out.println(a[i] + " " + b[i]);
        }
    }
}