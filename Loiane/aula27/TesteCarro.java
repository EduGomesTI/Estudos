/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aula27;

/**
 *
 * @author User
 */
public class TesteCarro {
    
    public static void main(String[] args) {
        
        Carro van = new Carro();
        van.marca = "Fiat";
        van.modelo = "Ducato";
        van.numPassageiros = 10;
        van.capCombustivel = 100;
        van.consumoCombustivel = 0.2;
        
        System.out.println(van.marca);
        System.out.println(van.modelo);
        System.out.println(van.numPassageiros);
        System.out.println(van.capCombustivel);
        System.out.println(van.consumoCombustivel);
        
        van.exibirAutonomia();
        
        double autonomia = van.obterAutonomia();
        System.out.println("A autonomia do carro é: " + autonomia);
        
        double qtdeCombustivel10 = van.calcuarCombustivel(10);
        double qtdeCombustivel15 = van.calcuarCombustivel(15);
        
        System.out.println("qtdCombustivel10 = " + qtdeCombustivel10);
        System.out.println("qtdCombustivel15 = " + qtdeCombustivel15);
    }
    
}
