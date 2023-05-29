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

            int i = 0;
            foreach (ItemTarefa item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ObterItensMarcados()
        {
            return listItensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        public List<ItemTarefa> ObterItensPendentes()
        {
            return listItensTarefa.Items.Cast<ItemTarefa>()
                .Except(ObterItensMarcados())
                .ToList();
        }
    }
}
