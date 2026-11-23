namespace biblioteca.Formularios
{
    partial class FormListarLivros
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
            label5 = new Label();
            txtGenero = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            btFiltrar = new Button();
            label3 = new Label();
            dgvLivros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(427, 138);
            label5.Name = "label5";
            label5.Size = new Size(93, 31);
            label5.TabIndex = 24;
            label5.Text = "Genêro:";
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGenero.Location = new Point(427, 179);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(361, 38);
            txtGenero.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 22;
            label2.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(12, 179);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(383, 38);
            txtTitulo.TabIndex = 21;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 48);
            label1.TabIndex = 25;
            label1.Text = "Listar Livros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btFiltrar
            // 
            btFiltrar.Location = new Point(326, 235);
            btFiltrar.Name = "btFiltrar";
            btFiltrar.Size = new Size(169, 38);
            btFiltrar.TabIndex = 27;
            btFiltrar.Text = "Filtrar";
            btFiltrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(776, 48);
            label3.TabIndex = 28;
            label3.Text = "Filtros";
            // 
            // dgvLivros
            // 
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Location = new Point(28, 288);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.RowHeadersWidth = 51;
            dgvLivros.Size = new Size(749, 150);
            dgvLivros.TabIndex = 29;
            // 
            // FormListarLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLivros);
            Controls.Add(label3);
            Controls.Add(btFiltrar);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(txtGenero);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Name = "FormListarLivros";
            Text = "ListarLivros";
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtGenero;
        private Label label2;
        private TextBox txtTitulo;
        private Label label1;
        private Button btFiltrar;
        private Label label3;
        private DataGridView dgvLivros;
    }
}