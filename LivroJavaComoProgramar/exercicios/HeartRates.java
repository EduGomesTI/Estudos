package exercicios;

//Incompleto

import java.time.LocalDate;
import java.time.Period;

public class HeartRates {
	
	//Varáveis Locais
	private String nome;
	private String sobrenome;
	private int diaNasc;
	private int mesNasc;
	private int anoNasc;
	
	//Construtor
	public HeartRates(String nome, String sobrenome, int diaNasc, int mesNasc, int anoNasc)
	{
		this.nome = nome;
		
		this.sobrenome = sobrenome;		
		
		
		//Verifica se o dia está correto
		if (diaNasc >= 1 && diaNasc <= 31)
		{
			this.diaNasc = diaNasc;
		}
		
		//Verifica se o mês está correto
		if (mesNasc >=1 && mesNasc <=12)
		{
			this.mesNasc = mesNasc;
		}
		
		this.anoNasc = anoNasc;
		
	}
	
	public void setNome(String nome)
	{
		this.nome = nome;
	}
	
	public void setSobrenome(String sobrenome)
	{
		this.sobrenome = sobrenome;
	}
	
	public void setDiaNasc(int diaNasc)
	{
		this.diaNasc = diaNasc;
	}
	
	public void setMesNasc(int mesNasc)
	{
		this.mesNasc = mesNasc;
	}
	
	public void setAnoNasc(int anoNasc)
	{
		this.anoNasc = anoNasc;
	}
	
	public String getNome()
	{
		return nome;
	}
	
	public String getSobrenome()
	{
		return sobrenome;
	}
	
	public int getDiaNasc()
	{
		return anoNasc;
	}
	
	public int getMesNasc()
	{
		return mesNasc;
	}
	
	public int getAnoNasc()
	{
		return anoNasc;
	}
	
	public int getIdade()
	{
		//Variáveis para pegar a data de nascimento, de hoje e a diferença entre elas.
		LocalDate dataNasc;
		LocalDate now;
		Period idade;
		
		//Retorna os dados e faz a o cálculo.
		dataNasc = LocalDate.of(anoNasc, mesNasc, diaNasc);
		now = LocalDate.now();
		idade = Period.between(dataNasc, now);
		
		return idade.getYears();
		
	}
	
	public int getFreqCardMaxima()
	{
		int freqCardMax;
		
		freqCardMax = 220 - getIdade();
		
		return freqCardMax;
	}
	
	public String getFreqCardAlvo()
	{
		double porc50;
		double porc85;
		String resultado;
		
		porc50 = getFreqCardMaxima() * 0.50;
		porc85 = getFreqCardMaxima() * 0.85;
		
		resultado = String.format("A frequência cardíaca alvo de %s é entre %.0f e %.0f", nome, porc50, porc85);
		
		return resultado;
	}

}
