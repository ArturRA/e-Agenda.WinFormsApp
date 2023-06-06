using e_Agenda.Dominio.ModuloCategoriaEDespesa;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public partial class DialogCategoria : Form
    {
        private EntidadeCategoria entidadeCategoria;
        public DialogCategoria()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public EntidadeCategoria Categoria
        {
            get
            {
                return entidadeCategoria;
            }
            set
            {
                entidadeCategoria = value;
                labelId.Text = entidadeCategoria.Id.ToString();
                txtDescricao.Text = entidadeCategoria.Descricao;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            entidadeCategoria = new EntidadeCategoria(descricao);

            List<string> resultado = entidadeCategoria.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (labelId.Text != "0")
                    entidadeCategoria.Id = Convert.ToInt32(labelId.Text);
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
