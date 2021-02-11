package exercicios;

public class HeartRatesTest {

	public static void main(String[] args) {
	
		HeartRates paciente = new HeartRates("Eduardo", "Gomes", 10, 12, 1976);
		
		System.out.printf("%s %s\n", paciente.getNome(), paciente.getSobrenome());
		System.out.printf("Data de Nascimento: %d/%d/%d\n", paciente.getDiaNasc(), paciente.getMesNasc(), paciente.getAnoNasc());
		System.out.printf("Idade: %d\n", paciente.getIdade());
		System.out.print(paciente.getFreqCardAlvo() + "\n");
		System.out.printf("A frequ�ncia card�aca m�xima � %d", paciente.getFreqCardMaxima());

	}

}
