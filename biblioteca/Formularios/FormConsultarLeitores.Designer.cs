namespace biblioteca.Formularios
{
    partial class FormConsultarLeitores
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
            label2 = new Label();
            label6 = new Label();
            this.txtTelefone = new TextBox();
            label5 = new Label();
            this.txtCurso = new TextBox();
            label4 = new Label();
            this.txtMatricula = new TextBox();
            label1 = new Label();
            this.txtNome = new TextBox();
            label3 = new Label();
            this.txtQtdEmprestimos = new TextBox();
            label7 = new Label();
            cbLeitor = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(776, 48);
            label2.TabIndex = 11;
            label2.Text = "Consultar Leitores";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(539, 145);
            label6.Name = "label6";
            label6.Size = new Size(104, 31);
            label6.TabIndex = 39;
            label6.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTelefone.Location = new Point(539, 186);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new Size(249, 38);
            this.txtTelefone.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 227);
            label5.Name = "label5";
            label5.Size = new Size(67, 31);
            label5.TabIndex = 37;
            label5.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCurso.Location = new Point(12, 268);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new Size(401, 38);
            this.txtCurso.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(416, 60);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 35;
            label4.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtMatricula.Location = new Point(416, 101);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new Size(372, 38);
            this.txtMatricula.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 33;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNome.Location = new Point(12, 186);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(504, 38);
            this.txtNome.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 234);
            label3.Name = "label3";
            label3.Size = new Size(323, 31);
            label3.TabIndex = 41;
            label3.Text = "Total de livros já emprestados:";
            // 
            // txtQtdEmprestimos
            // 
            this.txtQtdEmprestimos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtQtdEmprestimos.Location = new Point(439, 268);
            this.txtQtdEmprestimos.Name = "txtQtdEmprestimos";
            this.txtQtdEmprestimos.Size = new Size(349, 38);
            this.txtQtdEmprestimos.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 67);
            label7.Name = "label7";
            label7.Size = new Size(194, 31);
            label7.TabIndex = 47;
            label7.Text = "Selecione o leitor:";
            // 
            // cbLeitor
            // 
            cbLeitor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLeitor.FormattingEnabled = true;
            cbLeitor.Location = new Point(12, 101);
            cbLeitor.Name = "cbLeitor";
            cbLeitor.Size = new Size(375, 39);
            cbLeitor.TabIndex = 46;
            // 
            // FormConsultarLeitores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(cbLeitor);
            Controls.Add(label3);
            Controls.Add(this.txtQtdEmprestimos);
            Controls.Add(label6);
            Controls.Add(this.txtTelefone);
            Controls.Add(label5);
            Controls.Add(this.txtCurso);
            Controls.Add(label4);
            Controls.Add(this.txtMatricula);
            Controls.Add(label1);
            Controls.Add(this.txtNome);
            Controls.Add(label2);
            Name = "FormConsultarLeitores";
            Text = "FormConsultarLeitores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label6;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtCurso;
        private Label label4;
        private TextBox txtMatricula;
        private Label label1;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtQtdEmprestimos;
        private Label label7;
        private ComboBox cbLeitor;
    }
}