namespace ProjetoIntegrado
{
    partial class TelaMaterial
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            txtProdutoNome = new TextBox();
            txtQtdEntrada = new TextBox();
            txtValorMaterial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSaldo = new TextBox();
            label4 = new Label();
            txtIdProduto = new TextBox();
            label6 = new Label();
            txtValorTotalMaterial = new TextBox();
            label5 = new Label();
            txtDataUltimaEntrada = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Blue;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(183, 526);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(168, 61);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += button1_Click;
            // 
            // txtProdutoNome
            // 
            txtProdutoNome.Location = new Point(208, 61);
            txtProdutoNome.Margin = new Padding(3, 4, 3, 4);
            txtProdutoNome.Multiline = true;
            txtProdutoNome.Name = "txtProdutoNome";
            txtProdutoNome.Size = new Size(290, 39);
            txtProdutoNome.TabIndex = 1;
            // 
            // txtQtdEntrada
            // 
            txtQtdEntrada.Location = new Point(330, 138);
            txtQtdEntrada.Margin = new Padding(3, 4, 3, 4);
            txtQtdEntrada.Multiline = true;
            txtQtdEntrada.Name = "txtQtdEntrada";
            txtQtdEntrada.Size = new Size(167, 39);
            txtQtdEntrada.TabIndex = 2;
            // 
            // txtValorMaterial
            // 
            txtValorMaterial.Location = new Point(330, 215);
            txtValorMaterial.Margin = new Padding(3, 4, 3, 4);
            txtValorMaterial.Multiline = true;
            txtValorMaterial.Name = "txtValorMaterial";
            txtValorMaterial.Size = new Size(167, 39);
            txtValorMaterial.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 63);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 140);
            label2.Name = "label2";
            label2.Size = new Size(222, 37);
            label2.TabIndex = 5;
            label2.Text = "Quantidade Entrada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 220);
            label3.Name = "label3";
            label3.Size = new Size(174, 35);
            label3.TabIndex = 6;
            label3.Text = "Valor Material:";
            // 
            // txtSaldo
            // 
            txtSaldo.Enabled = false;
            txtSaldo.Location = new Point(330, 289);
            txtSaldo.Margin = new Padding(3, 4, 3, 4);
            txtSaldo.Multiline = true;
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(167, 39);
            txtSaldo.TabIndex = 8;
            txtSaldo.Text = "0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 293);
            label4.Name = "label4";
            label4.Size = new Size(82, 35);
            label4.TabIndex = 9;
            label4.Text = "Saldo:";
            // 
            // txtIdProduto
            // 
            txtIdProduto.Location = new Point(14, 15);
            txtIdProduto.Margin = new Padding(3, 4, 3, 4);
            txtIdProduto.Multiline = true;
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(167, 39);
            txtIdProduto.TabIndex = 10;
            txtIdProduto.Text = "1";
            txtIdProduto.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(31, 367);
            label6.Name = "label6";
            label6.Size = new Size(276, 35);
            label6.TabIndex = 12;
            label6.Text = "Valor Total em Material:";
            // 
            // txtValorTotalMaterial
            // 
            txtValorTotalMaterial.Enabled = false;
            txtValorTotalMaterial.Location = new Point(330, 365);
            txtValorTotalMaterial.Margin = new Padding(3, 4, 3, 4);
            txtValorTotalMaterial.Multiline = true;
            txtValorTotalMaterial.Name = "txtValorTotalMaterial";
            txtValorTotalMaterial.Size = new Size(167, 39);
            txtValorTotalMaterial.TabIndex = 13;
            txtValorTotalMaterial.Text = "0,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(31, 449);
            label5.Name = "label5";
            label5.Size = new Size(243, 35);
            label5.TabIndex = 14;
            label5.Text = "Data Ultima Entrada:";
            // 
            // txtDataUltimaEntrada
            // 
            txtDataUltimaEntrada.Enabled = false;
            txtDataUltimaEntrada.Location = new Point(330, 445);
            txtDataUltimaEntrada.Margin = new Padding(3, 4, 3, 4);
            txtDataUltimaEntrada.Multiline = true;
            txtDataUltimaEntrada.Name = "txtDataUltimaEntrada";
            txtDataUltimaEntrada.Size = new Size(167, 39);
            txtDataUltimaEntrada.TabIndex = 15;
            // 
            // TelaMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(566, 600);
            Controls.Add(txtDataUltimaEntrada);
            Controls.Add(label5);
            Controls.Add(txtValorTotalMaterial);
            Controls.Add(label6);
            Controls.Add(txtIdProduto);
            Controls.Add(label4);
            Controls.Add(txtSaldo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValorMaterial);
            Controls.Add(txtQtdEntrada);
            Controls.Add(txtProdutoNome);
            Controls.Add(btnSalvar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaMaterial";
            Text = "TelaMaterial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txtProdutoNome;
        public TextBox txtQtdEntrada;
        public TextBox txtValorMaterial;
        public TextBox txtSaldo;
        private Label label4;
        public TextBox txtIdProduto;
        private Label label6;
        public TextBox txtValorTotalMaterial;
        private Label label5;
        public TextBox txtDataUltimaEntrada;
    }
}