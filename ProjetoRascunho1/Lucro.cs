using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class Lucro : UserControl
    {
        public Lucro()
        {
            InitializeComponent();
        }
        private void Lucro_Load(object sender, EventArgs e)
        {
            DateTime data_Inicio = DateTime.Now.AddMonths(-3);
            dateTime_inicio.Value= data_Inicio;
            DateTime data_Fim = MenuPrincipal.dataSelecionada == DateTime.MinValue ? DateTime.Now : MenuPrincipal.dataSelecionada;
            dateTime_fim.Value = data_Fim;
            //VALOR TOTAL
            double valorTotal = 0.0;
            if (File.Exists("PedidosList.txt"))
            {
                string[] linhas = File.ReadAllLines("PedidosList.txt");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    double valorPedido = 0.0;
                    if (double.TryParse(campos[5], out valorPedido))
                    {
                        valorTotal += valorPedido;
                    }
                }
            }
            total.Text = valorTotal.ToString("C2");
            //CLIENTES
            if (File.Exists("ClientesFile.txt"))
            {
                string[] linhas = File.ReadAllLines("ClientesFile.txt");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    dataGridViewClientes.Rows.Add(campos[3], campos[0]);
                }
            }
            dataGridViewClientes.CurrentCell = null;
            lb_cliente.Text = string.Empty;
        }
        private void dataGridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewPedidos.Rows.Clear();
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewClientes.SelectedRows[0];
                string idCliente = selectedRow.Cells[0].Value.ToString(); 
                string nomeCliente = selectedRow.Cells[1].Value.ToString();
                if (File.Exists("PedidosList.txt"))
                {
                    string[] linhas = File.ReadAllLines("PedidosList.txt");
                    foreach (string linha in linhas)
                    {
                        string[] campos = linha.Split(';');
                        if (campos[1] == idCliente)
                        {
                            dataGridViewPedidos.Rows.Add(campos[0], campos[5], campos[6]);
                        }
                    }
                }
                lb_cliente.Text = idCliente + " - " + nomeCliente;
            }
            FiltrarPedidosPorData();
            labels();
            dataGridViewPedidos.CurrentCell=null;
        }
        private void FiltrarPedidosPorData()
        {
            DateTime dataInicio = dateTime_inicio.Value.Date;
            DateTime dataFim = dateTime_fim.Value.Date;
            if (dataInicio > dataFim)
            {
                MessageBox.Show("A data de fim não pode ser inferior à data inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewPedidos.Rows)
                {
                    DateTime dataPedido = DateTime.Parse(row.Cells[2].Value.ToString());
                    if ((dataPedido.Date > dataInicio && dataPedido.Date < dataFim) || (dataPedido.Date == dataInicio || dataPedido.Date == dataFim))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            dataGridViewPedidos.Refresh();
        }
        private void dateTime_inicio_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewClientes_SelectionChanged(sender, e);
        }
        private void dateTime_fim_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewClientes_SelectionChanged(sender, e);
        }
        private void labels()
        {
            double valorTotal = 0.0;
            int numPedidos = 0;
            double valorPedido = 0.0;
            foreach (DataGridViewRow row in dataGridViewPedidos.Rows)
            {
                if (row.Visible && double.TryParse(row.Cells[1].Value.ToString(), out valorPedido))
                {
                    valorTotal += valorPedido;
                    numPedidos++;
                }
            }
            lb_totalCliente.Text = valorTotal.ToString("C2");
            lb_nPedidos.Text = numPedidos.ToString();
        }
    }
}
