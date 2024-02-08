using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class Clientes : UserControl
    {
        private List<Cliente> clientes;
        Restaurante restaurante;
        public Clientes()
        {
            InitializeComponent();
            clientes = Cliente.CarregarClientes();
            AtualizarDataGridView();
            restaurante = new Restaurante();
        }
        private void bt_add_cliente_Click(object sender, EventArgs e)
        {
            int id = 1;
            var clientesSelecionados = clientes.OrderBy(c => c.Id);
            foreach (var cliente in clientesSelecionados)
            {
                if (cliente.Id > id)
                {
                    break;
                }
                id = cliente.Id + 1;
            }
            if (string.IsNullOrEmpty(tb_enderecoCliente.Text) || string.IsNullOrEmpty(tb_enderecoCliente.Text) || string.IsNullOrEmpty(tb_telefoneCliente.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos do cliente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsMatch(tb_nomeCliente.Text, @"^[a-zA-ZÀ-ú ]+$"))
            {
                MessageBox.Show("O nome deve conter apenas letras.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (!Regex.IsMatch(tb_telefoneCliente.Text, @"^\+?\d[\d()\+]*\d$"))
            {
                MessageBox.Show("O telefone tem que ser válido e pode conter apenas números e o caractere '+'.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Cliente novoCliente = new Cliente(id, tb_nomeCliente.Text, tb_enderecoCliente.Text, tb_telefoneCliente.Text);
            clientes.Add(novoCliente);
            Cliente.GuardarClientes(clientes);
            LimparCampos();
            AtualizarDataGridView();
        }
        private void bt_remove_cliente_Click(object sender, EventArgs e)
        {
            List<int> idsParaRemover = new List<int>();
            foreach (DataGridViewRow row in dataGridViewClientes.Rows)
            {
                if (row.Selected)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    idsParaRemover.Add(id);
                }
            }
            if (idsParaRemover.Count == 0)
            {
                MessageBox.Show("Por favor selecione pelo menos um cliente para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string mensagem = "Você tem certeza que deseja remover o(s) cliente(s) selecionado(s)?";
            string barraTitulo = "Remover Cliente";
            var escolha = MessageBox.Show(mensagem, barraTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (escolha == DialogResult.Yes)
            {
                foreach (int id in idsParaRemover)
                {
                    Cliente cliente = clientes.Find(c => c.Id == id);
                    if (cliente != null)
                    {
                        clientes.Remove(cliente);
                        RemoverPedidosDoCliente(id);
                    }
                }
                Cliente.GuardarClientes(clientes);
                AtualizarDataGridView();
            }
        }
        private void RemoverPedidosDoCliente(int clienteId)
        {
            string filePath = "./PedidosList.txt";
            string[] linhas = File.ReadAllLines(filePath);
            List<string> atualizarLinhas = new List<string>();
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                if (campos.Length > 1 && campos[1] == clienteId.ToString())
                {
                    continue;
                }
                atualizarLinhas.Add(linha);
            }
            File.WriteAllLines(filePath, atualizarLinhas);
            restaurante.AtualizarLista();
        }
        private void AtualizarDataGridView()
        {
            dataGridViewClientes.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                dataGridViewClientes.Rows.Add(cliente.Id,cliente.Nome,cliente.Endereco,cliente.Telefone);
            }
            dataGridViewClientes.Sort(dataGridViewClientes.Columns[0], ListSortDirection.Ascending);    
        }
        private void LimparCampos()
        {
            tb_nomeCliente.Text = "";
            tb_enderecoCliente.Text = "";
            tb_telefoneCliente.Text = "";
        }
    }
}
