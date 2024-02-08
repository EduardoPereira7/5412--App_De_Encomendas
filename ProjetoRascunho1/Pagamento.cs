using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class Pagamento : UserControl
    {
        public string estado_pagamento;
        public double precoFinalTroco;
        private double preco;
        private bool auxVerificacao = true;
        public Pagamento()
        {
            InitializeComponent();
        }
        private void Pagamento_Load(object sender, EventArgs e)
        {
            comboBoxPagamentos.Items.AddRange(Enum.GetValues(typeof(Pedido.FormaPagamento)).Cast<object>().ToArray());
            comboBoxPagamentos.Items.Remove(Pedido.FormaPagamento.Local);
        }
        private void pagOnline_CheckedChanged(object sender, EventArgs e)
        {
            dinheiroEntregueLabel.Visible = false;
            txt_dinheiro.Visible = false;
            trocoLabel.Visible = false;
            lb_troco.Visible = false;
            comboBoxPagamentos.Visible = true;
            metodoPagLabel.Visible = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dinheiroEntregueLabel.Visible = true;
            txt_dinheiro.Visible = true;
            trocoLabel.Visible = true;
            lb_troco.Visible = true;
            comboBoxPagamentos.Visible = false;
            metodoPagLabel.Visible = false;
            auxVerificacao = false;
        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            criarPedido pedido = this.Parent as criarPedido;
            pedido.reativar();
        }
        private void txt_dinherio_TextChanged(object sender, EventArgs e)
        {
            if (txt_dinheiro.Text.Contains("."))
            {
                MessageBox.Show("Por favor, use ',' para casas decimais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dinheiro.Text = txt_dinheiro.Text.Replace(".", ",");
                txt_dinheiro.SelectionStart = txt_dinheiro.Text.Length;
            }
            double preco_Final = precoFinalTroco;
            if (double.TryParse(txt_dinheiro.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-PT"), out double valor))
            {
                preco = valor - preco_Final;
                lb_troco.Text = preco.ToString("C");
            }
            else if (string.IsNullOrEmpty(txt_dinheiro.Text))
            {
                lb_troco.Text = "0,00€";
            }
            if (Convert.ToDecimal(valor) >= Convert.ToDecimal(preco_Final))
            {
                auxVerificacao = true;
            }
        }
        private void bt_pagar_Click(object sender, EventArgs e)
        {
            if (comboBoxPagamentos.SelectedItem == null && pagOnline.Checked==true)
            {
                MessageBox.Show("Por favor selecione um metodo de pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (radioButton1.Checked == true && !auxVerificacao )
            {
                MessageBox.Show("Introduza um valor superior ao valor a pagar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pagOnline.Checked==true)
            {
                estado_pagamento = comboBoxPagamentos.SelectedItem.ToString();
                bt_cancelar_Click(sender, e);
            }
            else
            {
                estado_pagamento = "Local";
                bt_cancelar_Click(sender, e);
            }
        }
    }
}
