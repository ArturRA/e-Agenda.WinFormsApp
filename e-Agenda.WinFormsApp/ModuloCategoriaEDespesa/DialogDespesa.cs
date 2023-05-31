using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public partial class DialogDespesa : Form
    {
        private EntidadeDespesa entidadeDespesa;
        public DialogDespesa()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            cmbFormaDePagamento.DataSource = Enum.GetValues<FormaDePagamento>();
        }

        public EntidadeDespesa Despesa
        {
            get
            {
                return entidadeDespesa;
            }
            set
            {
                entidadeDespesa = value;
                labelId.Text = entidadeDespesa.Id.ToString();
                txtDescricao.Text = entidadeDespesa.Descricao;
                txtValor.Text = entidadeDespesa.Valor.ToString();
                dtpData.Value = entidadeDespesa.Data;
                cmbFormaDePagamento.SelectedItem = entidadeDespesa.FormaDePagamento;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            int valor = Convert.ToInt32(txtValor.Text);
            DateTime data = dtpData.Value;
            FormaDePagamento formaDePagamento = (FormaDePagamento)cmbFormaDePagamento.SelectedItem;

            entidadeDespesa = new EntidadeDespesa(descricao, valor, data, formaDePagamento);

            List<string> resultado = entidadeDespesa.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (labelId.Text != "0")
                    entidadeDespesa.Id = Convert.ToInt32(labelId.Text);
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
