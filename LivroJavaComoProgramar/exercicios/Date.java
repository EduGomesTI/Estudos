package exercicios;

public class Date {
	
	private int dia;
	private int mes;
	private int ano;
	
	public Date(int dia, int mes, int ano)
	{
		this.dia = dia;
		this.mes = mes;
		this.ano = ano;
	}
	
	/**
	 * @return the dia
	 */
	public int getDia() 
	{
		return dia;
	}
	/**
	 * @param dia the dia to set
	 */
	public void setDia(int dia) 
	{
		this.dia = dia;
	}
	/**
	 * @return the mes
	 */
	public int getMes()
	{
		return mes;
	}
	/**
	 * @param mes the mes to set
	 */
	public void setMes(int mes) 
	{
		this.mes = mes;
	}
	/**
	 * @return the ano
	 */
	public int getAno()
	{
		return ano;
	}
	/**
	 * @param ano the ano to set
	 */
	public void setAno(int ano) 
	{
		this.ano = ano;
	}
	
	public String displayDate()
	{
		String sDia;
		String sMes;
		String sAno;
		String data;
		
		sDia = Integer.toString(dia);
		sMes = Integer.toString(mes);
		sAno = Integer.toString(ano);
		data = String.format("%s/%s/%s", sDia, sMes, sAno);
		
		return data;
		
	}
	

}
