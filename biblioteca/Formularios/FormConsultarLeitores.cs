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
    public partial class FormConsultarLeitores : Form
    {
        public FormConsultarLeitores()
        {
            InitializeComponent();
            cbLeitor.DisplayMember = "Nome";
            cbLeitor.DataSource=ContextoBD.leitores.ToList();
            cbLeitor.SelectedIndex = -1;
        }

        private void cbLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int verifLeitor = cbLeitor.SelectedIndex;
            if (verifLeitor > -1)
            {
                var leitor = ContextoBD.leitores[verifLeitor];
                txtNome.Text = leitor.Nome;
                txtMatricula.Text = leitor.Matriula.ToString();
                txtCurso.Text = leitor.Curso;
                txtTelefone.Text = leitor.Telefone;
                txtQtdEmprestimos.Text = ContextoBD.emprestimos.Count(x => x.Matricula == leitor.Matriula).ToString();
            }
            else
            {
                txtNome.Clear();
                txtMatricula.Clear();
                txtCurso.Clear();
                txtTelefone.Clear();
                txtQtdEmprestimos.Clear();
            }
        }
    }
}
