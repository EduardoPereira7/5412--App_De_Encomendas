namespace DeliciasCaseiras
{
    partial class Lucro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_fim = new System.Windows.Forms.DateTimePicker();
            this.dateTime_inicio = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_totalCliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_nPedidos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 84);
            this.panel1.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(363, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consultar Valores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Valor total de vendas:";
            // 
            // dateTime_fim
            // 
            this.dateTime_fim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTime_fim.Font = new System.Drawing.Font("Arial", 11.25F);
            this.dateTime_fim.Location = new System.Drawing.Point(170, 101);
            this.dateTime_fim.Name = "dateTime_fim";
            this.dateTime_fim.Size = new System.Drawing.Size(200, 25);
            this.dateTime_fim.TabIndex = 55;
            this.dateTime_fim.ValueChanged += new System.EventHandler(this.dateTime_fim_ValueChanged);
            // 
            // dateTime_inicio
            // 
            this.dateTime_inicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTime_inicio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_inicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime_inicio.Location = new System.Drawing.Point(170, 48);
            this.dateTime_inicio.Name = "dateTime_inicio";
            this.dateTime_inicio.Size = new System.Drawing.Size(200, 25);
            this.dateTime_inicio.TabIndex = 56;
            this.dateTime_inicio.ValueChanged += new System.EventHandler(this.dateTime_inicio_ValueChanged);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClientes.EnableHeadersVisualStyles = false;
            this.dataGridViewClientes.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewClientes.Location = new System.Drawing.Point(74, 171);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(407, 270);
            this.dataGridViewClientes.TabIndex = 57;
            this.dataGridViewClientes.SelectionChanged += new System.EventHandler(this.dataGridViewClientes_SelectionChanged);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.valor_pedido,
            this.data_pedido});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewPedidos.EnableHeadersVisualStyles = false;
            this.dataGridViewPedidos.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(536, 171);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(407, 270);
            this.dataGridViewPedidos.TabIndex = 58;
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "ID Pedido";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.ReadOnly = true;
            // 
            // valor_pedido
            // 
            this.valor_pedido.HeaderText = "Valor Pago";
            this.valor_pedido.Name = "valor_pedido";
            this.valor_pedido.ReadOnly = true;
            // 
            // data_pedido
            // 
            this.data_pedido.HeaderText = "Data ";
            this.data_pedido.Name = "data_pedido";
            this.data_pedido.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Cliente:";
            // 
            // lb_cliente
            // 
            this.lb_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lb_cliente.Location = new System.Drawing.Point(106, 38);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(15, 22);
            this.lb_cliente.TabIndex = 60;
            this.lb_cliente.Text = ".";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Arial", 14.25F);
            this.total.Location = new System.Drawing.Point(270, 116);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(61, 22);
            this.total.TabIndex = 61;
            this.total.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTime_inicio);
            this.groupBox1.Controls.Add(this.dateTime_fim);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(457, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 151);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por data";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(42, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Data de fim:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.Location = new System.Drawing.Point(25, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 63;
            this.label4.Text = "Data de início:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.Location = new System.Drawing.Point(26, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "Valor total:";
            // 
            // lb_totalCliente
            // 
            this.lb_totalCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_totalCliente.AutoSize = true;
            this.lb_totalCliente.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lb_totalCliente.Location = new System.Drawing.Point(130, 75);
            this.lb_totalCliente.Name = "lb_totalCliente";
            this.lb_totalCliente.Size = new System.Drawing.Size(15, 22);
            this.lb_totalCliente.TabIndex = 64;
            this.lb_totalCliente.Text = ".";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.Location = new System.Drawing.Point(26, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 22);
            this.label7.TabIndex = 65;
            this.label7.Text = "Numero de pedidos:";
            // 
            // lb_nPedidos
            // 
            this.lb_nPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nPedidos.AutoSize = true;
            this.lb_nPedidos.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lb_nPedidos.Location = new System.Drawing.Point(215, 112);
            this.lb_nPedidos.Name = "lb_nPedidos";
            this.lb_nPedidos.Size = new System.Drawing.Size(15, 22);
            this.lb_nPedidos.TabIndex = 66;
            this.lb_nPedidos.Text = ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lb_nPedidos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_cliente);
            this.groupBox2.Controls.Add(this.lb_totalCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(74, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 169);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do intervalo";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 251.2691F;
            this.Column1.HeaderText = "ID Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 101;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 66.7344F;
            this.Column2.HeaderText = "Nome Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Lucro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Lucro";
            this.Size = new System.Drawing.Size(1019, 649);
            this.Load += new System.EventHandler(this.Lucro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_fim;
        private System.Windows.Forms.DateTimePicker dateTime_inicio;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_totalCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_nPedidos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
