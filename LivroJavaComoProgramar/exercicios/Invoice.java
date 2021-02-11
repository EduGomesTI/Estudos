package exercicios;

public class Invoice {

	private String numero;
	private String descricao;
	private int qtde;
	private double preco;
	private double total;
	
	//Constructor
	public Invoice(String aNumero, String aDescricao, int aQtde, double aPreco)
	{
		this.numero = aNumero;
		
		this.descricao = aDescricao;
		
		if (aQtde < 1)
		{
			this.qtde = 0;
		} 
		else
		{
			this.qtde = aQtde;
		}
		
		if (aPreco < 0)
		{
			this.preco = 0.0;
		} 
		else
		{
			this.preco = aPreco;
		}
	}
	
	//Set e Get do número
	public void setNumero(String aNumero)
	{
		this.numero = aNumero;
	}
	
	public String getNumero()
	{
		return numero;
	}
	
	//Set e Get da descrição
	public void setDescricao(String aDescricao)
	{
		this.descricao = aDescricao;
	}
	
	public String getDescricao()
	{
		return descricao;
	}
	
	//Set e Get da quantidade
	public void setQtde(int aQtde)
	{
		if (aQtde < 1)
		{
			this.qtde = 0;
		}
		else
		{
			this.qtde = aQtde;
		}
	}
	
	public int getQtde()
	{
		return qtde;
	}
	
	//Set e Get do preço
	public void setPreco(double aPreco)
	{
		if (aPreco < 0)
		{
			this.preco = 0;
		}
		else
		{
			this.preco = aPreco;
		}
	}
	
	public double getPreco()
	{
		return preco;
	}
	
	//Calcula o preço total
	public double getInvoiceAmount()
	{
		total = qtde * preco;
		return total;
	}


	
}
