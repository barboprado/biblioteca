using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using biblioteca.contexto;

namespace biblioteca.Formularios
{
    public partial class FormCadastroLivros : Form
    {
        static int id = 1;
        public FormCadastroLivros()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ContextoBD.livros.Add((Id: id, Titulo: txtTitulo.Text, Autor: txtAutor.Text, Genero: txtGenero.Text, QuantidadeDisponivel: Convert.ToInt32(txtQtdDisponivel.Text)));
            id++;

            MessageBox.Show("Livro salvo com sucesso", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitulo.Select();
            txtAutor.Clear();
            txtGenero.Clear();
            txtQtdDisponivel.Clear();
            txtTitulo.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtTitulo.Select();
            txtAutor.Clear();
            txtGenero.Clear();
            txtQtdDisponivel.Clear();
            txtTitulo.Clear();
        }

        private void FormCadastroLivros_Load(object sender, EventArgs e)
        {

        }
    }
}
