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
public class Lampada {
    
    String modelo;
    String tensao;
    int potencia;
    String cor;
    String tipoLuz;
    int garantiaMeses;
    String[] tipos;
    boolean tipoAbajur;
    boolean ligada;
    
    void ligar() {
        ligada = true;
    }
    
    void desligar() {
        ligada = false;
    }
    
    void mostrarEstado() {
        if(ligada){
        System.out.println("Lampada está ligada");
    } else {
        System.out.println("Lampada está desligada");              
        }
    }
    
    void mudarEstado(){
        if(ligada){
            desligar();
        } else {
            ligar();
        }
    }
    
}
