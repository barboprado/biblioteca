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
            FormCadastroEmprestimos form = new FormCadastroEmprestimos();
            form.ShowDialog();
        }

        private void btListarLivros_Click(object sender, EventArgs e)
        {

        }
    }
}
