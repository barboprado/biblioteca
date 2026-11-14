namespace biblioteca.Formularios
{
    partial class FormCadastroLeitores
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
            btCancelar = new Button();
            btSalvar = new Button();
            label4 = new Label();
            txtQtdDisponivel = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(427, 402);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(169, 38);
            btCancelar.TabIndex = 27;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(619, 402);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(169, 38);
            btSalvar.TabIndex = 26;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(539, 110);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 25;
            label4.Text = "Matricula:";
            // 
            // txtQtdDisponivel
            // 
            txtQtdDisponivel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtdDisponivel.Location = new Point(539, 151);
            txtQtdDisponivel.Name = "txtQtdDisponivel";
            txtQtdDisponivel.Size = new Size(249, 38);
            txtQtdDisponivel.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 21;
            label2.Text = "Nome:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(12, 151);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(504, 38);
            txtTitulo.TabIndex = 20;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(776, 48);
            label1.TabIndex = 19;
            label1.Text = "Cadastrar Leitores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(67, 31);
            label5.TabIndex = 29;
            label5.Text = "Curo:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 38);
            textBox1.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(539, 192);
            label6.Name = "label6";
            label6.Size = new Size(104, 31);
            label6.TabIndex = 31;
            label6.Text = "Telefone:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(539, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 38);
            textBox2.TabIndex = 30;
            // 
            // FormCadastroLeitores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label4);
            Controls.Add(txtQtdDisponivel);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Name = "FormCadastroLeitores";
            Text = "CadastroLeitores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCancelar;
        private Button btSalvar;
        private Label label4;
        private TextBox txtQtdDisponivel;
        private Label label2;
        private TextBox txtTitulo;
        private Label label1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
    }
}