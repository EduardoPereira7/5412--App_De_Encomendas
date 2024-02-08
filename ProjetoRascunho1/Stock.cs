using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciasCaseiras
{
    public partial class Stock : UserControl
    {
        internal Stock()
        {
            InitializeComponent();
        }
        //HIDE/SHOW/BUTTONS
        private void aux_pratos()
        {
            tb_desc_prato.Clear();
            tb_nome_prato.Clear();
            tb_preco_prato.Clear();
            bt_del_prato.Show();
            bt_add_prato.Show();
            lb_nome_prato.Hide();
            lb_preco_prato.Hide();
            lb_desc_prato.Hide();
            tb_desc_prato.Hide();
            tb_nome_prato.Hide();
            tb_preco_prato.Hide();
            bt_addfinal_prato.Hide();
            bt_cancelar_pratos.Hide();
        }
        private void aux_bebidas()
        {
            tb_desc_bebida.Clear();
            tb_nome_bebida.Clear();
            tb_preco_bebida.Clear();
            bt_del_bebida.Show();
            bt_add_bebida.Show();
            lb_nome_bebida.Hide();
            lb_preco_bebida.Hide();
            lb_desc_bebida.Hide();
            tb_desc_bebida.Hide();
            tb_nome_bebida.Hide();
            tb_preco_bebida.Hide();
            bt_addfinal_bebidas.Hide();
            bt_cancelar_bebidas.Hide();
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            atualizarBebidas();
            atualizarPratos();
        }
        //BEBIDAS
        private void atualizarBebidas()
        {
            bebidas_CheckBoxList.DataSource = null;
            bebidas_CheckBoxList.DataSource = Bebida.bebidas_List;
            bebidas_CheckBoxList.DisplayMember = "ToString";
        }
        private void bt_add_bebida_Click(object sender, EventArgs e)
        {
            bt_del_bebida.Hide();
            bt_add_bebida.Hide();
            lb_nome_bebida.Show();
            lb_preco_bebida.Show();
            lb_desc_bebida.Show();
            tb_desc_bebida.Show();
            tb_nome_bebida.Show();
            tb_preco_bebida.Show();
            bt_addfinal_bebidas.Show();
            bt_cancelar_bebidas.Show();
        }
        private void bt_addfinal_bebidas_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nome_bebida.Text) || string.IsNullOrWhiteSpace(tb_desc_bebida.Text) || string.IsNullOrWhiteSpace(tb_preco_bebida.Text))
            {
                MessageBox.Show("Preencha todos os campos para adicionar uma bebida.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsMatch(tb_nome_bebida.Text, @"^[a-zA-ZÀ-ú ]+$"))
            {
                MessageBox.Show("O nome da bebida deve conter apenas letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            try
            {
                Bebida bebida = new Bebida(tb_nome_bebida.Text, tb_desc_bebida.Text, double.Parse(tb_preco_bebida.Text));
                Bebida.AdicionarBebida(bebida);
                atualizarBebidas();
                aux_bebidas();
            }
            catch (FormatException)
            {
                MessageBox.Show("O preço deve ser um número válido. Para casas decimais utilize apenas virgula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void bt_del_bebida_Click(object sender, EventArgs e)
        {
            if (bebidas_CheckBoxList.Items.Count == 0)
            {
                MessageBox.Show("Sem bebidas para remover.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (bebidas_CheckBoxList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Selecione pelo menos uma bebida para remover.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    List<Bebida> bebidasSelecionadas = new List<Bebida>();
                    foreach (Bebida bebida in bebidas_CheckBoxList.CheckedItems)
                    {
                        bebidasSelecionadas.Add(bebida);
                    }

                    foreach (Bebida bebida in bebidasSelecionadas)
                    {
                        Bebida.RemoverBebida(bebida);
                    }
                    atualizarBebidas();
                }
            }
        }
        private void bt_cancelar_bebidas_Click(object sender, EventArgs e)
        {
            aux_bebidas();
        }
        //PRATOS
        private void atualizarPratos()
        {
            pratos_CheckBoxList.DataSource = null;
            pratos_CheckBoxList.DataSource = Prato.pratos_List;
            pratos_CheckBoxList.DisplayMember = "ToString";
        }
        private void bt_add_prato_Click(object sender, EventArgs e)
        {
            bt_del_prato.Hide();
            bt_add_prato.Hide();
            lb_nome_prato.Show();
            lb_preco_prato.Show();
            lb_desc_prato.Show();
            tb_desc_prato.Show();
            tb_nome_prato.Show();
            tb_preco_prato.Show();
            bt_addfinal_prato.Show();
            bt_cancelar_pratos.Show();
        }
        private void bt_del_prato_Click(object sender, EventArgs e)
        {
            if (pratos_CheckBoxList.Items.Count == 0)
            {
                MessageBox.Show("Sem pratos para remover.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (pratos_CheckBoxList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Selecione pelo menos um prato para remover.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    List<Prato> pratosSelecionados = new List<Prato>();
                    foreach (Prato prato in pratos_CheckBoxList.CheckedItems)
                    {
                        pratosSelecionados.Add(prato);
                    }

                    foreach (Prato prato in pratosSelecionados)
                    {
                        Prato.RemoverPrato(prato);
                    }

                    atualizarPratos();
                }
            }
        }
        private void bt_addfinal_prato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nome_prato.Text) || string.IsNullOrWhiteSpace(tb_desc_prato.Text) || string.IsNullOrWhiteSpace(tb_preco_prato.Text))
            {
                MessageBox.Show("Preencha todos os campos para adicionar um prato.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsMatch(tb_nome_prato.Text, @"^[a-zA-ZÀ-ú ]+$"))
            {
                MessageBox.Show("O nome da bebida deve conter apenas letras.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            try
            {
                Prato prato = new Prato(tb_nome_prato.Text, tb_desc_prato.Text, double.Parse(tb_preco_prato.Text));
                Prato.AdicionarPrato(prato);
                aux_pratos();
                atualizarPratos();
            }
            catch (FormatException)
            {
                MessageBox.Show("O preço deve ser um número válido. Para casas decimais utilize apenas virgula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void bt_cancelar_pratos_Click(object sender, EventArgs e)
        {
            aux_pratos();
        }
    }
}
