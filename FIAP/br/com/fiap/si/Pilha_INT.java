/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.fiap.si;

import java.util.*;

/**
 *
 * @author Eduardo
 */
public class Pilha_INT {
    
//    Definição do NO
    private static class NO{
        public int dado;
        public NO prox;
    }
    
//Definição do retorno dos métodos POP e TOP
    private static class Retorno{
        public int item;
        public boolean ok;
    }
    
//    Definição do ponteiro topo da pilha
    private static NO topo;
    
    public void INIT(){
        topo = null;
    }
    
    public boolean IsEmpty(){
        return topo == null;
    }
    
    public void PUSH(int item){
        NO novo = new NO();
        novo.dado = item;
        novo.prox = topo;
        topo = novo;
    }
    
    public Retorno POP(){
        Retorno saida = new Retorno();
        if(!IsEmpty()){
            saida.item = topo.dado;
            topo = topo.prox;
            saida.ok = true;
        }
        else
            saida.ok = false;
        return saida;
    }
    
    public Retorno TOP(){
        Retorno saida = new Retorno();
        if(!IsEmpty()){
            saida.item = topo.dado;
            saida.ok = true;
        }
        else
            saida.ok = false;
        return saida;
        
    }
    
//    Função main que exemplifica a utilização de operações sobre pilha
    public static void main(String[] args) {
        
        Pilha_INT s = new Pilha_INT();
        Scanner entrada = new Scanner(System.in);

    //        Declaração de variáveis necessárias par usar métodos da Pilha_INT
        int item;
        int opcao;
        Retorno res = new Retorno();

    //    Inicia a pilha fazendo topo = null
        s.INIT();

    //    Invoca metodo TOP para obter dados do nó do topo da pilha
        res = s.TOP();
        if (res.ok)
            System.out.println("Execução do TOP: " + res.item);
        else
            System.out.println("Execução do TOP: pilha VAZIA");

    //    Repetição para inserir elementos na pilha
        do {
            System.out.println("Digite valor inteiro para dado ");
            item = entrada.nextInt();
            s.PUSH(item);
            System.out.println("Digite 0 para encerrar empilhamento de dados ");
            opcao = entrada.nextInt();        
        } while (opcao != 0);

    //    Invoca metodo TOP para obter dados do nó do topo da pilha
        res = s.TOP();
        if (res.ok)
            System.out.println("Execução do TOP: " + res.item);

    //    repetição para retirar e apresentar todos elementos da pilha
        do {
            res = s.POP();
            if (res.ok)
                System.out.println("Dados retirado: " + res.item);
        } while (res.ok);
        entrada.close();
    }
    
}
