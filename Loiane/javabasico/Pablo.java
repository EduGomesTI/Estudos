/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
//Perguntar 2 númeoros para o usuário
package javabasico;

import java.util.Scanner;

/**
 *
 * @author User
 */
public class Pablo {
    
    public static void main(String[] args) {
        int primeiroNumero = 0;
        int segundoNumero = 0;
        int diferenca = 0;
        int i = 0;
        boolean primeiro = true;
        Scanner scan = new Scanner(System.in);    
        
        System.out.println("Entre com o primeiro número");
        primeiroNumero = scan.nextInt();
        System.out.println("Entre com o segundo número");
        segundoNumero = scan.nextInt();
        
        if (primeiroNumero < segundoNumero){
            diferenca = segundoNumero - primeiroNumero;
            primeiro = false;
        } else {
            diferenca = primeiroNumero - segundoNumero;
            primeiro = true;
        }
        
        while (i <= diferenca) {            
            if (primeiro == false){
                System.out.print(segundoNumero + " - ");
                segundoNumero--;
                i++;
            } else {
                System.out.print(primeiroNumero + " - ");
                primeiroNumero--;
                i++;
            }
        }
        scan.close();
    }
}
