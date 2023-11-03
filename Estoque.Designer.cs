namespace ProjetoIntegrado
{
    partial class Estoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewEstoque = new DataGridView();
            bntInserir = new Button();
            btnEditar = new Button();
            btnAtualizar = new Button();
            label1 = new Label();
            btnBaixaMaterial = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewEstoque.BackgroundColor = Color.DarkSlateGray;
            dataGridViewEstoque.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewEstoque.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEstoque.GridColor = Color.DarkSlateGray;
            dataGridViewEstoque.Location = new Point(15, 118);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.ReadOnly = true;
            dataGridViewEstoque.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEstoque.RowHeadersVisible = false;
            dataGridViewEstoque.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewEstoque.RowTemplate.Height = 29;
            dataGridViewEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEstoque.Size = new Size(839, 297);
            dataGridViewEstoque.TabIndex = 0;
            // 
            // bntInserir
            // 
            bntInserir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bntInserir.BackColor = Color.Blue;
            bntInserir.Location = new Point(14, 456);
            bntInserir.Margin = new Padding(3, 4, 3, 4);
            bntInserir.Name = "bntInserir";
            bntInserir.Size = new Size(133, 52);
            bntInserir.TabIndex = 1;
            bntInserir.Text = "Inserir";
            bntInserir.UseVisualStyleBackColor = false;
            bntInserir.Click += bntInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.Green;
            btnEditar.Location = new Point(182, 456);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(133, 52);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtualizar.BackColor = Color.DarkGray;
            btnAtualizar.Location = new Point(343, 456);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(133, 52);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar Lista";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(249, 57);
            label1.Name = "label1";
            label1.Size = new Size(384, 35);
            label1.TabIndex = 4;
            label1.Text = "Controle de Estoque de Materiais";
            // 
            // btnBaixaMaterial
            // 
            btnBaixaMaterial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBaixaMaterial.BackColor = Color.Yellow;
            btnBaixaMaterial.Location = new Point(500, 456);
            btnBaixaMaterial.Margin = new Padding(3, 4, 3, 4);
            btnBaixaMaterial.Name = "btnBaixaMaterial";
            btnBaixaMaterial.Size = new Size(154, 52);
            btnBaixaMaterial.TabIndex = 5;
            btnBaixaMaterial.Text = "Baixa de material";
            btnBaixaMaterial.UseVisualStyleBackColor = false;
            btnBaixaMaterial.Click += btnBaixaMaterial_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(866, 527);
            Controls.Add(btnBaixaMaterial);
            Controls.Add(label1);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEditar);
            Controls.Add(bntInserir);
            Controls.Add(dataGridViewEstoque);
            Name = "Estoque";
            Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEstoque;
        private Button bntInserir;
        private Button btnEditar;
        private Button btnAtualizar;
        private Label label1;
        private Button btnBaixaMaterial;
    }
}