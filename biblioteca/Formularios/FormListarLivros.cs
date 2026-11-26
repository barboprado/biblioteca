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
    public partial class FormListarLivros : Form
    {
        public FormListarLivros()
        {
            InitializeComponent();
            dgvLivros.DataSource = ContextoBD.livros.Select(x => new { x.Id, x.Titulo, x.Autor, x.Genero, Exemplares = x.QuantidadeDisponivel }).ToList();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.ToLower();
            string genero = txtGenero.Text.ToLower();

            dgvLivros.DataSource = ContextoBD.livros.Where(x => x.Titulo.ToLower().Contains(titulo) &&
                                                                x.Genero.ToLower().Contains(genero))
                                                                .Select(x => new { x.Id, x.Titulo, x.Autor, x.Genero, Exemplares = x.QuantidadeDisponivel }).ToList();

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear(); txtGenero.Clear(); txtTitulo.Focus();
            dgvLivros.DataSource = ContextoBD.livros.Select(x => new { x.Id, x.Titulo, x.Autor, x.Genero, Exemplares = x.QuantidadeDisponivel }).ToList();

        }
    }
}
