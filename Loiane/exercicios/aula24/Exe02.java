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
public class Exe02 {
    
    public static void main(String[] args) {
        
        Livro livro = new Livro();
        
        livro.nome = "Mastering ExtJS";
        livro.autor = "Loiane Groner";
        livro.anoLancamento = 2015;
        
        System.out.println("Nome do livro = " + livro.nome);
    }
}
