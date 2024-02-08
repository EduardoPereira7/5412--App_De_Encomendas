using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class GerirPedidos : UserControl
    {
        Restaurante restaurante;
        public GerirPedidos()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");
            InitializeComponent();
            restaurante = new Restaurante();
        }
        private void GerirPedidos_Load(object sender, EventArgs e)
        {
            cb_filtrarEstado.Items.Add("Todos");
            cb_filtrarEstado.Items.AddRange(Enum.GetValues(typeof(Pedido.EstadoPedido)).Cast<object>().ToArray());
            cB_estados.Items.AddRange(Enum.GetValues(typeof(Pedido.EstadoPedido)).Cast<object>().ToArray());
            cb_filtrarEstado.SelectedItem = "Todos";
            AtualizarDataGridView();
        }
        private void AtualizarDataGridView()
        {
            dataGridViewPedidos.Rows.Clear();
            if (File.Exists("PedidosList.txt"))
            {
                string[] linhas = File.ReadAllLines("PedidosList.txt");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    dataGridViewPedidos.Rows.Add(campos[0], campos[1], campos[2], campos[5], campos[6], campos[7], campos[8], campos[3], campos[4]);
                }
            }
            else
            {
                throw new Exception("O arquivo de pedidos não existe. Contacte o suporte!");
            }
            dataGridViewPedidos.CurrentCell = null;
        }
        private void bt_altEstado_Click(object sender, EventArgs e)
        {
            restaurante.AtualizarLista();
            if (dataGridViewPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idPedido = int.Parse(dataGridViewPedidos.SelectedRows[0].Cells[0].Value.ToString());
            Pedido pedidoEncontrado = null;
            foreach (Pedido pedido in restaurante.pedidosList)
            {
                if (pedido.idPedido == idPedido)
                {
                    pedidoEncontrado = pedido;
                    break;
                }
            }
            if (pedidoEncontrado == null)
            {
                MessageBox.Show("O pedido selecionado não foi encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cB_estados.SelectedItem == null)
            {
                MessageBox.Show("Selecione um estado válido para o pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pedidoEncontrado.Estado = (Pedido.EstadoPedido)cB_estados.SelectedItem;
            if (pedidoEncontrado.Estado == Pedido.EstadoPedido.EmPreparacao || pedidoEncontrado.Estado == Pedido.EstadoPedido.ProntoParaEntrega)
            {
                DateTime auxData = MenuPrincipal.dataSelecionada;
                pedidoEncontrado.DataPrevista = auxData.AddDays(2);
            }
            else if (pedidoEncontrado.Estado == Pedido.EstadoPedido.Pendente || pedidoEncontrado.Estado == Pedido.EstadoPedido.Entregue)
            {
                pedidoEncontrado.DataPrevista = null;
            }
            restaurante.AtualizarFilePedidos();
            AtualizarDataGridView();
            cb_filtrarEstado_SelectedIndexChanged(sender, e);
        }
        private void cb_filtrarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSelecionado = cb_filtrarEstado.SelectedItem.ToString();
            dataGridViewPedidos.Rows.Clear();
            if (File.Exists("PedidosList.txt"))
            {
                string[] linhas = File.ReadAllLines("PedidosList.txt");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    if (estadoSelecionado == "Todos" || campos[8] == estadoSelecionado)
                    {
                        dataGridViewPedidos.Rows.Add(campos[0], campos[1], campos[2], campos[5], campos[6], campos[7], campos[8], campos[3], campos[4]);
                    }
                    aux_manterDiaHoje();
                }
            }
            dataGridViewPedidos.CurrentCell = null;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lucroHoje.Checked)
            {
                aux_manterDiaHoje();
                cb_filtrarEstado.Enabled = false;
            }
            else
            {
                cb_filtrarEstado.Enabled=true;
                cb_filtrarEstado.SelectedItem = "Todos";
                cb_filtrarEstado_SelectedIndexChanged(sender, e);
            }
            dataGridViewPedidos.CurrentCell = null;
        }
        private void aux_manterDiaHoje()
        {
            if (cb_lucroHoje.Checked)
            {
                cb_filtrarEstado.SelectedItem = Pedido.EstadoPedido.ProntoParaEntrega;
                string estadoSelecionado = cb_filtrarEstado.SelectedItem.ToString();
                DateTime dataHora = MenuPrincipal.dataSelecionada.Date == DateTime.MinValue ? DateTime.Now : MenuPrincipal.dataSelecionada;
                DateTime data = dataHora.Date;
                dataGridViewPedidos.Rows.Clear();
                if (File.Exists("PedidosList.txt"))
                {
                    string[] linhas = File.ReadAllLines("PedidosList.txt");
                    foreach (string linha in linhas)
                    {
                        string[] campos = linha.Split(';');
                        if (DateTime.TryParseExact(campos[7], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataPedido) &&
                            dataPedido.Date == data.Date && campos[8] == estadoSelecionado)
                        {
                            dataGridViewPedidos.Rows.Add(campos[0], campos[1], campos[2], campos[5], campos[6], campos[7], campos[8], campos[3], campos[4]);
                        }
                    }
                }
            }
        }
    }
}
