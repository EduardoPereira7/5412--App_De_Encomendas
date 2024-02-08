namespace DeliciasCaseiras
{
    partial class AdicionarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_clientes = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Já é cliente?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(170, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 26);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(237, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 26);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente: ";
            // 
            // comboBox_clientes
            // 
            this.comboBox_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_clientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_clientes.FormattingEnabled = true;
            this.comboBox_clientes.Location = new System.Drawing.Point(141, 94);
            this.comboBox_clientes.Name = "comboBox_clientes";
            this.comboBox_clientes.Size = new System.Drawing.Size(226, 26);
            this.comboBox_clientes.TabIndex = 4;
            this.comboBox_clientes.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(170, 126);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 29);
            this.txtNome.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(170, 164);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(173, 29);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(170, 199);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(173, 29);
            this.txtTelefone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone:";
            // 
            // bt_ok
            // 
            this.bt_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_ok.BackColor = System.Drawing.Color.Red;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ok.Font = new System.Drawing.Font("Arial", 15F);
            this.bt_ok.ForeColor = System.Drawing.Color.SeaShell;
            this.bt_ok.Location = new System.Drawing.Point(124, 284);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(175, 40);
            this.bt_ok.TabIndex = 13;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Visible = false;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_confirmar.BackColor = System.Drawing.Color.Red;
            this.bt_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirmar.Font = new System.Drawing.Font("Arial", 15F);
            this.bt_confirmar.ForeColor = System.Drawing.Color.SeaShell;
            this.bt_confirmar.Location = new System.Drawing.Point(124, 284);
            this.bt_confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(175, 40);
            this.bt_confirmar.TabIndex = 14;
            this.bt_confirmar.Text = "Criar e Confirmar";
            this.bt_confirmar.UseVisualStyleBackColor = false;
            this.bt_confirmar.Visible = false;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cancelar.BackColor = System.Drawing.Color.Red;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 15F);
            this.bt_cancelar.ForeColor = System.Drawing.Color.SeaShell;
            this.bt_cancelar.Location = new System.Drawing.Point(124, 332);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(175, 40);
            this.bt_cancelar.TabIndex = 15;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // AdicionarCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.comboBox_clientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarCliente";
            this.Size = new System.Drawing.Size(415, 397);
            this.Load += new System.EventHandler(this.AdicionarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_clientes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}
