namespace e_Agenda.WinApp.ModuloContato
{
    public partial class DialogContato : Form
    {
        private EntidadeContato entidadeContato;
        public DialogContato()
        {
            InitializeComponent();
        }

        public EntidadeContato Contato
        {
            set
            {
                entidadeContato = value;
                txtId.Text = entidadeContato.Id.ToString();
                txtNome.Text = entidadeContato.Nome;
                txtTelefone.Text = entidadeContato.Telefone;
                txtEmail.Text = entidadeContato.Email;
                txtCargo.Text = entidadeContato.Cargo;
                txtEmpresa.Text = entidadeContato.Empresa;
            }
            get
            {
                return entidadeContato;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            entidadeContato = new EntidadeContato(nome, telefone, email, cargo, empresa);
            List<string> resultado = entidadeContato.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (txtId.Text != "0")
                    entidadeContato.Id = Convert.ToInt32(txtId.Text);
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }

        private void txtValidarContato(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            EntidadeContato testValidar = new EntidadeContato(nome, telefone, email, cargo, empresa);
            List<string> resultado = testValidar.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
