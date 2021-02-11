// Criar um vetor A com 5 elementos inteiros. Construir um vetor B de
// mesmo tipo e tamanho e com os "mesmos" elementos do vetor A, ou
// seja, B[i] = A[i].

package exercicios.aula19;

public class Exe1 
{
    public static void main(String[] args) {
        
        int[] A = new int[5];
        int[] B = new int[5];
        
        for (int i = 0; i < A.length; i++){

            A[i] = i;
            B[i] = A[i];
            System.out.println(A[i] + " " + B[i]);
        }
        
    }
}