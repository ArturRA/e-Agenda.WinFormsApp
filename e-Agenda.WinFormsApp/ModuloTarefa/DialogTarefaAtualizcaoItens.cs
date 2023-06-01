using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class DialogTarefaAtualizcaoItens : Form
    {
        public DialogTarefaAtualizcaoItens(EntidadeTarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(EntidadeTarefa tarefa)
        {
            txtId.Text = tarefa.Id.ToString();
            txtTitulo.Text = tarefa.Titulo;

            listItensTarefa.DataSource = tarefa.Itens;
            listItensTarefa.DisplayMember = "Titulo";
            listItensTarefa.ValueMember = "Concluido";

            for (int i = 0; i < listItensTarefa.Items.Count; i++)
            {
                ItemTarefa obj = (ItemTarefa)listItensTarefa.Items[i];
                listItensTarefa.SetItemChecked(i, obj.Concluido);
            }
        }

        public List<ItemTarefa> ObterItensChecked()
        {
            return listItensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        public List<ItemTarefa> ObterItensUnChecked()
        {
            return listItensTarefa.Items.Cast<ItemTarefa>()
                .Except(ObterItensChecked())
                .ToList();
        }
    }
}
