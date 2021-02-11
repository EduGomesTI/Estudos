package capitulo3;

import javax.swing.JOptionPane;

//Classe Account que cont�m uma vari�vel de inst�ncia name
//e m�todos para configurar e obeter seu valor

public class Account {

	private String name; //vari�vel de inst�ncia
	private double balance; //vari�vel de inst�ncia
	
//	Cosntrutor de Account que recebe dois par�metros
	public Account(String name, double balance) //o nome do construtor � o nome da classe
	{
		this.name = name;
		
		//valida que o balance � maior que 0.0; se n�o for,
		//a vari�vel de inst�ncia balance mant�m seu valor inicial padr�o de 0.0
		if (balance > 0.0) //se o saldo for v�lido
			this.balance = balance; //o atribui � vari�vel de inst�ncia balance
	}
	
	//m�todo que deposita apenas uma quantia v�lida no saldo
	public void deposit(double depositAmount)
	{
		if (depositAmount > 0.0) //se depoistAmount for v�lido
			balance = balance + depositAmount; //o adiciona ao saldo
	}
	
	public void withdraw(double withdrawAmount)
	{
		if (withdrawAmount > balance)
		{
			JOptionPane.showMessageDialog(null, "Valor do d�bito exede o saldo da conta");
			
		} else
		{
			balance = balance - withdrawAmount;
		}
		
	}
	
	//m�todo retorna o saldo da conta
	public double getBalance()
	{
		return balance;
	}
	
	//m�todo para definir o nome do objeto
	public void setName(String name)
	{
		this.name = name; //armazena o nome
	}
	
	//m�todo para recuperar o nome do objeto
	public String getName()
	{
		return name; //retorna valor do nome para o chamador
	}

} //fim da classe Account
