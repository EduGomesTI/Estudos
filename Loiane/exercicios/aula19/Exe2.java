// Criar um vetor A com 8 elementos inteiros. Construir um vetor B de
// mesmo tipo e tamanho e com os elementos do vetor A multiplicados
// por 2, ou seja: B[i] = A[i] * 2.

package exercicios.aula19;

public class Exe2{

    public static void main(String[] args) {
        
        int[] a = new int[8];
        int[] b = new int[8];

        for (int i = 0; i < a.length; i++) {
            
            a[i] = (i + 1);
            b[i] = a[i] * 2;
            System.out.println(a[i] + " " + b[i]);
        }
    }
}