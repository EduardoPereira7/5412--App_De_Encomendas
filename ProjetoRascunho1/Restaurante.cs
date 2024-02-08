using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DeliciasCaseiras
{
    public class Restaurante
    {
        string bebidasStr, pratosStr;
        public List<Pedido> pedidosList { get; set; }
        public Restaurante()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");
            pedidosList = new List<Pedido>();
        }
        internal int ObterIdPedido()
        {
            int proximoId = 0;
            if (File.Exists("PedidosList.txt"))
            {
                string[] linhas = File.ReadAllLines("PedidosList.txt");
                if (linhas.Length > 0)
                {
                    string[] campos = linhas[linhas.Length - 1].Split(';');
                    int ultimoId = int.Parse(campos[0]);
                    proximoId = ultimoId + 1;
                }
            }
            return proximoId;
        }
        public void AdicionarPedido(int idPedido, int ClienteId, string ClienteNome, List<Bebida> Bebidas, List<Prato> Pratos, double ValorTotal, DateTime DataPedido, DateTime? dataPrevista, Pedido.EstadoPedido Estado = Pedido.EstadoPedido.Pendente, Pedido.FormaPagamento Pagamento = Pedido.FormaPagamento.Paypal, string entrega=null)
        {
            Pedido novoPedido = new Pedido(idPedido, ClienteId, ClienteNome, Bebidas, Pratos, ValorTotal, DataPedido, dataPrevista, Estado, Pagamento, entrega);
            pedidosList.Add(novoPedido);
            GuardarPedidos();
        }
        public void GuardarPedidos()
        {
            using (StreamWriter writer = File.AppendText("PedidosList.txt"))
            {
                foreach (Pedido pedido in pedidosList)
                {
                    bebidasStr = string.Join(",", pedido.Bebidas.Select(b => b.nome));
                    pratosStr = string.Join(",", pedido.Pratos.Select(p => p.nome));
                    writer.WriteLine($"{pedido.idPedido};{pedido.ClienteId};{pedido.ClienteNome};{bebidasStr};{pratosStr};{pedido.ValorTotal};{pedido.DataPedido};{pedido.DataPrevista};{pedido.Estado};{pedido.Pagamento};{pedido.Entrega}");
                }
                pedidosList.Clear();
            }
        }
        public void AtualizarFilePedidos()
        {
            using (StreamWriter writer = new StreamWriter("PedidosList.txt"))
            {
                foreach (Pedido pedido in pedidosList)
                {
                    bebidasStr = string.Join(",", pedido.Bebidas.Select(b => b.nome));
                    pratosStr = string.Join(",", pedido.Pratos.Select(p => p.nome));
                    writer.WriteLine($"{pedido.idPedido};{pedido.ClienteId};{pedido.ClienteNome};{bebidasStr};{pratosStr};{pedido.ValorTotal};{pedido.DataPedido};{pedido.DataPrevista};{pedido.Estado};{pedido.Pagamento};{pedido.Entrega}");
                }
            }
            pedidosList.Clear();
        }
        public void AtualizarLista()
        {
            pedidosList.Clear();
            if (File.Exists("PedidosList.txt"))
            {
                string[] linhas = File.ReadAllLines("PedidosList.txt");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    int idPedido = int.Parse(campos[0]);
                    int clienteId = int.Parse(campos[1]);
                    string clienteNome = campos[2];
                    List<Bebida> bebidas = campos[3].Split(',').Select(nomeBebida => new Bebida(nomeBebida)).ToList();
                    List<Prato> pratos = campos[4].Split(',').Select(nomePrato => new Prato(nomePrato)).ToList();
                    double valorTotal = double.Parse(campos[5]);
                    DateTime dataPedido = DateTime.Parse(campos[6]);
                    DateTime? dataPrevista = null;
                    if (!string.IsNullOrEmpty(campos[7]))
                    {
                        dataPrevista = DateTime.Parse(campos[7]);
                    }
                    Pedido.EstadoPedido estado = (Pedido.EstadoPedido)Enum.Parse(typeof(Pedido.EstadoPedido), campos[8]);
                    Pedido.FormaPagamento pagamento = (Pedido.FormaPagamento)Enum.Parse(typeof(Pedido.FormaPagamento), campos[9]);
                    string entrega = campos[10];
                    Pedido pedido = new Pedido(idPedido, clienteId, clienteNome, bebidas, pratos, valorTotal, dataPedido, dataPrevista, estado,pagamento,entrega);
                    pedidosList.Add(pedido);
                }
            }
        }
    }
}