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

            if (txtId.Text != "0")
                entidadeContato.Id = Convert.ToInt32(txtId.Text);
        }
    }
}
