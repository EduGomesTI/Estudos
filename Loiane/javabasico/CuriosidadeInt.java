package javabasico;

public class CuriosidadeInt{

    public static void main(String[] args) {
        
        int var1 = 2147483647;

        int var2 = 1;

        System.out.println(var1 + var2);

        //a soma vai dar -2147483648 que é o menor valor do int.
        //Isto acontece porque ele funciona como uma roleta, quando o valor máximo é atingio
        //ele volta para o valor mínimo e vai girando por assim dizer.

    }
}