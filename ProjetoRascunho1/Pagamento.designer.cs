
namespace DeliciasCaseiras
{
    partial class Pagamento
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
            this.comboBoxPagamentos = new System.Windows.Forms.ComboBox();
            this.pagOnline = new System.Windows.Forms.RadioButton();
            this.dinheiroEntregueLabel = new System.Windows.Forms.Label();
            this.trocoLabel = new System.Windows.Forms.Label();
            this.lb_troco = new System.Windows.Forms.Label();
            this.txt_dinheiro = new System.Windows.Forms.TextBox();
            this.metodoPagLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_precoFinal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bt_pagar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPagamentos
            // 
            this.comboBoxPagamentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPagamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPagamentos.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPagamentos.FormattingEnabled = true;
            this.comboBoxPagamentos.Location = new System.Drawing.Point(227, 181);
            this.comboBoxPagamentos.Name = "comboBoxPagamentos";
            this.comboBoxPagamentos.Size = new System.Drawing.Size(150, 27);
            this.comboBoxPagamentos.TabIndex = 52;
            this.comboBoxPagamentos.Visible = false;
            // 
            // pagOnline
            // 
            this.pagOnline.AutoSize = true;
            this.pagOnline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagOnline.Location = new System.Drawing.Point(138, 80);
            this.pagOnline.Name = "pagOnline";
            this.pagOnline.Size = new System.Drawing.Size(70, 22);
            this.pagOnline.TabIndex = 53;
            this.pagOnline.TabStop = true;
            this.pagOnline.Text = "Online";
            this.pagOnline.UseVisualStyleBackColor = true;
            this.pagOnline.CheckedChanged += new System.EventHandler(this.pagOnline_CheckedChanged);
            // 
            // dinheiroEntregueLabel
            // 
            this.dinheiroEntregueLabel.AutoSize = true;
            this.dinheiroEntregueLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.dinheiroEntregueLabel.Location = new System.Drawing.Point(47, 181);
            this.dinheiroEntregueLabel.Name = "dinheiroEntregueLabel";
            this.dinheiroEntregueLabel.Size = new System.Drawing.Size(167, 22);
            this.dinheiroEntregueLabel.TabIndex = 56;
            this.dinheiroEntregueLabel.Text = "Dinheiro Entregue:";
            this.dinheiroEntregueLabel.Visible = false;
            // 
            // trocoLabel
            // 
            this.trocoLabel.AutoSize = true;
            this.trocoLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.trocoLabel.Location = new System.Drawing.Point(160, 234);
            this.trocoLabel.Name = "trocoLabel";
            this.trocoLabel.Size = new System.Drawing.Size(64, 22);
            this.trocoLabel.TabIndex = 57;
            this.trocoLabel.Text = "Troco:";
            this.trocoLabel.Visible = false;
            // 
            // lb_troco
            // 
            this.lb_troco.AutoSize = true;
            this.lb_troco.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lb_troco.Location = new System.Drawing.Point(230, 234);
            this.lb_troco.Name = "lb_troco";
            this.lb_troco.Size = new System.Drawing.Size(32, 22);
            this.lb_troco.TabIndex = 58;
            this.lb_troco.Text = "0€";
            this.lb_troco.Visible = false;
            // 
            // txt_dinheiro
            // 
            this.txt_dinheiro.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinheiro.Location = new System.Drawing.Point(232, 179);
            this.txt_dinheiro.Name = "txt_dinheiro";
            this.txt_dinheiro.Size = new System.Drawing.Size(150, 27);
            this.txt_dinheiro.TabIndex = 59;
            this.txt_dinheiro.Text = "0";
            this.txt_dinheiro.Visible = false;
            this.txt_dinheiro.TextChanged += new System.EventHandler(this.txt_dinherio_TextChanged);
            // 
            // metodoPagLabel
            // 
            this.metodoPagLabel.AutoSize = true;
            this.metodoPagLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.metodoPagLabel.Location = new System.Drawing.Point(20, 183);
            this.metodoPagLabel.Name = "metodoPagLabel";
            this.metodoPagLabel.Size = new System.Drawing.Size(206, 22);
            this.metodoPagLabel.TabIndex = 60;
            this.metodoPagLabel.Text = "Método de pagamento:";
            this.metodoPagLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(136, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 63;
            this.label5.Text = "Preço Final:";
            // 
            // lb_precoFinal
            // 
            this.lb_precoFinal.AutoSize = true;
            this.lb_precoFinal.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lb_precoFinal.Location = new System.Drawing.Point(253, 131);
            this.lb_precoFinal.Name = "lb_precoFinal";
            this.lb_precoFinal.Size = new System.Drawing.Size(0, 22);
            this.lb_precoFinal.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pagamento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 65;
            this.label6.Text = "Pagamento:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(219, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 22);
            this.radioButton1.TabIndex = 66;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Caixa";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // bt_pagar
            // 
            this.bt_pagar.BackColor = System.Drawing.Color.Red;
            this.bt_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pagar.Font = new System.Drawing.Font("Arial", 15F);
            this.bt_pagar.ForeColor = System.Drawing.Color.White;
            this.bt_pagar.Location = new System.Drawing.Point(139, 286);
            this.bt_pagar.Name = "bt_pagar";
            this.bt_pagar.Size = new System.Drawing.Size(150, 40);
            this.bt_pagar.TabIndex = 67;
            this.bt_pagar.Text = "Pagar";
            this.bt_pagar.UseVisualStyleBackColor = false;
            this.bt_pagar.Click += new System.EventHandler(this.bt_pagar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Red;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 15F);
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(139, 342);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(150, 41);
            this.bt_cancelar.TabIndex = 68;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // Pagamento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_pagar);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_precoFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.metodoPagLabel);
            this.Controls.Add(this.txt_dinheiro);
            this.Controls.Add(this.lb_troco);
            this.Controls.Add(this.trocoLabel);
            this.Controls.Add(this.dinheiroEntregueLabel);
            this.Controls.Add(this.pagOnline);
            this.Controls.Add(this.comboBoxPagamentos);
            this.Name = "Pagamento";
            this.Size = new System.Drawing.Size(419, 430);
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPagamentos;
        private System.Windows.Forms.RadioButton pagOnline;
        private System.Windows.Forms.Label dinheiroEntregueLabel;
        private System.Windows.Forms.Label trocoLabel;
        private System.Windows.Forms.Label lb_troco;
        private System.Windows.Forms.TextBox txt_dinheiro;
        private System.Windows.Forms.Label metodoPagLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button bt_pagar;
        private System.Windows.Forms.Button bt_cancelar;
        public System.Windows.Forms.Label lb_precoFinal;
    }
}
