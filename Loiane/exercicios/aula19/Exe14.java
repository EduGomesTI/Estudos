// Criar um vetor A com 10 elementos inteiros. Implementar um programa
// que defina e escreva a média aritmética simples dos elementos
// ímpares armazenados neste vetor.

package exercicios.aula19;

public class Exe14{
    public static void main(String[] args) {
        int[] a = new int[10];
        int impar = 0;
        double media = 0;
    
        for (int i = 0; i < a.length; i++) {
            a[i] = i * 3;
            if (a[i] % 2 == 1){
                impar++;
                media = media + a[i];
                System.out.println(impar + " " + a[i] + " " + media);
            }
        }
        media = (double) media / impar;
        System.out.print(media);
    }
    
}