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
            label6.Location = new Point(811, 59);
            label6.Name = "label6";
            label6.Size = new Size(76, 31);
            label6.TabIndex = 42;
            label6.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAutor.Location = new Point(811, 100);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(266, 38);
            txtAutor.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(408, 64);
            label5.Name = "label5";
            label5.Size = new Size(77, 31);
            label5.TabIndex = 40;
            label5.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(408, 100);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(389, 38);
            txtTitulo.TabIndex = 39;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(717, 525);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(169, 37);
            btCancelar.TabIndex = 38;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(909, 525);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(169, 37);
            btSalvar.TabIndex = 37;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 144);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 36;
            label4.Text = "Genero:";
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGenero.Location = new Point(11, 185);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(249, 38);
            txtGenero.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(574, 149);
            label2.Name = "label2";
            label2.Size = new Size(194, 31);
            label2.TabIndex = 34;
            label2.Text = "Selecione o leitor:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(1066, 48);
            label1.TabIndex = 32;
            label1.Text = "Cadastrar Emprestimo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbLeitor
            // 
            cbLeitor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLeitor.FormattingEnabled = true;
            cbLeitor.Location = new Point(574, 184);
            cbLeitor.Name = "cbLeitor";
            cbLeitor.Size = new Size(505, 39);
            cbLeitor.TabIndex = 43;
            cbLeitor.SelectedIndexChanged += cbLeitor_SelectedIndexChanged;
            // 
            // cbLivro
            // 
            cbLivro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLivro.FormattingEnabled = true;
            cbLivro.Location = new Point(11, 100);
            cbLivro.Name = "cbLivro";
            cbLivro.Size = new Size(375, 39);
            cbLivro.TabIndex = 44;
            cbLivro.SelectedIndexChanged += cbLivro_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 67);
            label3.Name = "label3";
            label3.Size = new Size(185, 31);
            label3.TabIndex = 45;
            label3.Text = "Selecione o livro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(289, 144);
            label7.Name = "label7";
            label7.Size = new Size(254, 31);
            label7.TabIndex = 47;
            label7.Text = "Exemplares Disponiveis";
            // 
            // txtQntDisponivel
            // 
            txtQntDisponivel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQntDisponivel.Location = new Point(289, 185);
            txtQntDisponivel.Name = "txtQntDisponivel";
            txtQntDisponivel.Size = new Size(266, 38);
            txtQntDisponivel.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 224);
            label8.Name = "label8";
            label8.Size = new Size(213, 31);
            label8.TabIndex = 49;
            label8.Text = "Matricula do Leitor:";
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatricula.Location = new Point(11, 265);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(249, 38);
            txtMatricula.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(289, 225);
            label9.Name = "label9";
            label9.Size = new Size(229, 31);
            label9.TabIndex = 51;
            label9.Text = "Data do Emprestimo:";
            // 
            // txtDataEmpr
            // 
            txtDataEmpr.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDataEmpr.Location = new Point(289, 265);
            txtDataEmpr.Name = "txtDataEmpr";
            txtDataEmpr.Size = new Size(266, 38);
            txtDataEmpr.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(574, 225);
            label10.Name = "label10";
            label10.Size = new Size(317, 31);
            label10.TabIndex = 53;
            label10.Text = "Data prevista para devolução:";
            // 
            // dgvEmprestimo
            // 
            dgvEmprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprestimo.Location = new Point(11, 324);
            dgvEmprestimo.Name = "dgvEmprestimo";
            dgvEmprestimo.RowHeadersWidth = 51;
            dgvEmprestimo.Size = new Size(1066, 155);
            dgvEmprestimo.TabIndex = 54;
            // 
            // txtDataDevolPrevist
            // 
            txtDataDevolPrevist.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDataDevolPrevist.Location = new Point(574, 265);
            txtDataDevolPrevist.Name = "txtDataDevolPrevist";
            txtDataDevolPrevist.Size = new Size(266, 38);
            txtDataDevolPrevist.TabIndex = 55;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(909, 265);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(169, 37);
            btAdicionar.TabIndex = 56;
            btAdicionar.Text = "Adicionar (+)";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // FormCadastroEmprestimos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 576);
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