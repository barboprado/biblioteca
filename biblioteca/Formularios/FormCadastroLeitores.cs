using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using biblioteca.Models;
using biblioteca.contexto;

namespace biblioteca.Formularios
{
    public partial class FormCadastroLeitores : Form
    {
        public FormCadastroLeitores()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Leitores leitor = new Leitores();

            leitor.nome = txtNome.Text;
            leitor.curso = txtCurso.Text;
            leitor.Matriula = Convert.ToInt32(txtMatricula.Text);
            leitor.telefone = txtTelefone.Text;

            ContextoBD.leitores.Add(leitor);

            MessageBox.Show("Leitor salvo com sucesso", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Select();
            txtCurso.Clear();
            txtNome.Clear();
            txtMatricula.Clear();
            txtTelefone.Clear();



        }

        private void FormCadastroLeitores_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Select();
            txtCurso.Clear();
            txtNome.Clear();
            txtMatricula.Clear();
            txtTelefone.Clear();
        }
    }
}
