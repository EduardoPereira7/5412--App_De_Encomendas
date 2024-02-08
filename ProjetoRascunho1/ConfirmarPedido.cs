using System.Collections.Generic;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class ConfirmarPedido : UserControl
    {
        public ConfirmarPedido()
        {
            InitializeComponent();
        }
        public List<Bebida> BebidasSelecionadas { get; set; }
        public List<Prato> PratosSelecionados { get; set; }
        public class ItemLista
        {
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public double Preco { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
        public void atualizarPedidos()
        {
            nome_BoxList.DataSource = null;
            descricao_BoxList.DataSource = null;
            preco_BoxList.DataSource = null;

            List<ItemLista> listaCombinada = new List<ItemLista>();

            if (BebidasSelecionadas != null)
            {
                foreach (Bebida bebida in BebidasSelecionadas)
                {
                    listaCombinada.Add(new ItemLista { Nome = bebida.nome, Descricao = bebida.descricao, Preco = bebida.preco });
                }
            }
            if (PratosSelecionados != null)
            {
                foreach (Prato prato in PratosSelecionados)
                {
                    listaCombinada.Add(new ItemLista { Nome = prato.nome, Descricao = prato.descricao, Preco = prato.preco });
                }
            }
            if (listaCombinada.Count > 0)
            {
                double precoTotal = 0;
                foreach (ItemLista item in listaCombinada)
                {
                    precoTotal += item.Preco;
                }
                nome_BoxList.DataSource = listaCombinada;
                nome_BoxList.DisplayMember = "nome";
                descricao_BoxList.DataSource = listaCombinada;
                descricao_BoxList.DisplayMember = "descricao";
                preco_BoxList.DataSource = listaCombinada;
                preco_BoxList.DisplayMember = "preco";
                lb_total.Text = precoTotal.ToString("C");
            }
        }
        private void btConfirmar_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            criarPedido pedido = this.Parent as criarPedido;
            pedido.reativar();
            pedido.criar_Pedido();
        }
        private void bt_cancelar_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            criarPedido pedido = this.Parent as criarPedido;
            pedido.reativar();
        }
    }
}
