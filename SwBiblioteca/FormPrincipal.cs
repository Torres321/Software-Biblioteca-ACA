namespace SwBiblioteca
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form formulario)

        {

            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPrincipal());
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormLibros());
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuarios());
        }
        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAutores());
        }
        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEditoriales());
        }
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPrestamos());
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormReportes());
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
