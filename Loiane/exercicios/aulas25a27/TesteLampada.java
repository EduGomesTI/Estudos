/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicios.aulas25a27;

/**
 *
 * @author User
 */
public class TesteLampada {
    
    public static void main(String[] args){
        
        Lampada lampada = new Lampada();
        
        lampada.mudarEstado();
        
        lampada.mostrarEstado();
        
        lampada.mudarEstado();
        
        lampada.mostrarEstado();
    }
}
