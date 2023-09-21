using ReaLTaiizor.Forms;
namespace exemplo_treino
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.MdiParent = this;
            form.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor form = new FormProfessor();
            form.MdiParent = this;
            form.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso form = new FormCurso();
            form.MdiParent = this;
            form.Show();
        }

        private void relatórioDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio();
            form.MdiParent = this;
            form.Show();
        }

        private void relatórioCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioProfessor form = new FormRelatorioProfessor();
            form.MdiParent = this;
            form.Show();
        }

        private void relatórioCursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRelatorioCurso form = new FormRelatorioCurso();
            form.MdiParent = this;
            form.Show();   
           
        }
    }
}