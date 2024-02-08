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
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            DateTime dataHora = MenuPrincipal.dataSelecionada == DateTime.MinValue ? DateTime.Now : MenuPrincipal.dataSelecionada;
            DateTime data = dataHora.Date;
            dataGridViewPedidos.Rows.Clear();
            if (File.Exists("PedidosList.txt"))
            {
                string[] linhas = File.ReadAllLines("PedidosList.txt");
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    if (DateTime.TryParseExact(campos[7], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataPedido) && dataPedido.Date <= data)
                    {
                        dataGridViewPedidos.Rows.Add(campos[0], campos[1], campos[2], campos[5], campos[6], campos[7], campos[8]);
                    }
                }
            }
            else
            {
                throw new Exception("O arquivo de pedidos não existe. Contacte o suporte!");
            }
            dataGridViewPedidos.CurrentCell = null;
        }
    }
}
