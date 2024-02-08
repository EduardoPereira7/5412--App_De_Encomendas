using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class Endereco : UserControl
    {
        public string direcao=null;
        public Endereco()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string loja = "LOJA";
            txt_rua.Text = loja;
            txt_n.Text = loja;
            txt_distrito.Text = loja;
            txt_concelho.Text = loja;
            txt_codP.Text = loja;
            txt_rua.Enabled = false;
            txt_n.Enabled = false;
            txt_distrito.Enabled = false;
            txt_concelho.Enabled = false;
            txt_codP.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_rua.Text = "";
            txt_n.Text = "";
            txt_distrito.Text = "";
            txt_concelho.Text = "";
            txt_codP.Text = "";
            txt_rua.Enabled = true;
            txt_n.Enabled = true;
            txt_distrito.Enabled = true;
            txt_concelho.Enabled = true;
            txt_codP.Enabled = true;
        }
        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                direcao = "LOJA";
            }
            else
            {
                direcao = (txt_rua.Text + ", N." + txt_n.Text + ", " + txt_concelho.Text + ", " + txt_distrito.Text + ", " + txt_codP.Text);
                if (string.IsNullOrEmpty(txt_rua.Text) || string.IsNullOrEmpty(txt_n.Text) ||
                string.IsNullOrEmpty(txt_concelho.Text) || string.IsNullOrEmpty(txt_distrito.Text) ||
                string.IsNullOrEmpty(txt_codP.Text))
                {
                    MessageBox.Show("Por favor preencha todos os campos do endereço.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            this.Visible = false;
            criarPedido pedido = this.Parent as criarPedido;
            pedido.reativar();
        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            criarPedido pedido = this.Parent as criarPedido;
            pedido.reativar();
        }
    }
}
