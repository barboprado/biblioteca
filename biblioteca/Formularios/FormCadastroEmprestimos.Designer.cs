namespace biblioteca.Formularios
{
    partial class FormCadastroEmprestimos
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
            label6 = new Label();
            txtAutor = new TextBox();
            label5 = new Label();
            txtTitulo = new TextBox();
            btCancelar = new Button();
            btSalvar = new Button();
            label4 = new Label();
            txtGenero = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbLeitor = new ComboBox();
            cbLivro = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            txtQntDisponivel = new TextBox();
            label8 = new Label();
            txtMatricula = new TextBox();
            label9 = new Label();
            txtDataEmpr = new TextBox();
            label10 = new Label();
            dgvEmprestimo = new DataGridView();
            txtDataDevolPrevist = new TextBox();
            btAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimo).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(710, 44);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 42;
            label6.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAutor.Location = new Point(710, 75);
            txtAutor.Margin = new Padding(3, 2, 3, 2);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(233, 32);
            txtAutor.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 48);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 40;
            label5.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(357, 75);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(341, 32);
            txtTitulo.TabIndex = 39;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(627, 394);
            btCancelar.Margin = new Padding(3, 2, 3, 2);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(148, 28);
            btCancelar.TabIndex = 38;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(795, 394);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(148, 28);
            btSalvar.TabIndex = 37;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 108);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 36;
            label4.Text = "Genero:";
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGenero.Location = new Point(10, 139);
            txtGenero.Margin = new Padding(3, 2, 3, 2);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(218, 32);
            txtGenero.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(502, 112);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 34;
            label2.Text = "Selecione o leitor:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(933, 36);
            label1.TabIndex = 32;
            label1.Text = "Cadastrar Emprestimo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbLeitor
            // 
            cbLeitor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLeitor.FormattingEnabled = true;
            cbLeitor.Location = new Point(502, 138);
            cbLeitor.Margin = new Padding(3, 2, 3, 2);
            cbLeitor.Name = "cbLeitor";
            cbLeitor.Size = new Size(442, 33);
            cbLeitor.TabIndex = 43;
            cbLeitor.SelectedIndexChanged += cbLeitor_SelectedIndexChanged;
            // 
            // cbLivro
            // 
            cbLivro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLivro.FormattingEnabled = true;
            cbLivro.Location = new Point(10, 75);
            cbLivro.Margin = new Padding(3, 2, 3, 2);
            cbLivro.Name = "cbLivro";
            cbLivro.Size = new Size(329, 33);
            cbLivro.TabIndex = 44;
            cbLivro.SelectedIndexChanged += cbLivro_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 50);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 45;
            label3.Text = "Selecione o livro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(253, 108);
            label7.Name = "label7";
            label7.Size = new Size(209, 25);
            label7.TabIndex = 47;
            label7.Text = "Exemplares Disponiveis";
            // 
            // txtQntDisponivel
            // 
            txtQntDisponivel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQntDisponivel.Location = new Point(253, 139);
            txtQntDisponivel.Margin = new Padding(3, 2, 3, 2);
            txtQntDisponivel.Name = "txtQntDisponivel";
            txtQntDisponivel.Size = new Size(233, 32);
            txtQntDisponivel.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 168);
            label8.Name = "label8";
            label8.Size = new Size(176, 25);
            label8.TabIndex = 49;
            label8.Text = "Matricula do Leitor:";
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(10, 199);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(218, 32);
            txtMatricula.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(253, 169);
            label9.Name = "label9";
            label9.Size = new Size(187, 25);
            label9.TabIndex = 51;
            label9.Text = "Data do Emprestimo:";
            // 
            // txtDataEmpr
            // 
            txtDataEmpr.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDataEmpr.Location = new Point(253, 199);
            txtDataEmpr.Margin = new Padding(3, 2, 3, 2);
            txtDataEmpr.Name = "txtDataEmpr";
            txtDataEmpr.Size = new Size(233, 32);
            txtDataEmpr.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(502, 169);
            label10.Name = "label10";
            label10.Size = new Size(261, 25);
            label10.TabIndex = 53;
            label10.Text = "Data prevista para devolução:";
            // 
            // dgvEmprestimo
            // 
            dgvEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprestimo.Location = new Point(10, 243);
            dgvEmprestimo.Margin = new Padding(3, 2, 3, 2);
            dgvEmprestimo.Name = "dgvEmprestimo";
            dgvEmprestimo.RowHeadersWidth = 51;
            dgvEmprestimo.Size = new Size(933, 116);
            dgvEmprestimo.TabIndex = 54;
            // 
            // txtDataDevolPrevist
            // 
            txtDataDevolPrevist.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDataDevolPrevist.Location = new Point(502, 199);
            txtDataDevolPrevist.Margin = new Padding(3, 2, 3, 2);
            txtDataDevolPrevist.Name = "txtDataDevolPrevist";
            txtDataDevolPrevist.Size = new Size(233, 32);
            txtDataDevolPrevist.TabIndex = 55;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(795, 199);
            btAdicionar.Margin = new Padding(3, 2, 3, 2);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(148, 28);
            btAdicionar.TabIndex = 56;
            btAdicionar.Text = "Adicionar (+)";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // FormCadastroEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 432);
            Controls.Add(btAdicionar);
            Controls.Add(txtDataDevolPrevist);
            Controls.Add(dgvEmprestimo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtDataEmpr);
            Controls.Add(label8);
            Controls.Add(txtMatricula);
            Controls.Add(label7);
            Controls.Add(txtQntDisponivel);
            Controls.Add(label3);
            Controls.Add(cbLivro);
            Controls.Add(cbLeitor);
            Controls.Add(label6);
            Controls.Add(txtAutor);
            Controls.Add(label5);
            Controls.Add(txtTitulo);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label4);
            Controls.Add(txtGenero);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroEmprestimos";
            Text = "CadastroEmprestimos";
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtAutor;
        private Label label5;
        private TextBox txtTitulo;
        private Button btCancelar;
        private Button btSalvar;
        private Label label4;
        private TextBox txtGenero;
        private Label label2;
        private Label label1;
        private ComboBox cbLeitor;
        private ComboBox cbLivro;
        private Label label3;
        private Label label7;
        private TextBox txtQntDisponivel;
        private Label label8;
        private TextBox txtMatricula;
        private Label label9;
        private TextBox txtDataEmpr;
        private Label label10;
        private DataGridView dgvEmprestimo;
        private TextBox txtDataDevolPrevist;
        private Button btAdicionar;
    }
}