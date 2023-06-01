using e_Agenda.WinFormsApp.Compartilhado;
using e_Agenda.WinFormsApp.ModuloTarefa;
using System.ComponentModel;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public partial class DialogDespesa : Form
    {
        private EntidadeDespesa entidadeDespesa;
        private List<EntidadeCategoria> Entidades;
        public DialogDespesa(List<EntidadeCategoria> entidades)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            cmbFormaDePagamento.DataSource = Enum.GetValues<FormaDePagamento>();
            Entidades=entidades;
            ConfigurarTela(Entidades);
        }

        private void ConfigurarTela(List<EntidadeCategoria> entidades)
        {
            BindingList<EntidadeCategoria> bindingList = new BindingList<EntidadeCategoria>(Entidades);
            BindingSource source = new BindingSource(bindingList, null);
            clbCategorias.DataSource = source;
            clbCategorias.DisplayMember = "Descricao";
            clbCategorias.ValueMember = "Id";
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



                BindingList<EntidadeCategoria> bindingList = new BindingList<EntidadeCategoria>(Entidades);
                BindingSource source = new BindingSource(bindingList, null);
                clbCategorias.DataSource = source;
                clbCategorias.DisplayMember = "Descricao";
                clbCategorias.ValueMember = "Id";

                for (int i = 0; i < clbCategorias.Items.Count; i++)
                {
                    EntidadeCategoria obj = (EntidadeCategoria)clbCategorias.Items[i];
                    clbCategorias.SetItemChecked(i, obj.Despesas.Any(e => e.Id == entidadeDespesa.Id));
                }

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

        public List<EntidadeCategoria> ObterItensMarcados()
        {
            return clbCategorias.CheckedItems.Cast<EntidadeCategoria>().ToList();
        }

        public List<EntidadeCategoria> ObterItensPendentes()
        {
            return clbCategorias.Items.Cast<EntidadeCategoria>()
                .Except(ObterItensMarcados())
                .ToList();
        }
    }
}
