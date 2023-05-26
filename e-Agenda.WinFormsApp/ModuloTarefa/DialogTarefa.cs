using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class DialogTarefa : Form
    {
        private EntidadeTarefa entidadeTarefa;
        public DialogTarefa(bool edicaoDeTarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            cmbPrioridade.DataSource = Enum.GetValues<PrioridadeTarefaEnum>();

            if (edicaoDeTarefa)
            {
                txtDataCriacao.Enabled = false;
            }
        }

        public EntidadeTarefa Tarefa
        {
            set
            {
                entidadeTarefa = value;
                txtId.Text = entidadeTarefa.Id.ToString();
                txtTitulo.Text = entidadeTarefa.Titulo;
                cmbPrioridade.SelectedItem = entidadeTarefa.Prioridade;
                txtDataCriacao.Value = entidadeTarefa.DataCriacao;
            }
            get
            {
                return entidadeTarefa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;
            DateTime dataCriacao = txtDataCriacao.Value;

            entidadeTarefa = new EntidadeTarefa(titulo, prioridade, dataCriacao);

            List<string> resultado = entidadeTarefa.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (txtId.Text != "0")
                    entidadeTarefa.Id = Convert.ToInt32(txtId.Text);
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }

        private void txtValidarCompromisso(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;
            DateTime dataCriacao = txtDataCriacao.Value;

            EntidadeTarefa testValidar = new EntidadeTarefa(titulo, prioridade, dataCriacao);

            List<string> resultado = testValidar.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
            }
            else
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
