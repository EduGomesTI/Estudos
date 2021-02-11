package exercicios;

public class Employee {
	
	private String nome;
	private String sobrenome;
	private double salario;
	
	//Constructor
	public Employee(String nome, String sobrenome, double salario)

	{
		this.nome = nome;
		this.sobrenome = sobrenome;
		
		if (salario > 0)
		{
			this.setSalario(salario);
		}
	}
	
	//Set e Get nome
	public void setNome(String nome)
	{
		this.nome = nome;
	}
	
	public String getNome()
	{
		return nome;
	}
	
	//Set e Get sobrenome
	public void setSobrenome(String sobrenome)
	{
		this.sobrenome = sobrenome;
	}
	
	public String getSobrenome()
	{
		return sobrenome;
	}

	//Set e Get Salario
	public double getSalario() 
	{
		return salario;
	}

	public void setSalario(double salario) 
	{
		if (salario > 0)
		{
			this.setSalario(salario);
		}
	}
}
