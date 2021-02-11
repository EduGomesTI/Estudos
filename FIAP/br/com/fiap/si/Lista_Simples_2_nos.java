/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.fiap.si;

/**
 *
 * @author Eduardo
 */
public class Lista_Simples_2_nos {
    
    private static class NO{
        public int dados;
        public NO prox;
    }
    
    public static void main(String[] args) {
        NO lista = null;         
        System.out.println("Valor ponteiro lista = " + lista);
        for (int i = 1; i <= 2; i++) {
            NO novo = new NO();
            novo.dados = i + 4;
            novo.prox = lista;
            lista = novo;            
        }
        System.out.println("Dado do NO apontado por lista = " + lista.dados);
        System.out.println("Dado do NO apontado por prox " + lista.prox.dados);        
    }
}
