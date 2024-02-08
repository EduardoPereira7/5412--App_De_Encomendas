using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace DeliciasCaseiras
{
    public partial class criarPedido : UserControl
    {
        Restaurante restaurante;
        public double precoTotal { get; set; } = 0;
        private string clientesFilePath = "clientesFile.txt";
        public criarPedido()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-PT");
            InitializeComponent();
            atualizarBebidas();
            atualizarPratos();
            restaurante = new Restaurante();
            
        }
        private void atualizarBebidas()
        {
            bebidas_checkBoxList.DataSource = null; 
            bebidas_checkBoxList.DataSource = Bebida.bebidas_List;
            bebidas_checkBoxList.DisplayMember = "DisplayMember";
        }
        private void atualizarPratos()
        {
            pratos_checkBoxList.DataSource = null;
            pratos_checkBoxList.DataSource = Prato.pratos_List;
            pratos_checkBoxList.DisplayMember = "DisplayMember";
        }
        //preço
        private void calcularPrecoTotal()
        {
            precoTotal = 0;
            foreach (Prato prato in pratos_checkBoxList.CheckedItems)
            {
                precoTotal += prato.preco;
            }
            foreach (Bebida bebida in bebidas_checkBoxList.CheckedItems)
            {
                precoTotal += bebida.preco;
            }
            preco.Text = precoTotal.ToString("C");
        }
        private void pratos_checkBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularPrecoTotal();
        }
        private void bebidas_checkBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularPrecoTotal();
        }
        private void pratos_checkBoxList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            calcularPrecoTotal();
        }
        private void bebidas_checkBoxList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            calcularPrecoTotal();
        }
        //confirmar pedido
        public List<Bebida> BebidasSelecionadas
        {
            get
            {
                List<Bebida> bebidasSelecionadas = new List<Bebida>();
                foreach (Bebida bebida in bebidas_checkBoxList.CheckedItems)
                {
                    bebidasSelecionadas.Add(bebida);
                }
                return bebidasSelecionadas;
            }
        }
        public List<Prato> PratosSelecionados
        {
            get
            {
                List<Prato> pratosSelecionados = new List<Prato>();
                foreach (Prato prato in pratos_checkBoxList.CheckedItems)
                {
                    pratosSelecionados.Add(prato);
                }
                return pratosSelecionados;
            }
        }
        internal void btConfirmarPedido_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            confirmarPedido1.Enabled = true;
            confirmarPedido1.BebidasSelecionadas = BebidasSelecionadas;
            confirmarPedido1.PratosSelecionados = PratosSelecionados;
            confirmarPedido1.atualizarPedidos();
            confirmarPedido1.Visible = true;
            confirmarPedido1.Focus();
        }
        public void reativar()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
            confirmarPedido1.Enabled=false;
            confirmarPedido1.Visible=false;
        }
        private void btSlcCliente_Click(object sender, EventArgs e)
        {
            abrirClientes();
        }
        private void abrirClientes()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            adicionarCliente1.Enabled = true;
            adicionarCliente1.Visible = true;
            adicionarCliente1.Focus();
        }
        public void criar_Pedido()
        {
            try
            {
                Pedido novoPedido = new Pedido();
                novoPedido.ClienteId = int.Parse(adicionarCliente1.idCliente);
                novoPedido.idPedido = restaurante.ObterIdPedido();
                string[] linhas = File.ReadAllLines(clientesFilePath);
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    string nome = campos[0];
                    if (novoPedido.ClienteId == int.Parse(campos[3]))
                    {
                        novoPedido.ClienteNome = nome;
                    }
                }
                if (BebidasSelecionadas.Count == 0 && PratosSelecionados.Count == 0)
                {
                    throw new Exception("Marque pelo menos um prato ou uma bebida.");
                }
                else
                {
                    if (BebidasSelecionadas.Count == 0)
                    {
                        novoPedido.Bebidas = new List<Bebida>();
                    }
                    else
                    {
                        novoPedido.Bebidas = BebidasSelecionadas;
                    }
                    if (PratosSelecionados.Count == 0)
                    {
                        novoPedido.Pratos = new List<Prato>();
                    }
                    else
                    {
                        novoPedido.Pratos = PratosSelecionados;
                    }
                }
                novoPedido.ValorTotal = precoTotal;
                novoPedido.Estado = Pedido.EstadoPedido.Pendente;
                DateTime auxData = MenuPrincipal.dataSelecionada;
                novoPedido.DataPedido = MenuPrincipal.dataSelecionada;
                novoPedido.Pagamento = (Pedido.FormaPagamento)Enum.Parse(typeof(Pedido.FormaPagamento), pagamento1.estado_pagamento);
                novoPedido.Entrega = endereco1.direcao;
                restaurante.AdicionarPedido(novoPedido.idPedido, novoPedido.ClienteId, novoPedido.ClienteNome, novoPedido.Bebidas, novoPedido.Pratos, novoPedido.ValorTotal, novoPedido.DataPedido, novoPedido.DataPrevista = null, novoPedido.Estado, novoPedido.Pagamento, novoPedido.Entrega);
                MessageBox.Show("Pedido adicionado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                if (adicionarCliente1.idCliente == null && BebidasSelecionadas.Count == 0 && PratosSelecionados.Count == 0 && pagamento1.estado_pagamento == null && string.IsNullOrEmpty(endereco1.direcao))
                {
                    MessageBox.Show("Pedido em branco. Não é possivel criar pedidos sem informação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (adicionarCliente1.idCliente == null)
                {
                    MessageBox.Show("Nenhum cliente foi selecionado! Por favor escolha um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    abrirClientes();
                }
                else if (BebidasSelecionadas.Count == 0 && PratosSelecionados.Count == 0)
                {
                    MessageBox.Show(ex.Message);
                }
                else if (pagamento1.estado_pagamento == null)
                {
                    MessageBox.Show("Nenhum pagamento foi efetuado! Por favor proceda com o pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    abrirPagamento();
                }
                else if (string.IsNullOrEmpty(endereco1.direcao))
                {
                    MessageBox.Show("O metodo de entrega não foi definido! Escolha onde quer entegar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    abrirEntrega();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirPagamento();
        }
        private void abrirPagamento()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            pagamento1.Enabled = true;
            pagamento1.Visible = true;
            pagamento1.lb_precoFinal.Text = preco.Text;
            pagamento1.precoFinalTroco = precoTotal;
            pagamento1.Focus();
        }
        private void bt_entrega_Click(object sender, EventArgs e)
        {
            abrirEntrega();
        }
        private void abrirEntrega()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            endereco1.Enabled = true;
            endereco1.Visible = true;
            endereco1.Focus();
        }
    }
}

