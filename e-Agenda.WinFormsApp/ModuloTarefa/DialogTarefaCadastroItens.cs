using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class DialogTarefaCadastroItens : Form
    {
        public DialogTarefaCadastroItens(EntidadeTarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(EntidadeTarefa tarefa)
        {
            txtId.Text = tarefa.Id.ToString();

            txtTitulo.Text = tarefa.Titulo;

            listItens.Items.AddRange(tarefa.Itens.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricaoItem.Text;

            ItemTarefa itemTarefa = new ItemTarefa(descricao);

            listItens.Items.Add(itemTarefa);
        }

        public List<ItemTarefa> ObterItensCadastrados()
        {
            return listItens.Items.Cast<ItemTarefa>().ToList();
        }
    }
}
