using biblioteca.contexto;
using biblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace biblioteca.Formularios
{
    public partial class FormCadastroEmprestimos : Form
    {
        int cont=0;
        public FormCadastroEmprestimos()
        {
            InitializeComponent();
            cbLivro.DataSource = ContextoBD.livro.ToList();
            cbLivro.DisplayMember = "Titulo";
            cbLivro.SelectedIndex = -1;

        }

        private void cbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cont++;
            int linhaSelect = cbLivro.SelectedIndex;
            if (linhaSelect > -1 && cont > 1)
            {
                var livro = ContextoBD.livro[linhaSelect];
                txtTitulo.Text = livro.Id.ToString();
                txtAutor.Text = livro.Autor.ToString();
                txtGenero.Text = livro.Genero.ToString();
            }

        }
    }
}
