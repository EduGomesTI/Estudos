using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido {get; set;}
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        /// <sumary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens de pedidos
        /// </sumary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemvalidacao();
            if (!ItensPedido.Any())
            {
                AdicionarMensagem("Pedido deve ter pelo menos um item de pedido.");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarMensagem("O Pedido deve ter o CEP de entrega.");
            }
            if(FormaPagamentoId == 0)
            {
                AdicionarMensagem("Não foi informado a forma de pagamento.");
            }
        }
    }
}
