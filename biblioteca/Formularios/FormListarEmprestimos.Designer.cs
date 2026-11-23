namespace biblioteca.Formularios
{
    partial class FormListarEmprestimos
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
            dgvEmprestimos = new DataGridView();
            label3 = new Label();
            btFiltrar = new Button();
            label1 = new Label();
            label5 = new Label();
            txtCodEmprestimo = new TextBox();
            label4 = new Label();
            txtMatricula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).BeginInit();
            SuspendLayout();
            // 
            // dgvEmprestimos
            // 
            dgvEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprestimos.Location = new Point(12, 290);
            dgvEmprestimos.Name = "dgvEmprestimos";
            dgvEmprestimos.RowHeadersWidth = 51;
            dgvEmprestimos.Size = new Size(776, 150);
            dgvEmprestimos.TabIndex = 37;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(776, 48);
            label3.TabIndex = 36;
            label3.Text = "Filtros";
            // 
            // btFiltrar
            // 
            btFiltrar.Location = new Point(326, 237);
            btFiltrar.Name = "btFiltrar";
            btFiltrar.Size = new Size(169, 38);
            btFiltrar.TabIndex = 35;
            btFiltrar.Text = "Filtrar";
            btFiltrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(776, 48);
            label1.TabIndex = 34;
            label1.Text = "Listar Empréstimos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(427, 140);
            label5.Name = "label5";
            label5.Size = new Size(255, 31);
            label5.TabIndex = 33;
            label5.Text = "Código do empréstimo:";
            // 
            // txtCodEmprestimo
            // 
            txtCodEmprestimo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodEmprestimo.Location = new Point(427, 181);
            txtCodEmprestimo.Name = "txtCodEmprestimo";
            txtCodEmprestimo.Size = new Size(361, 38);
            txtCodEmprestimo.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 39;
            label4.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(12, 181);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(378, 38);
            txtMatricula.TabIndex = 38;
            // 
            // FormListarEmprestimos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtMatricula);
            Controls.Add(dgvEmprestimos);
            Controls.Add(label3);
            Controls.Add(btFiltrar);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(txtCodEmprestimo);
            Name = "FormListarEmprestimos";
            Text = "FormListarEmprestimos";
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmprestimos;
        private Label label3;
        private Button btFiltrar;
        private Label label1;
        private Label label5;
        private TextBox txtCodEmprestimo;
        private Label label4;
        private TextBox txtMatricula;
    }
}