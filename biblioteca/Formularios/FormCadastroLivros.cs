using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using biblioteca.contexto;
using biblioteca.Models;

namespace biblioteca.Formularios
{
    public partial class FormCadastroLivros : Form
    {
        public FormCadastroLivros()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Livros livro = new Livros();

            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.Genero = txtGenero.Text;
            livro.ExemplaresDisponiveis = Convert.ToInt32(txtQtdDisponivel.Text);

            ContextoBD.livro.Add(livro);

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
    }
}
