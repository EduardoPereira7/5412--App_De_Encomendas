using System;
using System.Collections.Generic;

namespace DeliciasCaseiras
{
    public class Pedido
    {
        public int idPedido { get; set; } = 1;
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public List<Bebida> Bebidas { get; set; }
        public List<Prato> Pratos { get; set; }
        public double ValorTotal { get; set; }
        public string Entrega { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime? DataPrevista { get; set; }
        public EstadoPedido Estado { get; set; }
        public FormaPagamento Pagamento { get; set; }
        public enum EstadoPedido
        {
            Pendente,
            EmPreparacao,
            ProntoParaEntrega,
            Entregue
        }
        public enum FormaPagamento
        {
            Mbway,
            Visa,
            Paypal,
            Local
        }
        public Pedido()
        {
            Estado = EstadoPedido.Pendente;
            Pagamento = FormaPagamento.Mbway;
            DataPrevista = null; 
        }
        public Pedido(int idPedido, int ClienteId, string ClienteNome, List<Bebida> Bebidas, List<Prato> Pratos, double ValorTotal, DateTime DataPedido, DateTime? DataPrevista, EstadoPedido Estado = EstadoPedido.Pendente, FormaPagamento Pagamento = FormaPagamento.Paypal, string entrega=null)
        {
            if (entrega == null)
            {
                throw new ArgumentNullException(nameof(entrega), "A entrega não foi definida.");
            }
            this.idPedido = idPedido;
            this.ClienteId = ClienteId;
            this.ClienteNome = ClienteNome;
            this.Bebidas = Bebidas;
            this.Pratos = Pratos;
            this.ValorTotal = ValorTotal;
            this.DataPedido = DataPedido;
            this.DataPrevista = DataPrevista;
            this.Estado = Estado;
            this.Pagamento = Pagamento;
            this.Entrega = entrega;
        }
    }
}
