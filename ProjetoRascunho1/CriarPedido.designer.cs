
namespace DeliciasCaseiras
{
    partial class criarPedido
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pratos_checkBoxList = new System.Windows.Forms.CheckedListBox();
            this.bebidas_checkBoxList = new System.Windows.Forms.CheckedListBox();
            this.preco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirmarPedido = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_nomeCliente = new System.Windows.Forms.Label();
            this.labelcliente = new System.Windows.Forms.Label();
            this.btSlcCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_entrega = new System.Windows.Forms.Button();
            this.pagamento1 = new DeliciasCaseiras.Pagamento();
            this.adicionarCliente1 = new DeliciasCaseiras.AdicionarCliente();
            this.confirmarPedido1 = new DeliciasCaseiras.ConfirmarPedido();
            this.endereco1 = new DeliciasCaseiras.Endereco();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pratos_checkBoxList
            // 
            this.pratos_checkBoxList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pratos_checkBoxList.BackColor = System.Drawing.Color.Silver;
            this.pratos_checkBoxList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pratos_checkBoxList.Font = new System.Drawing.Font("Arial", 15F);
            this.pratos_checkBoxList.ForeColor = System.Drawing.Color.Black;
            this.pratos_checkBoxList.FormattingEnabled = true;
            this.pratos_checkBoxList.Location = new System.Drawing.Point(95, 247);
            this.pratos_checkBoxList.Margin = new System.Windows.Forms.Padding(4);
            this.pratos_checkBoxList.Name = "pratos_checkBoxList";
            this.pratos_checkBoxList.Size = new System.Drawing.Size(318, 252);
            this.pratos_checkBoxList.TabIndex = 3;
            this.pratos_checkBoxList.SelectedIndexChanged += new System.EventHandler(this.pratos_checkBoxList_SelectedIndexChanged);
            // 
            // bebidas_checkBoxList
            // 
            this.bebidas_checkBoxList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bebidas_checkBoxList.BackColor = System.Drawing.Color.Silver;
            this.bebidas_checkBoxList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bebidas_checkBoxList.Font = new System.Drawing.Font("Arial", 15F);
            this.bebidas_checkBoxList.ForeColor = System.Drawing.Color.Black;
            this.bebidas_checkBoxList.FormattingEnabled = true;
            this.bebidas_checkBoxList.Location = new System.Drawing.Point(595, 247);
            this.bebidas_checkBoxList.Margin = new System.Windows.Forms.Padding(4);
            this.bebidas_checkBoxList.Name = "bebidas_checkBoxList";
            this.bebidas_checkBoxList.Size = new System.Drawing.Size(318, 252);
            this.bebidas_checkBoxList.TabIndex = 4;
            this.bebidas_checkBoxList.SelectedIndexChanged += new System.EventHandler(this.bebidas_checkBoxList_SelectedIndexChanged);
            // 
            // preco
            // 
            this.preco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preco.AutoSize = true;
            this.preco.BackColor = System.Drawing.Color.Transparent;
            this.preco.Font = new System.Drawing.Font("Arial", 20F);
            this.preco.ForeColor = System.Drawing.Color.Black;
            this.preco.Location = new System.Drawing.Point(239, 571);
            this.preco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(44, 32);
            this.preco.TabIndex = 7;
            this.preco.Text = "0€";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 23.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pratos";
            // 
            // btConfirmarPedido
            // 
            this.btConfirmarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConfirmarPedido.BackColor = System.Drawing.Color.Red;
            this.btConfirmarPedido.FlatAppearance.BorderSize = 0;
            this.btConfirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmarPedido.Font = new System.Drawing.Font("Arial", 15F);
            this.btConfirmarPedido.ForeColor = System.Drawing.Color.SeaShell;
            this.btConfirmarPedido.Location = new System.Drawing.Point(381, 563);
            this.btConfirmarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btConfirmarPedido.Name = "btConfirmarPedido";
            this.btConfirmarPedido.Size = new System.Drawing.Size(262, 53);
            this.btConfirmarPedido.TabIndex = 10;
            this.btConfirmarPedido.Text = "Confirmar pedido";
            this.btConfirmarPedido.UseVisualStyleBackColor = false;
            this.btConfirmarPedido.Click += new System.EventHandler(this.btConfirmarPedido_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 84);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(389, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "Criar Pedido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nomeCliente
            // 
            this.lb_nomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nomeCliente.AutoSize = true;
            this.lb_nomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lb_nomeCliente.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeCliente.ForeColor = System.Drawing.Color.Black;
            this.lb_nomeCliente.Location = new System.Drawing.Point(211, 129);
            this.lb_nomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nomeCliente.Name = "lb_nomeCliente";
            this.lb_nomeCliente.Size = new System.Drawing.Size(211, 28);
            this.lb_nomeCliente.TabIndex = 6;
            this.lb_nomeCliente.Text = "Consumidor Final";
            // 
            // labelcliente
            // 
            this.labelcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcliente.AutoSize = true;
            this.labelcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelcliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcliente.ForeColor = System.Drawing.Color.Black;
            this.labelcliente.Location = new System.Drawing.Point(89, 125);
            this.labelcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcliente.Name = "labelcliente";
            this.labelcliente.Size = new System.Drawing.Size(114, 32);
            this.labelcliente.TabIndex = 1;
            this.labelcliente.Text = "Cliente:";
            // 
            // btSlcCliente
            // 
            this.btSlcCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSlcCliente.BackColor = System.Drawing.Color.Red;
            this.btSlcCliente.FlatAppearance.BorderSize = 0;
            this.btSlcCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSlcCliente.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSlcCliente.ForeColor = System.Drawing.Color.SeaShell;
            this.btSlcCliente.Location = new System.Drawing.Point(688, 125);
            this.btSlcCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btSlcCliente.Name = "btSlcCliente";
            this.btSlcCliente.Size = new System.Drawing.Size(225, 32);
            this.btSlcCliente.TabIndex = 2;
            this.btSlcCliente.Text = "Selecionar cliente...";
            this.btSlcCliente.UseVisualStyleBackColor = false;
            this.btSlcCliente.Click += new System.EventHandler(this.btSlcCliente_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(589, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bebidas";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(89, 571);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Preço total:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(795, 549);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pagamento";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_entrega
            // 
            this.bt_entrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_entrega.BackColor = System.Drawing.Color.Red;
            this.bt_entrega.FlatAppearance.BorderSize = 0;
            this.bt_entrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_entrega.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrega.ForeColor = System.Drawing.Color.SeaShell;
            this.bt_entrega.Location = new System.Drawing.Point(795, 589);
            this.bt_entrega.Margin = new System.Windows.Forms.Padding(4);
            this.bt_entrega.Name = "bt_entrega";
            this.bt_entrega.Size = new System.Drawing.Size(118, 32);
            this.bt_entrega.TabIndex = 20;
            this.bt_entrega.Text = "Entrega";
            this.bt_entrega.UseVisualStyleBackColor = false;
            this.bt_entrega.Click += new System.EventHandler(this.bt_entrega_Click);
            // 
            // pagamento1
            // 
            this.pagamento1.BackColor = System.Drawing.Color.LightGray;
            this.pagamento1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pagamento1.Enabled = false;
            this.pagamento1.Location = new System.Drawing.Point(307, 151);
            this.pagamento1.Name = "pagamento1";
            this.pagamento1.Size = new System.Drawing.Size(419, 430);
            this.pagamento1.TabIndex = 19;
            this.pagamento1.Visible = false;
            // 
            // adicionarCliente1
            // 
            this.adicionarCliente1.BackColor = System.Drawing.Color.LightGray;
            this.adicionarCliente1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adicionarCliente1.Location = new System.Drawing.Point(311, 184);
            this.adicionarCliente1.Margin = new System.Windows.Forms.Padding(4);
            this.adicionarCliente1.Name = "adicionarCliente1";
            this.adicionarCliente1.Size = new System.Drawing.Size(415, 397);
            this.adicionarCliente1.TabIndex = 16;
            this.adicionarCliente1.Visible = false;
            // 
            // confirmarPedido1
            // 
            this.confirmarPedido1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmarPedido1.BackColor = System.Drawing.Color.LightGray;
            this.confirmarPedido1.BebidasSelecionadas = null;
            this.confirmarPedido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmarPedido1.Location = new System.Drawing.Point(307, 111);
            this.confirmarPedido1.Name = "confirmarPedido1";
            this.confirmarPedido1.PratosSelecionados = null;
            this.confirmarPedido1.Size = new System.Drawing.Size(419, 492);
            this.confirmarPedido1.TabIndex = 15;
            this.confirmarPedido1.Visible = false;
            // 
            // endereco1
            // 
            this.endereco1.BackColor = System.Drawing.Color.LightGray;
            this.endereco1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endereco1.Enabled = false;
            this.endereco1.Location = new System.Drawing.Point(270, 125);
            this.endereco1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endereco1.Name = "endereco1";
            this.endereco1.Size = new System.Drawing.Size(517, 470);
            this.endereco1.TabIndex = 21;
            this.endereco1.Visible = false;
            // 
            // criarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.endereco1);
            this.Controls.Add(this.bt_entrega);
            this.Controls.Add(this.pagamento1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adicionarCliente1);
            this.Controls.Add(this.confirmarPedido1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSlcCliente);
            this.Controls.Add(this.lb_nomeCliente);
            this.Controls.Add(this.labelcliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btConfirmarPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.bebidas_checkBoxList);
            this.Controls.Add(this.pratos_checkBoxList);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "criarPedido";
            this.Size = new System.Drawing.Size(1019, 649);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox pratos_checkBoxList;
        private System.Windows.Forms.CheckedListBox bebidas_checkBoxList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConfirmarPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelcliente;
        private System.Windows.Forms.Button btSlcCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private ConfirmarPedido confirmarPedido1;
        private AdicionarCliente adicionarCliente1;
        internal System.Windows.Forms.Label lb_nomeCliente;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label preco;
        public Pagamento pagamento1;
        private System.Windows.Forms.Button bt_entrega;
        private Endereco endereco1;
    }
}
