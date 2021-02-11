namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("O nome do produto não pode ficar vazio.");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarMensagem("A descrição do produto não pode ficar vazio.");
            }
        }
    }
}
