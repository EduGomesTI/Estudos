/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aula25;

/**
 *
 * @author User
 */
public class Carro {
    
    String marca;
    String modelo;
    int numPassageiros;
    double capCombustivel;
    double consumoCombustivel;
    
    void exibirAutonomia() {
        System.out.println("A autonomia do carro é " + capCombustivel * consumoCombustivel + " km.");
    }
}
