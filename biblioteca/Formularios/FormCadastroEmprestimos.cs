using biblioteca.contexto;
using biblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace biblioteca.Formularios
{
    public partial class FormCadastroEmprestimos : Form
    {
        static int id = 1;
        int contLiv = 0;
        int contLeit = 0;
        List<(int Id, int Matricula, string NomeLeitor, string Titulo, string Autor, DateTime DataEmprestimo, DateTime DataDevolucaoPrevist)> carrinho = new List<(int, int, string, string, string, DateTime, DateTime)>();
        public FormCadastroEmprestimos()
        {
            InitializeComponent();
            cbLivro.DataSource = ContextoBD.livros.Select(x => new { x.Titulo }).ToList();
            cbLivro.DisplayMember = "Titulo";
            cbLivro.SelectedIndex = -1;
            cbLeitor.DataSource = ContextoBD.leitores.ToList();
            cbLeitor.DisplayMember = "Nome";
            cbLeitor.SelectedIndex = -1;
            DateTime hoje = DateTime.Today;
            DateTime previst = hoje.AddDays(7);
            txtDataEmpr.Text = hoje.ToString("dd/MM/yyyy");
            txtDataDevolPrevist.Text = previst.ToString("dd/MM/yyyy");
        }

        private void cbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            contLiv++;
            int linhaSelect = cbLivro.SelectedIndex;
            if (linhaSelect > -1 && contLiv > 1)
            {
                var livro = ContextoBD.livros[linhaSelect];
                txtTitulo.Text = livro.Titulo.ToString();
                txtAutor.Text = livro.Autor.ToString();
                txtGenero.Text = livro.Genero.ToString();
                txtQntDisponivel.Text = livro.QuantidadeDisponivel.ToString();
            }

        }

        private void cbLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            contLeit++;
            int linhaSelect = cbLeitor.SelectedIndex;
            if (linhaSelect > -1 && contLeit > 1)
            {
                var leitor = ContextoBD.leitores[linhaSelect];
                txtMatricula.Text = leitor.Matriula.ToString();
            }


        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            int linhaSelectLivr = cbLivro.SelectedIndex;
            int linhaSelectLeit = cbLeitor.SelectedIndex;
            if (carrinho.Count >= 3)
            {
                MessageBox.Show("É possivel ter somente 3 livros por emprestimo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (carrinho.Any(x => x.Titulo == txtTitulo.Text))
            {
                MessageBox.Show("Esse livro ja foi selecionado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbLivro.SelectedIndex == -1 || cbLeitor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o livro/Leitor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else if (ContextoBD.livros[linhaSelectLivr].QuantidadeDisponivel == 0)
            {
                MessageBox.Show("Livro com nenhum exemplar disponivel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                DateTime hoje = DateTime.Today;
                DateTime previst = hoje.AddDays(7);
                carrinho.Add((Id: id, Matricula: Convert.ToInt32(txtMatricula.Text), NomeLeitor: cbLeitor.Text, Titulo: txtTitulo.Text, Autor: txtAutor.Text, DataEmprestimo: hoje, DataDevolucaoPrevist: previst));
                dgvEmprestimo.DataSource = carrinho.Select(x => new { x.Id, x.Matricula, x.Titulo, x.Autor, x.DataEmprestimo, x.DataDevolucaoPrevist }).ToList();
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
            {
                MessageBox.Show("Carrinho esta vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                foreach (var item in carrinho)
                {
                    ContextoBD.emprestimos.Add(item);
                    
                }
            }
        }
    }
}
