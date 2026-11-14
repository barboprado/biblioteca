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
            this.txtTitulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            this.txtAutor = new TextBox();
            label4 = new Label();
            this.txtQtdDisponivel = new TextBox();
            btSalvar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 48);
            label1.TabIndex = 10;
            label1.Text = "Cadastrar Livros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTitulo.Location = new Point(12, 149);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new Size(776, 38);
            this.txtTitulo.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 12;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 14;
            label3.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAutor.Location = new Point(12, 231);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new Size(504, 38);
            this.txtAutor.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(539, 190);
            label4.Name = "label4";
            label4.Size = new Size(249, 31);
            label4.TabIndex = 16;
            label4.Text = "Exemplares Diponiveis:";
            // 
            // txtQtdDisponivel
            // 
            this.txtQtdDisponivel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtQtdDisponivel.Location = new Point(539, 231);
            this.txtQtdDisponivel.Name = "txtQtdDisponivel";
            this.txtQtdDisponivel.Size = new Size(249, 38);
            this.txtQtdDisponivel.TabIndex = 15;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(619, 400);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(169, 38);
            btSalvar.TabIndex = 17;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(427, 400);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(169, 38);
            btCancelar.TabIndex = 18;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label4);
            Controls.Add(this.txtQtdDisponivel);
            Controls.Add(label3);
            Controls.Add(this.txtAutor);
            Controls.Add(label2);
            Controls.Add(this.txtTitulo);
            Controls.Add(label1);
            Name = "FormCadastroLivros";
            Text = "CadastroLivros";
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
    }
}