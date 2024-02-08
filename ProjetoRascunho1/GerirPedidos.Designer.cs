namespace DeliciasCaseiras
{
    partial class GerirPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.bt_altEstado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_filtrarEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_estados = new System.Windows.Forms.ComboBox();
            this.cb_lucroHoje = new System.Windows.Forms.CheckBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 84);
            this.panel1.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(334, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gerenciar Pedidos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.data_pedido,
            this.dataPrevista,
            this.estado,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPedidos.EnableHeadersVisualStyles = false;
            this.dataGridViewPedidos.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(54, 112);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(913, 304);
            this.dataGridViewPedidos.TabIndex = 53;
            // 
            // bt_altEstado
            // 
            this.bt_altEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            this.bt_altEstado.FlatAppearance.BorderSize = 0;
            this.bt_altEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_altEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_altEstado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_altEstado.Location = new System.Drawing.Point(41, 108);
            this.bt_altEstado.Name = "bt_altEstado";
            this.bt_altEstado.Size = new System.Drawing.Size(143, 46);
            this.bt_altEstado.TabIndex = 54;
            this.bt_altEstado.Text = "Alterar!";
            this.bt_altEstado.UseVisualStyleBackColor = false;
            this.bt_altEstado.Click += new System.EventHandler(this.bt_altEstado_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Filtrar Por: ";
            // 
            // cb_filtrarEstado
            // 
            this.cb_filtrarEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_filtrarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtrarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filtrarEstado.Font = new System.Drawing.Font("Arial", 12F);
            this.cb_filtrarEstado.FormattingEnabled = true;
            this.cb_filtrarEstado.Location = new System.Drawing.Point(142, 422);
            this.cb_filtrarEstado.Name = "cb_filtrarEstado";
            this.cb_filtrarEstado.Size = new System.Drawing.Size(133, 26);
            this.cb_filtrarEstado.TabIndex = 56;
            this.cb_filtrarEstado.SelectedIndexChanged += new System.EventHandler(this.cb_filtrarEstado_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cB_estados);
            this.groupBox1.Controls.Add(this.bt_altEstado);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(743, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 182);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALTERAR ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Selecione o estado:";
            // 
            // cB_estados
            // 
            this.cB_estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_estados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_estados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_estados.FormattingEnabled = true;
            this.cB_estados.Location = new System.Drawing.Point(40, 59);
            this.cB_estados.Name = "cB_estados";
            this.cB_estados.Size = new System.Drawing.Size(143, 26);
            this.cB_estados.TabIndex = 55;
            // 
            // cb_lucroHoje
            // 
            this.cb_lucroHoje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_lucroHoje.AutoSize = true;
            this.cb_lucroHoje.Font = new System.Drawing.Font("Arial", 12F);
            this.cb_lucroHoje.Location = new System.Drawing.Point(290, 426);
            this.cb_lucroHoje.Name = "cb_lucroHoje";
            this.cb_lucroHoje.Size = new System.Drawing.Size(273, 22);
            this.cb_lucroHoje.TabIndex = 59;
            this.cb_lucroHoje.Text = "Apenas pedidos para entregar hoje";
            this.cb_lucroHoje.UseVisualStyleBackColor = true;
            this.cb_lucroHoje.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.FillWeight = 181.5902F;
            this.Column3.HeaderText = "ID Pedido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.FillWeight = 251.2691F;
            this.Column1.HeaderText = "ID Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.FillWeight = 66.7344F;
            this.Column2.HeaderText = "Nome Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.FillWeight = 66.7344F;
            this.Column4.HeaderText = "Valor Pago";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
            // 
            // data_pedido
            // 
            this.data_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.data_pedido.FillWeight = 66.7344F;
            this.data_pedido.HeaderText = "Data Pedido";
            this.data_pedido.Name = "data_pedido";
            this.data_pedido.ReadOnly = true;
            this.data_pedido.Width = 145;
            // 
            // dataPrevista
            // 
            this.dataPrevista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataPrevista.FillWeight = 66.7344F;
            this.dataPrevista.HeaderText = "DataPrevista";
            this.dataPrevista.Name = "dataPrevista";
            this.dataPrevista.ReadOnly = true;
            this.dataPrevista.Width = 145;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado.FillWeight = 66.7344F;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 66.7344F;
            this.Column5.HeaderText = "Bebidas";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 66.7344F;
            this.Column6.HeaderText = "Pratos";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // GerirPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cb_lucroHoje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_filtrarEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.panel1);
            this.Name = "GerirPedidos";
            this.Size = new System.Drawing.Size(1019, 649);
            this.Load += new System.EventHandler(this.GerirPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button bt_altEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_filtrarEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_estados;
        private System.Windows.Forms.CheckBox cb_lucroHoje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
