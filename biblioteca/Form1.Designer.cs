namespace biblioteca
{
    partial class Form1
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
            label2 = new Label();
            btListarEmprestimos = new Button();
            btListarLivros = new Button();
            btConsultarLeitor = new Button();
            btLeitor = new Button();
            btEmprestimo = new Button();
            btCadastrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 295);
            label2.Name = "label2";
            label2.Size = new Size(679, 36);
            label2.TabIndex = 16;
            label2.Text = "Autores: Enzo Prado Barbosa - Gustavo Alves Soares";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // btListarEmprestimos
            // 
            btListarEmprestimos.Location = new Point(452, 174);
            btListarEmprestimos.Margin = new Padding(3, 2, 3, 2);
            btListarEmprestimos.Name = "btListarEmprestimos";
            btListarEmprestimos.Size = new Size(152, 39);
            btListarEmprestimos.TabIndex = 15;
            btListarEmprestimos.Text = "Listar Emprestimos";
            btListarEmprestimos.UseVisualStyleBackColor = true;
            btListarEmprestimos.Click += btListarEmprestimos_Click_1;
            // 
            // btListarLivros
            // 
            btListarLivros.Location = new Point(103, 174);
            btListarLivros.Margin = new Padding(3, 2, 3, 2);
            btListarLivros.Name = "btListarLivros";
            btListarLivros.Size = new Size(152, 39);
            btListarLivros.TabIndex = 14;
            btListarLivros.Text = "Listar Livros";
            btListarLivros.UseVisualStyleBackColor = true;
            btListarLivros.Click += btListarLivros_Click;
            // 
            // btConsultarLeitor
            // 
            btConsultarLeitor.Location = new Point(452, 122);
            btConsultarLeitor.Margin = new Padding(3, 2, 3, 2);
            btConsultarLeitor.Name = "btConsultarLeitor";
            btConsultarLeitor.Size = new Size(152, 39);
            btConsultarLeitor.TabIndex = 13;
            btConsultarLeitor.Text = "Consultar Leitor";
            btConsultarLeitor.UseVisualStyleBackColor = true;
            btConsultarLeitor.Click += btConsultarLeitor_Click;
            // 
            // btLeitor
            // 
            btLeitor.Location = new Point(452, 68);
            btLeitor.Margin = new Padding(3, 2, 3, 2);
            btLeitor.Name = "btLeitor";
            btLeitor.Size = new Size(152, 39);
            btLeitor.TabIndex = 12;
            btLeitor.Text = "Cadastrar Leitor";
            btLeitor.UseVisualStyleBackColor = true;
            btLeitor.Click += btLeitor_Click;
            // 
            // btEmprestimo
            // 
            btEmprestimo.Location = new Point(103, 122);
            btEmprestimo.Margin = new Padding(3, 2, 3, 2);
            btEmprestimo.Name = "btEmprestimo";
            btEmprestimo.Size = new Size(152, 39);
            btEmprestimo.TabIndex = 11;
            btEmprestimo.Text = "Cadastrar Emprestimo";
            btEmprestimo.UseVisualStyleBackColor = true;
            btEmprestimo.Click += btEmprestimo_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(103, 68);
            btCadastrar.Margin = new Padding(3, 2, 3, 2);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(152, 39);
            btCadastrar.TabIndex = 10;
            btCadastrar.Text = "Cadastrar Livro";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(679, 36);
            label1.TabIndex = 9;
            label1.Text = "Menu Prinipal - Biblioteca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(btListarEmprestimos);
            Controls.Add(btListarLivros);
            Controls.Add(btConsultarLeitor);
            Controls.Add(btLeitor);
            Controls.Add(btEmprestimo);
            Controls.Add(btCadastrar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Button btListarEmprestimos;
        private Button btListarLivros;
        private Button btConsultarLeitor;
        private Button btLeitor;
        private Button btEmprestimo;
        private Button btCadastrar;
        private Label label1;
    }
}
