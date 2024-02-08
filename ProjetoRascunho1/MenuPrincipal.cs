using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class MenuPrincipal : Form
    {
        public static DateTime dataSelecionada {  get; set; }
        public MenuPrincipal()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");
            InitializeComponent();
            home();
        }
        public void disableColor()
        {
            bt_alterarStock.BackColor = Color.FromArgb(64, 64, 64);
            bt_inserirPedido.BackColor = Color.FromArgb(64, 64, 64);
            bt_clientes.BackColor = Color.FromArgb(64, 64, 64);
            bt_pedidos.BackColor = Color.FromArgb(64, 64, 64);
            bt_lucro.BackColor = Color.FromArgb(64, 64, 64);
            bt_home.BackColor = Color.FromArgb(64, 64, 64);
        }
        public void showControl(Control control)
        {
            Content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);
        }
        private void bt_alterarStock_Click(object sender, EventArgs e)
        {
            disableColor();
            Stock stock = new Stock();
            bt_alterarStock.BackColor = Color.FromArgb(255, 128, 0);
            showControl(stock);
        }
        private void bt_clientes_Click(object sender, EventArgs e)
        {
            disableColor();
            Clientes clientes = new Clientes();
            bt_clientes.BackColor = Color.FromArgb(30, 181, 205);
            showControl(clientes);
        }
        private void bt_pedidos_Click(object sender, EventArgs e)
        {
            gerirPedidos();
        }
        private void gerirPedidos()
        {
            disableColor();
            GerirPedidos gerirPedidos = new GerirPedidos();
            bt_pedidos.BackColor = Color.FromArgb(74, 225, 51);
            dataSelecionada = data_principal.Value;
            showControl(gerirPedidos);
        }
        private void bt_lucro_Click(object sender, EventArgs e)
        {
            disableColor();
            Lucro lucro = new Lucro();
            bt_lucro.BackColor = Color.MediumSlateBlue;
            dataSelecionada = data_principal.Value;
            showControl(lucro);
        }
        private void data_principal_ValueChanged(object sender, EventArgs e)
        {
            dataSelecionada = data_principal.Value;
            avisoPedidos();
            if (bt_home.BackColor == Color.Gray)
            {
                home();
            }
            else if (bt_pedidos.BackColor == Color.FromArgb(74, 225, 51))
            {
                gerirPedidos();
            }
        }
        private void bt_exportar_Click(object sender, EventArgs e)
        {
            bt_exportar.BackColor = Color.Black;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Exportar CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false);
                StreamReader sr = new StreamReader("PedidosList.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    sw.WriteLine(line.Replace(";", ";"));
                }
                sr.Close();
                sw.Close();
                MessageBox.Show("Ficheiro guardado com sucesso.", "Guardar ficheiro CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_exportar.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                bt_exportar.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        private List<int> ObterPedidosComDataPrevistaUltrassada()
        {
            var pedidosComDataPrevistaUltrassada = new List<int>();
            var linhas = File.ReadAllLines("PedidosList.txt");

            if (linhas.Length > 0)
            {
                foreach (var linha in linhas)
                {
                    var valores = linha.Split(';');

                    if (DateTime.TryParse(valores[7], out var dataPrevista))
                    {
                        if (dataPrevista.Date <= dataSelecionada.Date && valores[8] != "Entregue" && valores[8] != "Pendente")
                        {
                            if (int.TryParse(valores[0], out var idPedido))
                            {
                                pedidosComDataPrevistaUltrassada.Add(idPedido);
                            }
                        }
                    }
                }
            }
            return pedidosComDataPrevistaUltrassada;
        }
        private void avisoPedidos()
        {
            dataSelecionada = data_principal.Value;
            var pedidosComDataPrevistaUltrassada = ObterPedidosComDataPrevistaUltrassada();

            if (pedidosComDataPrevistaUltrassada.Count > 0)
            {
                var idsPedidos = string.Join(", ", pedidosComDataPrevistaUltrassada);
                MessageBox.Show($"Os seguintes pedidos têm a DataPrevista ultrapassada: {idsPedidos}");
            }
        }
        private void bt_inserirPedido_Click(object sender, EventArgs e)
        {
            disableColor();
            criarPedido pedido = new criarPedido();
            bt_inserirPedido.BackColor = Color.Red;
            dataSelecionada = data_principal.Value;
            showControl(pedido);
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            home();
        }
        private void home()
        {
            disableColor();
            Inicio inicio = new Inicio();
            bt_home.BackColor = Color.Gray;
            dataSelecionada = data_principal.Value;
            showControl(inicio);
        }
    }

}
