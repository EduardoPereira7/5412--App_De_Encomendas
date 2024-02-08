using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class AdicionarCliente : UserControl
    {
        public string idCliente, nomeCliente;
        private string clientesFilePath = "clientesFile.txt";
        public AdicionarCliente()
        {
            InitializeComponent();
            atualizarBoxClientes();
        }
        private void atualizarBoxClientes()
        {
            comboBox_clientes.Items.Clear();
            string[] linhas = File.ReadAllLines(clientesFilePath);
            foreach (string linha in linhas)
            {
                string[] campo = linha.Split(';');
                string id = campo[3];
                string nome = campo[0];
                comboBox_clientes.Items.Add("ID: " + id + " / " + nome);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Resposta Sim
        {
            label2.Visible = true;
            comboBox_clientes.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtEndereco.Visible = false;
            txtTelefone.Visible = false;
            txtNome.Visible = false;
            bt_confirmar.Visible = false;
            bt_ok.Visible = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) //Resposta Não
        {
            label2.Visible = false;
            comboBox_clientes.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtEndereco.Visible = true;
            txtTelefone.Visible = true;
            txtNome.Visible = true;
            bt_ok.Visible = false;
            bt_confirmar.Visible = true;
        }
        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            int id = 1;
            List<Cliente> clientes = Cliente.CarregarClientes();
            // Verificar o ID disponivel
            var clientesSelecionados = clientes.OrderBy(c => c.Id);
            foreach (var cliente in clientesSelecionados)
            {
                if (cliente.Id > id)
                {
                    break;
                }
                id = cliente.Id + 1;
            }
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEndereco.Text) || string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos.", "Aviso",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsMatch(txtNome.Text, @"^[a-zA-ZÀ-ú ]+$"))
            {
                MessageBox.Show("Por favor, insira somente letras no campo nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (!Regex.IsMatch(txtTelefone.Text, @"^[0-9+]+$"))
            {
                MessageBox.Show("Por favor, insira somente números e o caractere + no campo telefone. O numero tem que ser válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Cliente novoCliente = new Cliente(id, txtNome.Text, txtEndereco.Text, txtTelefone.Text);
            clientes.Add(novoCliente);
            Cliente.GuardarClientes(clientes);
            criarPedido pedido = this.Parent as criarPedido;
            pedido.lb_nomeCliente.Text = novoCliente.Id + " - " + novoCliente.Nome;
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            idCliente = id.ToString();
            atualizarBoxClientes();
            voltar();
        }
        public void bt_ok_Click(object sender, EventArgs e)
        {
            if (comboBox_clientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione um cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string clienteSelecionado = comboBox_clientes.SelectedItem.ToString();
            string[] linhas = File.ReadAllLines(clientesFilePath);
            foreach (string linha in linhas)
            {
                string[] campo = linha.Split(';');
                string id = campo[3];
                string nome = campo[0];
                if (clienteSelecionado == ("ID: " + id + " / " + nome))
                {
                    idCliente = id;
                    nomeCliente = nome;
                    criarPedido pedido = this.Parent as criarPedido;
                    pedido.lb_nomeCliente.Text = (idCliente + " - " + nomeCliente);
                    break;
                }
            }
            voltar();
        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void AdicionarCliente_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void voltar()
        {
            this.Visible = false;
            criarPedido pedido = this.Parent as criarPedido;
            pedido.reativar();
        }
    }
}
