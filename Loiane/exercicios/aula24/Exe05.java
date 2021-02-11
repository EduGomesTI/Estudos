/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicios.aula24;

/**
 *
 * @author User
 */
public class Exe05 {
    
    public static void main(String[] args) {
        
    ContaCorrente conta = new ContaCorrente();
    conta.numero = "123456";
    conta.agencia = "1234";
    conta.especial  = true;
    conta.limiteEspecial = 500;
    conta.saldo = 10;
    
    System.out.println("Saldo da Conta: " + conta.saldo);
    }
}
