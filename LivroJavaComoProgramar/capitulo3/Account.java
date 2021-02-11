package capitulo3;

import javax.swing.JOptionPane;

//Classe Account que contém uma variável de instância name
//e métodos para configurar e obeter seu valor

public class Account {

	private String name; //variável de instância
	private double balance; //variável de instância
	
//	Cosntrutor de Account que recebe dois parâmetros
	public Account(String name, double balance) //o nome do construtor é o nome da classe
	{
		this.name = name;
		
		//valida que o balance é maior que 0.0; se não for,
		//a variável de instância balance mantém seu valor inicial padrão de 0.0
		if (balance > 0.0) //se o saldo for válido
			this.balance = balance; //o atribui à variável de instância balance
	}
	
	//método que deposita apenas uma quantia válida no saldo
	public void deposit(double depositAmount)
	{
		if (depositAmount > 0.0) //se depoistAmount for válido
			balance = balance + depositAmount; //o adiciona ao saldo
	}
	
	public void withdraw(double withdrawAmount)
	{
		if (withdrawAmount > balance)
		{
			JOptionPane.showMessageDialog(null, "Valor do débito exede o saldo da conta");
			
		} else
		{
			balance = balance - withdrawAmount;
		}
		
	}
	
	//método retorna o saldo da conta
	public double getBalance()
	{
		return balance;
	}
	
	//método para definir o nome do objeto
	public void setName(String name)
	{
		this.name = name; //armazena o nome
	}
	
	//método para recuperar o nome do objeto
	public String getName()
	{
		return name; //retorna valor do nome para o chamador
	}

} //fim da classe Account
