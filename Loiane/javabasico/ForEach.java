/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javabasico;

import java.util.Random;

/**
 *
 * @author Eduardo
 */
public class ForEach {
    
    public static void main(String[] args) {
        
        int[] notas = new int[10];
                
        Random random = new Random();
                
        for (int i = 0; i < notas.length; i++) {
            notas[i] = random.nextInt(10);            
        }
        for (int i = 0; i < notas.length; i++) {
            System.out.println(notas[i]);
            
        }
        System.out.println("Usando For Each");
        
        for(int nota : notas){
            System.out.println(nota);
        }
        
        //exemplo 2
        
    }
}
