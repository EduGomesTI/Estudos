/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicios.aulas25a27;

import java.util.Scanner;

/**
 *
 * @author User
 */
public class JogoDaVelha {
    
    char[][] jogoVelha = new char[3][3];
    int jogada;
    char sinal;
    int linha;
    int coluna;
    boolean ganhou;
    Scanner scan = new Scanner(System.in);
    
    void linhaValida(){
        boolean lValida = false;
        while (lValida == false) {
                System.out.println("Entre com a linha (1, 2 ou 3)");
                linha = scan.nextInt();
                if (linha >= 1 && linha <= 3){
                    lValida = true;
                    
                } else {
                    System.out.println("Entrada inválida, tente novamente.");
                }
                
            }
    }
    
    void colunaValida() {
        boolean cValida = false;
        while (cValida == false) {
                System.out.println("Entre com a coluna (1, 2 ou 3");
                coluna = scan.nextInt();
                if (coluna >= 1 && coluna <= 3){
                    cValida = true;
                } else {
                    System.out.println("Entrada inválida, tente novamente.");
                }
                
            }
    }
    
}
