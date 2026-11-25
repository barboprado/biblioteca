namespace biblioteca.Formularios
{
    partial class FormCadastroLivros
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
            label1 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAutor = new TextBox();
            label4 = new Label();
            txtQtdDisponivel = new TextBox();
            btSalvar = new Button();
            btCancelar = new Button();
            label5 = new Label();
            txtGenero = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(679, 36);
            label1.TabIndex = 10;
            label1.Text = "Cadastrar Livros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(10, 112);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(680, 32);
            txtTitulo.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 81);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 12;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 142);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 14;
            label3.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAutor.Location = new Point(10, 173);
            txtAutor.Margin = new Padding(3, 2, 3, 2);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(442, 32);
            txtAutor.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(472, 142);
            label4.Name = "label4";
            label4.Size = new Size(205, 25);
            label4.TabIndex = 16;
            label4.Text = "Exemplares Diponiveis:";
            // 
            // txtQtdDisponivel
            // 
            txtQtdDisponivel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtdDisponivel.Location = new Point(472, 173);
            txtQtdDisponivel.Margin = new Padding(3, 2, 3, 2);
            txtQtdDisponivel.Name = "txtQtdDisponivel";
            txtQtdDisponivel.Size = new Size(218, 32);
            txtQtdDisponivel.TabIndex = 15;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(542, 300);
            btSalvar.Margin = new Padding(3, 2, 3, 2);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(148, 28);
            btSalvar.TabIndex = 17;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(374, 300);
            btCancelar.Margin = new Padding(3, 2, 3, 2);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(148, 28);
            btCancelar.TabIndex = 18;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 204);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 20;
            label5.Text = "Genêro:";
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGenero.Location = new Point(10, 235);
            txtGenero.Margin = new Padding(3, 2, 3, 2);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(680, 32);
            txtGenero.TabIndex = 19;
            // 
            // FormCadastroLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(txtGenero);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label4);
            Controls.Add(txtQtdDisponivel);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroLivros";
            Text = "CadastroLivros";
            Load += FormCadastroLivros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitulo;
        private Label label2;
        private Label label3;
        private TextBox txtAutor;
        private Label label4;
        private TextBox txtQtdDisponivel;
        private Button btSalvar;
        private Button btCancelar;
        private Label label5;
        private TextBox txtGenero;
    }
}