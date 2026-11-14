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
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            btCancelar = new Button();
            btSalvar = new Button();
            label4 = new Label();
            txtQtdDisponivel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            cbLivro = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            textBox6 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(812, 59);
            label6.Name = "label6";
            label6.Size = new Size(76, 31);
            label6.TabIndex = 42;
            label6.Text = "Autor:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(812, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 38);
            textBox2.TabIndex = 41;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(408, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 38);
            textBox1.TabIndex = 39;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(717, 526);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(169, 38);
            btCancelar.TabIndex = 38;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(909, 526);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(169, 38);
            btSalvar.TabIndex = 37;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 36;
            label4.Text = "Genero:";
            // 
            // txtQtdDisponivel
            // 
            txtQtdDisponivel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtdDisponivel.Location = new Point(12, 185);
            txtQtdDisponivel.Name = "txtQtdDisponivel";
            txtQtdDisponivel.Size = new Size(249, 38);
            txtQtdDisponivel.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(574, 150);
            label2.Name = "label2";
            label2.Size = new Size(194, 31);
            label2.TabIndex = 34;
            label2.Text = "Selecione o leitor:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(1066, 48);
            label1.TabIndex = 32;
            label1.Text = "Cadastrar Emprestimo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(574, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(504, 39);
            comboBox1.TabIndex = 43;
            // 
            // cbLivro
            // 
            cbLivro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLivro.FormattingEnabled = true;
            cbLivro.Location = new Point(12, 100);
            cbLivro.Name = "cbLivro";
            cbLivro.Size = new Size(375, 39);
            cbLivro.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 66);
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(289, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 38);
            textBox3.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 224);
            label8.Name = "label8";
            label8.Size = new Size(213, 31);
            label8.TabIndex = 49;
            label8.Text = "Matricula do Leitor:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(12, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 38);
            textBox4.TabIndex = 48;
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
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(289, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(266, 38);
            textBox5.TabIndex = 50;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1066, 154);
            dataGridView1.TabIndex = 54;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(574, 265);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(266, 38);
            textBox6.TabIndex = 55;
            // 
            // button1
            // 
            button1.Location = new Point(909, 265);
            button1.Name = "button1";
            button1.Size = new Size(169, 38);
            button1.TabIndex = 56;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormCadastroEmprestimos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 576);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(cbLivro);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label4);
            Controls.Add(txtQtdDisponivel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastroEmprestimos";
            Text = "CadastroEmprestimos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Button btCancelar;
        private Button btSalvar;
        private Label label4;
        private TextBox txtQtdDisponivel;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox cbLivro;
        private Label label3;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private Button button1;
    }
}