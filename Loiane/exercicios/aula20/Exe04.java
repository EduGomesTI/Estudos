/* Faça um programa para armazenar em uma matriz os
compromissos de uma agenda pessoal. Cada dia do mês deve
conter 24 horas, onde para cada uma destas 24 horas podemos
associar um tarefa específica (compromisso agendado). O
programa deve ter um menu onde o usuário indica o dia do mês
que deseja alterar e a hora, entrando em seguida com o
compromisso, ou então, o usuário pode também consultar a
agenda, fornecendo o dia e a hora para obter o
compromisso armazenado. */

package exercicios.aula20;

import java.util.Scanner;

public class Exe04{

    public static void main(String[] args) {
        
        String[][] agenda = new String[30][24];
        Scanner input = new Scanner(System.in);
        int dia = 0;
        int hora = 0;
        int opcao = 0;

        //Menu
        System.out.println("******* Menu de opções da Agenda *********");
        System.out.println("1 - Adicionar compromisso");
        System.out.println("2 - Consultar compromisso");
        System.out.println("3 - Sair");
        System.out.println(" ");
        System.out.print("Escolha uma das opções acima: ");
        opcao = input.nextInt();

        while (opcao != 3) {
            if (opcao == 1){
                //Adicionar compromisso
                System.out.println("Entre com o dia do mês:");
                dia = input.nextInt();
                System.out.println("Entre com a hora do compromisso:");
                hora = input.nextInt();
                System.out.println("Entre com o compromisso:");
                agenda[--dia][hora] = input.next();
            } 
            if (opcao == 2){
                //Mostra compromisso
                System.out.print("Escolha o dia a ser consultado: ");
                dia = input.nextInt();
                System.out.print("Escolha a hora a ser consultada: ");
                hora = input.nextInt();
                System.out.println("O compromisso agendado para o dia " + dia + " e a hora " + hora + " é " + agenda[--dia][hora]);
            }
        }

        


        input.close();
        
    }
    
}