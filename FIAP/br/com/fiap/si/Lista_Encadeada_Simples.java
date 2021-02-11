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
public class Lista_Encadeada_Simples {
    private static class NO{
        public int dado;
        public NO prox;
    }
    
    public static void main(String[] args){
    NO lista = null;
    System.out.println("Valor ponteiro lista = " + lista);
        
    NO novo = new NO();
    novo.dado = 5;
    novo.prox = lista;
    lista = novo;
    
        System.out.println("Atributos do nó apontado pro lista = " + lista.dado +
                " " + lista.prox);
    }
}

