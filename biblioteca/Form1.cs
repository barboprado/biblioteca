using biblioteca.contexto;
using biblioteca.Formularios;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroLivros form = new FormCadastroLivros();
            form.ShowDialog();
        }

        private void btLeitor_Click(object sender, EventArgs e)
        {
            FormCadastroLeitores form = new FormCadastroLeitores();
            form.ShowDialog();
        }

        private void btEmprestimo_Click(object sender, EventArgs e)
        {
            if (ContextoBD.livros.Count == 0 || ContextoBD.leitores.Count == 0)
            {
                MessageBox.Show("Não existe livro/Leitor cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FormCadastroEmprestimos form = new FormCadastroEmprestimos();
            form.ShowDialog();
            }
            
        }

        private void btListarLivros_Click(object sender, EventArgs e)
        {
            FormListarLivros form = new FormListarLivros();
            form.ShowDialog();
        }

        private void btConsultarLeitor_Click(object sender, EventArgs e)
        {
            FormConsultarLeitores form = new FormConsultarLeitores();
            form.ShowDialog();
        }

        private void btListarEmprestimos_Click_1(object sender, EventArgs e)
        {
            FormListarEmprestimos form = new FormListarEmprestimos();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
