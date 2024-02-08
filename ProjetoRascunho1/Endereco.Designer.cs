namespace DeliciasCaseiras
{
    partial class Endereco
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
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_distrito = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_concelho = new System.Windows.Forms.TextBox();
            this.txt_codP = new System.Windows.Forms.TextBox();
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Entrega:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(183, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 26);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Loja";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(253, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 26);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Morada";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_n
            // 
            this.txt_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_n.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n.Location = new System.Drawing.Point(135, 181);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(336, 29);
            this.txt_n.TabIndex = 60;
            // 
            // txt_distrito
            // 
            this.txt_distrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_distrito.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_distrito.Location = new System.Drawing.Point(135, 217);
            this.txt_distrito.Name = "txt_distrito";
            this.txt_distrito.Size = new System.Drawing.Size(336, 29);
            this.txt_distrito.TabIndex = 61;
            // 
            // txt_rua
            // 
            this.txt_rua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rua.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(135, 145);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(336, 29);
            this.txt_rua.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "Cod-Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 65;
            this.label4.Text = "N. Porta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 66;
            this.label5.Text = "Concelho:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 67;
            this.label6.Text = "Distrito:";
            // 
            // txt_concelho
            // 
            this.txt_concelho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_concelho.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_concelho.Location = new System.Drawing.Point(135, 256);
            this.txt_concelho.Name = "txt_concelho";
            this.txt_concelho.Size = new System.Drawing.Size(336, 29);
            this.txt_concelho.TabIndex = 68;
            // 
            // txt_codP
            // 
            this.txt_codP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codP.Location = new System.Drawing.Point(135, 293);
            this.txt_codP.Name = "txt_codP";
            this.txt_codP.Size = new System.Drawing.Size(336, 29);
            this.txt_codP.TabIndex = 69;
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.BackColor = System.Drawing.Color.Red;
            this.bt_confirmar.FlatAppearance.BorderSize = 0;
            this.bt_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirmar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirmar.ForeColor = System.Drawing.Color.White;
            this.bt_confirmar.Location = new System.Drawing.Point(108, 362);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(141, 50);
            this.bt_confirmar.TabIndex = 70;
            this.bt_confirmar.Text = "Confirmar";
            this.bt_confirmar.UseVisualStyleBackColor = false;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Red;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(271, 362);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(141, 50);
            this.bt_cancelar.TabIndex = 71;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.Location = new System.Drawing.Point(173, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 37);
            this.label7.TabIndex = 72;
            this.label7.Text = "ENTREGA";
            // 
            // Endereco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.txt_codP);
            this.Controls.Add(this.txt_concelho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_distrito);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "Endereco";
            this.Size = new System.Drawing.Size(517, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txt_distrito;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_concelho;
        private System.Windows.Forms.TextBox txt_codP;
        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label7;
    }
}
